using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class DeviceTokenModel
    {
        public string Token { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MobilePlatform Platform { get; set; }
    }
}
