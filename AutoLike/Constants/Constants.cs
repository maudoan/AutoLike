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

        public static string GetNewProxyShopLike(string accessToken) 
        {  
            return getNewProxyShopLike + "?accessToken=" + accessToken; 
        }

        public static string GetCurrentProxyShopLike(string accessToken, string location)
        {
            return getCurrentProxyShopLike + "?accessToken=" + accessToken + "&&location=" + location ;
        }
    }
}
