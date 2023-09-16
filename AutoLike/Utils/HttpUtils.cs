using System;
using System.Collections.Generic;
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


            request = new HttpRequest
            {
                KeepAlive = true,
                AllowAutoRedirect = true,
                Cookies = new CookieDictionary(false),
                UserAgent = userAgent
            };
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Accept-Language", "en-US,en;q=0.5");

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

        public string getRequest(string Url, string Referer = "", string ContentType = "")
        {
            if (Referer != "")
                request.AddHeader("Referer", Referer);
            if (ContentType == "")
                ContentType = @"application/x-www-form-urlencoded";
            request.AddHeader("ContentType", ContentType);
            string result = "";
            try
            {
                result = request.Get(Url, null).ToString();
            }
            catch { }
            return result;

        }
    }
}
