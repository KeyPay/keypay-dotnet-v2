using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class RecoverPasswordModel
    {
        public string Username { get; set; }
        public MessageTypeEnum MessageType { get; set; }
    }
}
