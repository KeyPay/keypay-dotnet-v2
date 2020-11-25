using System;

namespace KeyPayV2.Common.Exceptions
{
    public class TokenExpiredException : Exception
    {
        public TokenExpiredException()
        {
        }
        public TokenExpiredException(string message) : base(message)
        {
        }
    }
}