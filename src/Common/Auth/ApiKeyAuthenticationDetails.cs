using RestSharp.Authenticators;

namespace KeyPayV2.Common.Auth
{
    public class ApiKeyAuthenticationDetails : AuthenticationDetails
    {
        public string ApiKey { get; set; }

        public ApiKeyAuthenticationDetails(string apiKey)
        {
            ApiKey = apiKey;
        }

        public override IAuthenticator Authenticator
        {
            get { return new HttpBasicAuthenticator(ApiKey, ""); }
        }
    }
}