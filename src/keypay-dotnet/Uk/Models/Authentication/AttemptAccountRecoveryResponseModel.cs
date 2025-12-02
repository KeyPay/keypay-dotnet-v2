using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Authentication
{
    public class AttemptAccountRecoveryResponseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountRecoveryTypeEnum AccountRecoveryType { get; set; }
        public string SubmittedTime { get; set; }
    }
}
