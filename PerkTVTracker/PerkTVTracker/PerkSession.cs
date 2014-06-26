using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PerkTVTracker
{
    [Serializable]
    public class PerkSession
    {
        [XmlIgnore]
        private CookieCollection _cookies;

        public string XmlCookies
        {
            get
            {
                BinaryFormatter formater = new BinaryFormatter();
                using(MemoryStream stream = new MemoryStream())
                {
                    formater.Serialize(stream, _cookies);
                    return Convert.ToBase64String(stream.ToArray());
                }
            }
            set
            {
                BinaryFormatter formater = new BinaryFormatter();
                using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(value)))
                {
                    _cookies = (CookieCollection)formater.Deserialize(stream);
                }
            }
        }

        public bool HasCookies
        { 
            get 
            { 
                if(_cookies == null)
                    return false;
                foreach(Cookie cookie in _cookies)
                {
                    if (cookie.Expired)
                        return false;
                }
                return true;
            } 
        }

        public PerkSession() { }

        internal PerkSession(CookieCollection sessionData)
        {
            _cookies = sessionData;
        }

        public async Task<KeyValuePair<int, int>> GetCurrentPointCount()
        {
            HttpWebRequest req = CreateAuthenticatedHttpWebRequest("http://perk.com/perk/account");

            WebResponse resp = await req.GetResponseAsync();
            string respString = new StreamReader(resp.GetResponseStream()).ReadToEnd();

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(respString);

            HtmlNode node = doc.DocumentNode.SelectSingleNode("//span[@id = 'total-points']");
            HtmlNode lifeTimePointsParent = doc.DocumentNode.SelectSingleNode("//div[@class = 'account-info']");
            
            if (node == null)
            {
                throw new Exception();
            }

            if (lifeTimePointsParent == null)
            {
                throw new Exception();
            }

            HtmlNode lifeTimePointsNode = lifeTimePointsParent.ChildNodes.First((n) => n.Name == "p");

            if(lifeTimePointsNode == null)
            {
                throw new Exception();
            }

            HtmlNode lifeTimeStrong = lifeTimePointsNode.ChildNodes.First((n) => n.Name == "strong");

            if (lifeTimeStrong == null)
            {
                throw new Exception();
            }

            int lifetimePoints;
            if (!int.TryParse(lifeTimeStrong.InnerText.Replace(",", ""), out lifetimePoints))
            {
                throw new Exception();
            }

            int points;
            if (!int.TryParse(node.InnerText, out points))
            {
                throw new Exception();
            }

            return new KeyValuePair<int,int>(points, lifetimePoints);
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
