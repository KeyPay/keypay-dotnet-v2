using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class RecoverPasswordModel
    {
        public string Username { get; set; }
        public MessageTypeEnum MessageType { get; set; }
    }
}
