using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.User
{
    public class UserUpdatedModel
    {
        public string Username { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
