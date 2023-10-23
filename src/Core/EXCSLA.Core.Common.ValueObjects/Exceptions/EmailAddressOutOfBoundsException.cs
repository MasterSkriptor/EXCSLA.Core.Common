using System;
using System.Runtime.Serialization;

namespace EXCSLA.Core.Common.Exceptions
{
    [Serializable]
    public class EmailAddressOutOfBoundsException : Exception
    {
        public EmailAddressOutOfBoundsException()
        {
        }

        public EmailAddressOutOfBoundsException(string message) : base(message)
        {
        }

        public EmailAddressOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmailAddressOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}