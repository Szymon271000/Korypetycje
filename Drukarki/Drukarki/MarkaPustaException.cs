using System;
using System.Runtime.Serialization;

namespace Drukarki
{
    [Serializable]
    internal class MarkaPustaException : Exception
    {
        public MarkaPustaException(): base("Marka musi byc uzupelniona")
        {
        }

        public MarkaPustaException(string message) : base(message)
        {
        }

        public MarkaPustaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MarkaPustaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}