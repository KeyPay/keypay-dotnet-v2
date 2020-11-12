using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class RecoverPasswordModel
    {
        public string Username { get; set; }
        public MessageTypeEnum MessageType { get; set; }
    }
}
