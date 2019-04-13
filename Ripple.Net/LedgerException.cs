using System;
using System.Runtime.Serialization;

namespace Ripple.Net
{
    public class LedgerException : Exception
    {
        public LedgerException()
        { }

        public LedgerException(string message) : base(message)
        { }

        public LedgerException(string message, Exception innerException) : base(message, innerException)
        { }

        protected LedgerException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
