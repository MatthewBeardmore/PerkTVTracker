using HttpServer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HttpListener = HttpServer.HttpListener;

namespace PerkTVTracker
{
    public sealed class HttpListenerManager : IDisposable
    {
        //Error codes to ignore if something goes wrong
        // 1229 - An operation was attempted on a nonexistent network connection
        // 995  - The I/O operation has been aborted because of either a thread exit or an application request.
        public static readonly int[] IGNORE_ERROR_CODES = new int[3] { 64, 1229, 995 };
        private HttpListener _listener;
        private readonly Thread[] _workers;
        private ConcurrentQueue<KeyValuePair<IHttpClientContext, IHttpRequest>> _queue;
        public event Action<IHttpClientContext, IHttpRequest> ProcessRequest;
        private ManualResetEvent _newQueueItem = new ManualResetEvent(false), _listenForNextRequest = new ManualResetEvent(false);
        private bool _isRunning = false;
        private int _lockedQueue = 0;

        public HttpListenerManager(uint maxThreads)
        {
            _workers = new Thread[maxThreads];
            _queue = new ConcurrentQueue<KeyValuePair<IHttpClientContext, IHttpRequest>>();
        }

        public void Start(uint port)
        {
            _isRunning = true;
            _listener = HttpListener.Create(IPAddress.Parse("0.0.0.0"), (int)port);
            _listener.RequestReceived += _listener_RequestReceived;
            _listener.Start(5);

            for (int i = 0; i < _workers.Length; i++)
            {
                _workers[i] = new Thread(Worker);
                _workers[i].Start();
            }
        }

        void _listener_RequestReceived(object source, RequestEventArgs args)
        {
            IHttpClientContext context = (IHttpClientContext)source;
            IHttpRequest request = args.Request;

            _queue.Enqueue(new KeyValuePair<IHttpClientContext, IHttpRequest>(context, request));
            _newQueueItem.Set();
        }

        public void Dispose()
        {
            Stop();
        }

        public void Stop()
        {
            if (!_isRunning)
                return;
            _isRunning = false;
            _listener.Stop();
            _listenForNextRequest.Set();
            _newQueueItem.Set();
            foreach (Thread worker in _workers)
                worker.Join();
            try
            {
                _listener.Stop();
            }
            catch { }
        }

        private void Worker()
        {
            while ((_queue.Count > 0 || _newQueueItem.WaitOne()) && _isRunning)
            {
                _newQueueItem.Reset();
                KeyValuePair<IHttpClientContext, IHttpRequest> kvp = new KeyValuePair<IHttpClientContext,IHttpRequest>();
                if (Interlocked.CompareExchange(ref _lockedQueue, 1, 0) == 0)
                {
                    _queue.TryDequeue(out kvp);
                    //All done
                    Interlocked.Exchange(ref _lockedQueue, 0);
                }
                try
                {
                    if (kvp.Key != null)
                        ProcessRequest(kvp.Key, kvp.Value);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
