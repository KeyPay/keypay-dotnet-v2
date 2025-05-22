using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.User
{
    public class UserUpdatedModel
    {
        public string Username { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
