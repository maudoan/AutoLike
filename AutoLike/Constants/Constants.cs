using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLike.Constants
{
    public static class Constants
    {
        public const string getCurrentProxyShopLike = "https://proxy.shoplike.vn/Api/getCurrentProxy";
        public const string getNewProxyShopLike = "https://proxy.shoplike.vn/Api/getNewProxy";
        public static string getPostUidShopLike = "http://shoplike.vn/Cron1123z/like_api.php?key=";

        public static string GetNewProxyShopLike(string accessToken)
        {
            return getNewProxyShopLike + "?access_token=" + accessToken;
        }

        public static string GetCurrentProxyShopLike(string accessToken, string location)
        {
            return getCurrentProxyShopLike + "?access_token=" + accessToken + "&&location=" + location;
        }
        public static string GetPostUidShopLike(string key, string type)
        {
            return getPostUidShopLike + key + "&method=get&type=" + type;
        }
    }
}