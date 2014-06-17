using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    [Serializable]
    public class PerkSession
    {
        public CookieCollection _cookies;
        public Account _account;

        internal PerkSession(CookieCollection sessionData, Account account)
        {
            _cookies = sessionData;
            _account = account;
        }

        public async Task<int> GetCurrentPointCount()
        {
            HttpWebRequest req = CreateAuthenticatedHttpWebRequest("http://perk.com/perk/account");

            WebResponse resp = await req.GetResponseAsync();
            string respString = new StreamReader(resp.GetResponseStream()).ReadToEnd();

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(respString);

            HtmlNode node = doc.DocumentNode.SelectSingleNode("//span[@id = 'total-points']");

            if (node == null)
            {
                throw new Exception();
            }

            int points;
            if (!int.TryParse(node.InnerText, out points))
            {
                throw new Exception();
            }

            return points;
        }

        private HttpWebRequest CreateAuthenticatedHttpWebRequest(string requestUriString)
        {
            HttpWebRequest req = WebRequest.CreateHttp(requestUriString);
            req.CookieContainer = new CookieContainer();
            req.CookieContainer.Add(_cookies);

            return req;
        }
    }
}
