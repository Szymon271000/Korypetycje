using System;
using System.Runtime.Serialization;

namespace Drukarki
{
    [Serializable]
    internal class SzybkoscUjemnaException : Exception
    {
        public SzybkoscUjemnaException(): base("Szybkosc nie moze byc ujemna")
        {
        }

        public SzybkoscUjemnaException(string message) : base(message)
        {
        }

        public SzybkoscUjemnaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SzybkoscUjemnaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}