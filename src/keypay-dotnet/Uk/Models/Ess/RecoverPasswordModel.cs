using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class RecoverPasswordModel
    {
        public string Username { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageTypeEnum MessageType { get; set; }
    }
}
