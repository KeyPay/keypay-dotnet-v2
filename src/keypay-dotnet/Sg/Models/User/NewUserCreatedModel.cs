using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.User
{
    public class NewUserCreatedModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
        public string ApiKey { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
