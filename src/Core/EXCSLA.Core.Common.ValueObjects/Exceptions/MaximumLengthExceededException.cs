using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EXCSLA.Core.Common.Exceptions
{
    public class MaximumLengthExceededException : Exception
    {
        public MaximumLengthExceededException()
        {
        }

        public MaximumLengthExceededException(string message) : base(message)
        {
        }

        public MaximumLengthExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MaximumLengthExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
