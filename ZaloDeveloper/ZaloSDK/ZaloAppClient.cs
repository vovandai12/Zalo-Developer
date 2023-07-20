using Newtonsoft.Json.Linq;
using System.Net;
using ZaloSDK.Base;
using ZaloSDK.Config;
using ZaloSDK.Entities;
using ZaloSDK.Exception;

namespace ZaloSDK
{
    public class ZaloAppClient : ZaloBaseClient
    {
        private ZaloAppInfo _appInfo;

        public ZaloAppClient(ZaloAppInfo appInfo)
        {
            this._appInfo = appInfo;
        }

        public static Dictionary<string, string> createCookieHeader(string? cookie)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Cookie", cookie);
            return dictionary;
        }

        ///
        public JObject getFriends(string cookie, int offset, int limit, string fields)
        {
            string response = "";
            try
            {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("offset", offset.ToString());
                param.Add("limit", limit.ToString());
                param.Add("fields", fields);
                response = sendHttpGetRequest("https://openapi.zalo.me/v2.0/me", param, APIConfig.DEFAULT_HEADER, createCookieHeader(cookie));
                return JObject.Parse(response);
            }
            catch (APIException)
            {
                throw new APIException(response);
            }
        }

    }
}