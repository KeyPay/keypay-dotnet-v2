using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Authentication
{
    public class OauthTokenQueryModel
    {
        public HttpRequestMessage Request { get; set; }
    }
}
