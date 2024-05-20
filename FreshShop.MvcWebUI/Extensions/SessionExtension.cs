using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FreshShop.MvcWebUI.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string jsonstr = JsonConvert.SerializeObject(value);

            session.SetString(key, jsonstr);
        }

        public static T GetObject<T>(this ISession session, string key) 
            where T : class
        {
            string jsonStr = session.GetString(key);
            if (!string.IsNullOrEmpty(jsonStr))
                return JsonConvert.DeserializeObject<T>(jsonStr);

            return null;
        }

    }
}
