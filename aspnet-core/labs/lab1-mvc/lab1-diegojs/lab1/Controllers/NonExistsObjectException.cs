using System;
using System.Runtime.Serialization;

namespace lab1.Controllers
{
    [Serializable]
    internal class NonExistsObjectException : Exception
    {
        public NonExistsObjectException()
        {
        }

        public NonExistsObjectException(string message) : base(message)
        {
        }

        public NonExistsObjectException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NonExistsObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}