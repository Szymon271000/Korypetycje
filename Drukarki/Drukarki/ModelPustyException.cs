using System;
using System.Runtime.Serialization;

namespace Drukarki
{
    [Serializable]
    internal class ModelPustyException : Exception
    {
        public ModelPustyException(): base("Marka musi byc uzupelniona")
        {
        }

        public ModelPustyException(string message) : base(message)
        {
        }

        public ModelPustyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelPustyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}