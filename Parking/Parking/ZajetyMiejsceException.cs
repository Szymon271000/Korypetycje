using System;
using System.Runtime.Serialization;

namespace Parking
{
    [Serializable]
    internal class ZajetyMiejsceException : Exception
    {
        public ZajetyMiejsceException()
        {
        }

        public ZajetyMiejsceException(string message) : base("Miejsce jest zajete")
        {
        }

        public ZajetyMiejsceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ZajetyMiejsceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}