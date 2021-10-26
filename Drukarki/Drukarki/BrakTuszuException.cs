using System;
using System.Runtime.Serialization;

namespace Drukarki
{
    [Serializable]
    internal class BrakTuszuException : Exception
    {
        public BrakTuszuException() : base("Brak tuszu")
        {
        }

        public BrakTuszuException(string message) : base(message)
        {
        }

        public BrakTuszuException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BrakTuszuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}