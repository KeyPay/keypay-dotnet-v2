using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class UserAccessModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RelatedUserType? AccessType { get; set; }
    }
}
