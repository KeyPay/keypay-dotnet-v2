using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.User
{
    public class NewUserCreatedModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
        public string ApiKey { get; set; }
    }
}
