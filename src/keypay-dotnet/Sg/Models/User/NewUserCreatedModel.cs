using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.User
{
    public class NewUserCreatedModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
        public string ApiKey { get; set; }
    }
}
