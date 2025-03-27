using System;

namespace TeronEsirClient.Exceptions
{
    public sealed class TeronEsirConnectionException : Exception
    {
        internal TeronEsirConnectionException(string message) : base(message)
        {
        }
    }
}
