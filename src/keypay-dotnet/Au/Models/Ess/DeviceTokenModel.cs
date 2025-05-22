using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class DeviceTokenModel
    {
        public string Token { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MobilePlatform Platform { get; set; }
    }
}
