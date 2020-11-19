using System;
using System.Linq;
using RestSharp;
using RestSharp.Authenticators;

namespace KeyPayV2.Common.Auth
{
    /// <summary>
    /// The OAuth 2 authenticator using the authorization request header field.
    /// </summary>
    /// <remarks>
    /// Based on http://tools.ietf.org/html/draft-ietf-oauth-v2-10#section-5.1.1
    /// </remarks>
    public class OAuth2AuthorizationRequestHeaderAuthenticator : RestSharp.Authenticators.OAuth2AuthorizationRequestHeaderAuthenticator
    {
        /// <summary>
        /// Stores the Authorization header value as "[tokenType] accessToken". used for performance.
        /// </summary>
        private readonly string authorizationValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AuthorizationRequestHeaderAuthenticator"/> class.
        /// </summary>
        /// <param name="accessToken">
        /// The access token.
        /// </param>
        public OAuth2AuthorizationRequestHeaderAuthenticator(string accessToken)
            : this(accessToken, "OAuth")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AuthorizationRequestHeaderAuthenticator"/> class.
        /// </summary>
        /// <param name="accessToken">
        /// The access token.
        /// </param>
        /// <param name="tokenType">
        /// The token type.
        /// </param>
        public OAuth2AuthorizationRequestHeaderAuthenticator(string accessToken, string tokenType)
            : base(accessToken)
        {
            // Conatenate during constructor so that it is only done once. can improve performance.
            authorizationValue = tokenType + " " + accessToken;
        }
    }
}