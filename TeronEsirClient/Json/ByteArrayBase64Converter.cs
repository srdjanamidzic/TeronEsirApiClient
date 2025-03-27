using Newtonsoft.Json;
using System;

namespace TeronEsirClient.Json
{
    internal sealed class ByteArrayBase64Converter : JsonConverter<byte[]>
    {
        public override byte[] ReadJson(JsonReader reader, Type objectType, byte[] existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            return Convert.FromBase64String(reader.Value.ToString());
        }

        public override void WriteJson(JsonWriter writer, byte[] value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteValue(Convert.ToBase64String(value));
        }
    }
}
