using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoLike.Utils
{
    public class ProxyUtils
    {

        private string Url;
        private string Key;
        ProxyUtils(string Url, string key) 
        {
            this.Url = Url;
            this.Key = key;
        }


        public async Task<string> getNewProxy() 
        {
            var proxy = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await  client.GetAsync(Url);
                if (result.IsSuccessStatusCode)
                {
                    proxy = await result.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(proxy);
                    proxy = json["data"]["proxy"].ToString();
                }
            }

           
            return proxy;
        }

        public async Task<string> getCurrentProxy()
        {
            var proxy = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(Url);
                if (result.IsSuccessStatusCode)
                {
                    proxy = await result.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(proxy);
                    proxy = json["data"]["proxy"].ToString();
                }
            }


            return proxy;
        }


    }
}
