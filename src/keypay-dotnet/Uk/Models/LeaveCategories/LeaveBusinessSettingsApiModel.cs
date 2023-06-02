using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class LeaveBusinessSettingsApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAnniversarySetting? LeaveAnniversarySetting { get; set; }
        public DateTime? LeaveAnniversarySettingDate { get; set; }
    }
}
