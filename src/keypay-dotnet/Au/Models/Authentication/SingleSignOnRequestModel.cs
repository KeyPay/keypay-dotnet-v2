using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Authentication
{
    public class SingleSignOnRequestModel
    {
        public int? BusinessId { get; set; }
        public string UserName { get; set; }
        public string Url { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NavigationDisplayEnum Navigation { get; set; }
        public string HostName { get; set; }
    }
}
