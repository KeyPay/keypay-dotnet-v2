using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class AuBusinessLeaveSettingsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementCalculationMethodEnum LeaveCalculationMethod { get; set; }
        public bool RequireNotesForLeaveRequests { get; set; }
        public DateTime? LeaveYearShouldStartOn { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType LeaveAccrualStartDateType { get; set; }
    }
}
