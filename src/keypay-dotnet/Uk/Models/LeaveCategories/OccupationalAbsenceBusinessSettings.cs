using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class OccupationalAbsenceBusinessSettings
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public OccupationalAbsenceEntitlementPeriodType OccupationalAbsenceEntitlementPeriod { get; set; }
    }
}
