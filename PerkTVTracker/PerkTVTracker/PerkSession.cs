using Newtonsoft.Json.Linq;
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
        public PerkSession()
        {
        }

        internal PerkSession(string userId, string accessToken)
        {
            UserId = userId;
            AccessToken = accessToken;
        }

        public string UserId { get; set; }

        public string AccessToken { get; set; }

        public bool HasCredentials
        {
            get
            {
                return !string.IsNullOrWhiteSpace(UserId) && !string.IsNullOrWhiteSpace(AccessToken);
            }
        }

        public async Task<int> GetLifetimeVideoCount()
        {
            string apiUrl = string.Format("https://api-tv.perk.com/v3/views.json?user_id={0}", UserId);
            HttpWebRequest req = WebRequest.CreateHttp(apiUrl);

            using (WebResponse resp = await req.GetResponseAsync())
            using (var sr = new StreamReader(resp.GetResponseStream()))
            {
                JToken token = JObject.Parse(sr.ReadToEnd());
                return (int)token["data"]["lifetime_count"];
            }
        }

        public async Task<KeyValuePair<int, int>> GetCurrentPointCount()
        {
            string apiUrl = string.Format("https://api.perk.com/api/user/id/{0}/token/{1}", UserId, AccessToken);
            HttpWebRequest req = WebRequest.CreateHttp(apiUrl);

            using (WebResponse resp = await req.GetResponseAsync())
            using (var sr = new StreamReader(resp.GetResponseStream()))
            {
                JToken token = JObject.Parse(sr.ReadToEnd());
                int availablePoints = (int)token.SelectToken("availableperks");
                int redeemedPoints = (int)token.SelectToken("redeemedperks");
                int lifetimePoints = availablePoints + redeemedPoints;

                return new KeyValuePair<int, int>(availablePoints, lifetimePoints);
            }
        }
    }
}
