using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.WEB.Extensions
{
    public static class CustomSessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            var jsonData = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonData);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class, new()
        {
            var data = session.GetString(key);
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
