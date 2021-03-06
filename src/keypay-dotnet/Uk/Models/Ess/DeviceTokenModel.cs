using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class DeviceTokenModel
    {
        public string Token { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MobilePlatform Platform { get; set; }
    }
}
