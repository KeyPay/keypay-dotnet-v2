using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkBusinessLeaveSettingsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementCalculationMethodEnum LeaveCalculationMethod { get; set; }
        public bool RequireNotesForLeaveRequests { get; set; }
        public DateTime? LeaveYearShouldStartOn { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType LeaveAccrualStartDateType { get; set; }
    }
}
