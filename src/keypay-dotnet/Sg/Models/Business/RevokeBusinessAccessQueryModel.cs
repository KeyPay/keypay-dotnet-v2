using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class RevokeBusinessAccessQueryModel
    {
        public string Email { get; set; }
    }
}
