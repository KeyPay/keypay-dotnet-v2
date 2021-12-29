using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.User
{
    public class UserUpdatedModel
    {
        public string Username { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
