using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class KioskAccessModel
    {
        public List<Int32> Kiosks { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public KioskAccessType AccessType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UserPermission Permissions { get; set; }
    }
}
