using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    public static class PerkLogInAgent
    {
        public static PerkSession Login(Account account)
        {
            HttpWebRequest req = WebRequest.CreateHttp("https://api.perk.com/oauth/token");
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";

            string content = 
                string.Format("grant_type=password&username={0}&password={1}" +
                                  "&type=email&device_type=perk_lite_chrome&client_id=11111&" +
                                  "client_secret=c437a24bf277dfea375f",
                              WebUtility.UrlEncode(account.Email),
                              WebUtility.UrlEncode(account.Password));

            using (Stream reqStream = req.GetRequestStream())
            using (var sw = new StreamWriter(reqStream))
            {
                sw.Write(content);
                sw.Close();
            }

            using (WebResponse resp = req.GetResponse())
            using (var sr = new StreamReader(resp.GetResponseStream()))
            {
                string str = sr.ReadToEnd();
                JToken token = JObject.Parse(str);

                string accessToken = (string)token.SelectToken("access_token");
                string userId = (string)token.SelectToken("user_id");

                return new PerkSession(userId, accessToken);
            }
        }
    }
}
