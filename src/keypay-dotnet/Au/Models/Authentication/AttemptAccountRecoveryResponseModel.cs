using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Authentication
{
    public class AttemptAccountRecoveryResponseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountRecoveryTypeEnum AccountRecoveryType { get; set; }
        public string SubmittedTime { get; set; }
    }
}
