using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class PayScheduleProRataSettingsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayScheduleProRataUnitType UnitType { get; set; }
        public int Unit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayScheduleProRataQualiyfingDayType QualifyingDaysType { get; set; }
    }
}
