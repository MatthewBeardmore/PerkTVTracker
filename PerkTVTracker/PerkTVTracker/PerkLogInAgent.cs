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
            HttpWebRequest req = WebRequest.CreateHttp("https://perk.com/accounts/ajax_login");
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";
            req.CookieContainer = new CookieContainer();

            string content = "email=" + WebUtility.UrlEncode(account.Email) + "&password=" + WebUtility.UrlEncode(account.Password);

            using (Stream reqStream = req.GetRequestStream())
            using (var sw = new StreamWriter(reqStream))
            {
                sw.Write(content);
                sw.Close();
            }

            using (var resp = req.GetResponse() as HttpWebResponse)
            {
                return new PerkSession(new CookieCollection() { resp.Cookies });
            }
        }
    }
}
