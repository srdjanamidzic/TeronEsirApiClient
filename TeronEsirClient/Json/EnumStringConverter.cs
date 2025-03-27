using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Json
{
    internal sealed class EnumStringConverter<T> : JsonConverter<T> where T : struct, Enum
    {
        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return EnumConverter.ParseStringValue<T>(reader.Value.ToString());
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            writer.WriteValue(EnumConverter.GetStringValue(value));
        }
    }
}
