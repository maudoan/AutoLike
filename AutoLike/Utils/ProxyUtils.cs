using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoLike.Utils
{
    public class ProxyUtils
    {

        public async Task<string> getNewProxy(String Url) 
        {
            var proxy = string.Empty;
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage result = await client.GetAsync(Url);
                    if (result.IsSuccessStatusCode)
                    {
                        proxy = await result.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(proxy);
                        proxy = json["data"]["proxy"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
               
            }

            return proxy;
        }

        public async Task<string> getCurrentProxy(String Url)
        {
            var proxy = string.Empty;

            using (var client = new HttpClient())
            {
               try
                {
                    HttpResponseMessage result = await client.GetAsync(Url);
                    if (result.IsSuccessStatusCode)
                    {
                        proxy = await result.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(proxy);
                        proxy = json["data"]["proxy"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return proxy;
        }

        public string GetNewProxy(string Url)
        {
            var proxy = string.Empty;
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage result = client.GetAsync(Url).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        proxy = result.Content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(proxy);
                        proxy = json["data"]["proxy"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return proxy;
        }


        public string GetCurrentProxy(string Url)
        {
            var proxy = string.Empty;

            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage result = client.GetAsync(Url).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        proxy = result.Content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(proxy);
                        proxy = json["data"]["proxy"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return proxy;
        }

    }
}
