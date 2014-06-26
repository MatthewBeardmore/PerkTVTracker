using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    [Serializable]
    public class LinearDataProcessor
    {
        private List<Sample> _samples = new List<Sample>();

        public List<Sample> Samples
        {
            get { return _samples; }
            set { _samples = value; }
        }

        public TimeSpan SampleAgeLimit { get; set; }

        public DataSummary GetDataSummary()
        {
            lock (this)
            {
                var summary = new DataSummary();

                if (_samples.Count == 0)
                {
                    return summary;
                }
                
                Sample latest = _samples.Last();

                summary.PointCount = latest.PointCount;
                summary.LifetimePointCount = latest.LifetimePointCount;
                summary.LastSampleTimestamp = latest.Time;

                if (_samples.Count > 1)
                {
                    Sample oldest = _samples[0];
                    summary.HourlyRate = Math.Round((latest.LifetimePointCount - oldest.LifetimePointCount) / (latest.Time - oldest.Time).TotalHours);
                }

                return summary;
            }
        }

        public void AddSample(int currentPointCount, int lifetimePointCount, DateTime timestamp)
        {
            lock (this)
            {
                // Add the sample, prune any old ones, and update the hourly rate
                _samples.Add(new Sample(currentPointCount, lifetimePointCount, timestamp));
                PruneSamples();
            }
        }

        private void PruneSamples()
        {
            if (_samples.Count == 0)
            {
                return;
            }

            Sample oldest = _samples[0];
            Sample latest = _samples.Last();

            if ((latest.Time - oldest.Time).TotalMinutes <= 60)
            {
                // Nothing to do
                return;
            }

            // Find the newest that's also older than an hour
            int i = 0;
            for (; i < _samples.Count; i++)
            {
                Sample sample = _samples[i];

                if ((latest.Time - sample.Time).TotalMinutes <= 60)
                {
                    break;
                }
            }

            _samples.RemoveRange(0, i);
        }

        public void ClearSamples()
        {
            _samples.Clear();
        }
    }
}
