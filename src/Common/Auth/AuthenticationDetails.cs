using RestSharp.Authenticators;

namespace KeyPayV2.Common.Auth
{
    public abstract class AuthenticationDetails
    {
        public abstract IAuthenticator Authenticator { get; }
    }
}