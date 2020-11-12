using RestSharp.Authenticators;

namespace KeyPayV2.Common.Auth
{
    public class OAuthAuthenticationDetails : AuthenticationDetails
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public OAuthAuthenticationDetails(
            string accessToken,
            string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public override IAuthenticator Authenticator
        {
            get { return new OAuth2AuthorizationRequestHeaderAuthenticator(AccessToken, "Bearer"); }
        }
    }
}