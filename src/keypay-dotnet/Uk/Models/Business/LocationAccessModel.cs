using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class LocationAccessModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LocationRestrictionFilterTypeEnum FilterType { get; set; }
        public List<Int32> LocationIds { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UserPermission Permissions { get; set; }
    }
}
