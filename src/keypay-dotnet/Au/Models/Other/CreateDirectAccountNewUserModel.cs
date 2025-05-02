using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class CreateDirectAccountNewUserModel
    {
        public string CreateNewUserSecret { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
        public bool ApiOnly { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
