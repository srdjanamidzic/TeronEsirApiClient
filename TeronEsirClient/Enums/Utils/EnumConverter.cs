using System.Reflection;
using System;
using System.Collections.Generic;

namespace TeronEsirClient.Enums.Utils
{
    internal static class EnumConverter
    {
        private readonly static Dictionary<Type, Dictionary<string, object>> enumStringValueCache = new Dictionary<Type, Dictionary<string, object>>();

        internal static string GetStringValue<T>(T value) where T : struct, Enum
        {
            var type = typeof(T);
            var fieldInfo = type.GetField(value.ToString());
            var stringValueAttribute = fieldInfo.GetCustomAttribute<StringValueAttribute>();

            if (stringValueAttribute == null)
            {
                throw new InvalidOperationException($"{type.Name}: Field {fieldInfo.Name} does not have {nameof(StringValueAttribute)} specified.");
            }

            return stringValueAttribute.Value;
        }

        internal static T ParseStringValue<T>(string stringValue) where T : struct, Enum
        {
            var cache = GetEnumStringValueCache<T>();
            if (cache.TryGetValue(stringValue, out var value))
            {
                return (T)value;
            }
            
            throw new InvalidOperationException($"{typeof(T).Name}: No field with {nameof(StringValueAttribute)} value of {stringValue} found.");
        }

        private static Dictionary<string, object> GetEnumStringValueCache<T>() where T : struct, Enum
        {
            var type = typeof(T);
            if (!enumStringValueCache.TryGetValue(type, out var cache))
            {
                cache = new Dictionary<string, object>();
                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    var stringValueAttribute = field.GetCustomAttribute<StringValueAttribute>();
                    if (stringValueAttribute != null)
                    {
                        cache.Add(stringValueAttribute.Value, field.GetValue(null));
                    }
                }
                enumStringValueCache.Add(type, cache);
            }
            
            return cache;
        }
    }
}
