using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace AutoLike.Utils
{
    public class HttpUtils
    {
        private readonly HttpRequest request;
        public HttpUtils(string cookie = "", string userAgent = "", string proxy = "")
        {
            bool UA = userAgent == "";
            bool CK = cookie != "";
            bool PX = proxy != "";

            if (UA)
            {
                string[] ua = File.ReadAllText("user_agent.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                Random rd = new Random();
                userAgent = ua[rd.Next(0, ua.Length)];
            }
            request = new HttpRequest
            {
                KeepAlive = true,
                AllowAutoRedirect = true,
                Cookies = new CookieDictionary(false),
                UserAgent = userAgent
            };
            request.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            request.AddHeader("accept-language", "en-US,en;q=0.9,vi;q=0.8");
            request.AddHeader("dpr", "1");
            request.AddHeader("cache-control", "max-age=0");
            request.AddHeader("sec-ch-prefers-color-scheme", "dark");
            request.AddHeader("sec-ch-ua", "\"Not/A)Brand\";v=\"99\", \"Google Chrome\";v=\"115\", \"Chromium\";v=\"115\"");
            request.AddHeader("sec-ch-ua-full-version-list", "\"Not/A)Brand\";v=\"99.0.0.0\", \"Google Chrome\";v=\"115.0.5790.173\", \"Chromium\";v=\"115.0.5790.173\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-model", "\"\"");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-ch-ua-platform-version", "\"15.0.0\"");
            request.AddHeader("sec-fetch-dest", "document");
            request.AddHeader("sec-fetch-mode", "navigate");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("sec-fetch-user", "?1");
            request.AddHeader("user-agent", userAgent);
            request.AddHeader("viewport-width", "601");
            request.AddHeader("upgrade-insecure-requests", "1");
            request.AddHeader("cookie", cookie);
            //request.AddHeader("Referer", "https://mbasic.facebook.com/");
            //request.AddHeader("Origin", "https://mbasic.facebook.com/");
            request.AddHeader("Referrer-Policy", "strict-origin-when-cross-origin");

            if (CK)
            {
                List<string> k = new List<string>();
                string[] temp = cookie.Split(new char[] { ';' });
                foreach (string item in temp)
                {
                    string[] temp2 = item.Split(new char[] { '=' });
                    if (!k.Contains(temp2[0].ToString()))
                    {
                        k.Add(temp2[0].ToString());
                        bool flag = temp2.Count<string>() >= 2 && (temp2[0].Contains("sb") || temp2[0].Contains("c_user") || temp2[0].Contains("datr") ||
                            temp2[0].Contains("locale") || temp2[0].Contains("xs") || temp2[0].Contains("spin") || temp2[0].Contains("presence") || temp2[0].Contains("fr") || temp2[0].Contains("wd") || temp2[0].Contains("Authorization") || temp2[0].Contains("YWRtaW4gZmQ3Mjg5NA"));

                        if (flag)
                        { request.Cookies.Add(temp2[0].Trim(), temp2[1].Trim()); }
                    }
                    else { }

                }
            }
            if (PX)
            {

                switch (proxy.Split(new char[] { ':' }).Count<string>())
                {
                    case 1:
                        request.Proxy = new HttpProxyClient("127.0.0.1:", Convert.ToInt32(proxy));
                        break;
                    case 2:
                        request.Proxy = HttpProxyClient.Parse(proxy);
                        break;
                    case 4:
                        request.Proxy = new HttpProxyClient(proxy.Split(new char[] { ':' })[0],
                            Convert.ToInt32(proxy.Split(new char[] { ':' })[1]),
                            proxy.Split(new char[] { ':' })[2],
                            proxy.Split(new char[] { ':' })[3]);
                        break;
                }
            }
        }

        internal string getRequest(string Url, string Referer = "", string ContentType = "")
        {
            if (Referer != "")
            {
                request.AddHeader("Referer", Referer);
                request.AddHeader("Origin", Referer);
            }
               
            request.AddHeader("Origin", Referer);
            if (ContentType == "")
                ContentType = @"application/x-www-form-urlencoded";
            request.AddHeader("ContentType", ContentType);
            string rs = "";
            try
            {
                rs = request.Get(Url, null).ToString();
            }
            catch { }
            return rs;

        }
    }
}
