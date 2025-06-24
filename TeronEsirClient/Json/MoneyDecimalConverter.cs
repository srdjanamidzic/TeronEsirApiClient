using Newtonsoft.Json;
using System;
using TeronEsirClient.Extensions;

namespace TeronEsirClient.Json
{
    internal sealed class MoneyDecimalConverter : JsonConverter<decimal>
    {
        public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return Convert.ToDecimal(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
        {
            int decimalPlaces = value.GetDecimalPlaces();
            if (decimalPlaces > 2)
            {
                throw new JsonSerializationException($"Value at path {writer.Path} has {decimalPlaces} decimal places. Money values can have two decimal places at most.");
            }

            writer.WriteValue(value);
        }

    }
}
