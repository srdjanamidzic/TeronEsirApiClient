using System;

namespace TeronEsirClient.Enums.Utils
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class StringValueAttribute : Attribute
    {
        public StringValueAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
