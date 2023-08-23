using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.User
{
    public class UpdateUserModel
    {
        public string Username { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
