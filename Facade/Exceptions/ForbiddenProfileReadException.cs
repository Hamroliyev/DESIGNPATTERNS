using System;

namespace Facade.Exceptions
{
    public class ForbiddenProfileReadException : Exception
    {
        public ForbiddenProfileReadException()
        {
        }

        public ForbiddenProfileReadException(string message) : base(message)
        {
        }

        public ForbiddenProfileReadException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
