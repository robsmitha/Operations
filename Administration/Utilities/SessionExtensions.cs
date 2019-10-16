﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Architecture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Administration.Constants;

namespace Administration.Utilities
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);
        }
    }
}