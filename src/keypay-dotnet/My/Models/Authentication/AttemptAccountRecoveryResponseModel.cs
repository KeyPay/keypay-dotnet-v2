using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Authentication
{
    public class AttemptAccountRecoveryResponseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountRecoveryTypeEnum AccountRecoveryType { get; set; }
        public string SubmittedTime { get; set; }
    }
}
