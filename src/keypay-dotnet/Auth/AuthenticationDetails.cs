using RestSharp.Authenticators;

namespace KeyPay.Auth
{
    public abstract class AuthenticationDetails
    {
        public abstract IAuthenticator Authenticator { get; }
    }
}