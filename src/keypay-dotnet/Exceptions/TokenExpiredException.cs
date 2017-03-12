using System;

namespace KeyPay.Exceptions
{
    public class TokenExpiredException : Exception
    {
        public TokenExpiredException()
        {
        }
        public TokenExpiredException(string message)
            : base(message)
        {
        }
    }
}