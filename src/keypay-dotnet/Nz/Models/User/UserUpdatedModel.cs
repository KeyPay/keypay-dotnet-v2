using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.User
{
    public class UserUpdatedModel
    {
        public string Username { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
