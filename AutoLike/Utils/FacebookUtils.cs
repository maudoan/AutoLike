using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoLike.Utils
{
    public class FacebookUtils
    {
        internal static string CheckLiveCookie(string cookie, string userAgent = "", string proxy = "")
        {
            string output = "";

            string uid = Regex.Match(cookie, "c_user=(.*?);").Groups[1].Value;
            if (uid.Contains("="))
            {
                uid = (uid.Split('='))[0];
            }


            HttpUtils request = new HttpUtils(cookie, userAgent, proxy);
            bool flag = uid != "";
            if (flag)
            {
                string html = request.getRequest("https://mbasic.facebook.com/", @"https://mbasic.facebook.com/").ToString();
              
                if (html.Contains(uid) && html.Contains("name=\"fb_dtsg\" value=\""))
                {
                    if (html.Contains("checkpoint_title"))
                    {
                        output = "Checkpoint";
                    }
                    else
                    {
                        output = "Live";
                    }

                }
                else
                {
                    output = "Die";
                }
            }
            return output;
        }
        public static string getTokenEAAG(string cookie, bool eaaz, string userAgent = "", string proxy = "")
        {
            HttpUtils request = new HttpUtils(cookie, userAgent, proxy);
            string token = "";
            if (eaaz)
            {
                int c = 0;
                while (true)
                {
                    string GetDataToken = request.getRequest(@"https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed");
                    token = Regex.Match(GetDataToken, "EAAAAZ(.*?)\"").Value.Replace("\\\"", "");
                    if (token != "")
                    {
                        break;
                    }
                    else
                    {
                        if (c == 2)
                        {
                            break;
                        }
                        c++;
                    }
                }

            }
            else
            {
                string GetDataToken = request.getRequest(@"https://business.facebook.com/business_locations",
               @"https://business.facebook.com/select/?next=https%3A%2F%2Fbusiness.facebook.com%2F");
                token = Regex.Match(GetDataToken, "EAAG(.*?)\"").Value.Replace("\"", "");
            }

            return token;
        }
        public static List<string> getListGroupFromCookie(string cookie, string userAgent = "", string proxy = "")
        {
            //Lấy danh sách Group của 1 Cookie
            List<string> listGroup = new List<string>();
            try
            {
                HttpUtils request = new HttpUtils(cookie, userAgent, proxy);
                string html = request.getRequest(@"https://mbasic.facebook.com/groups/?seemore&refid=27",
                    @"https://mbasic.facebook.com/groups/?category=membership&ref_component=mbasic_home_header&ref_page=%2Fwap%2Fhome.php&refid=8");
                MatchCollection linkGr = Regex.Matches(html, @"m.facebook.com[\/]groups[\/](.+?)[\/]\?refid=27");
                for (int i = 0; i < linkGr.Count; i++)
                {
                    try
                    {
                        string idgr = linkGr[i].Groups[1].Value.ToString();
                        bool flag = idgr != "";
                        if (flag)
                        { listGroup.Add(idgr); }
                    }
                    catch
                    { return null; }
                }
            }
            catch
            { return null; }
            return listGroup;
        }
        public static List<string> getListPage(string token, string uid, string userAgent = "", string proxy = "")
        {
            List<string> lis = new List<string>();
            HttpUtils request = new HttpUtils("", "", "");
            int c = 0;
            while (true)
            {
                string GetDataToken = request.getRequest(@"https://graph.facebook.com/" + uid + "/accounts?access_token=" + token);
                if (GetDataToken.Contains("id"))
                {
                    JObject json = JObject.Parse(GetDataToken);
                    foreach (JToken item in ((IEnumerable<JToken>)json["data"]))
                    { lis.Add(item["id"].ToString()); }
                    break;
                }
                else
                {
                    if (c == 2)
                    {
                        break;
                    }
                    c++;
                }
            }
            return lis;

        }
    }
}
