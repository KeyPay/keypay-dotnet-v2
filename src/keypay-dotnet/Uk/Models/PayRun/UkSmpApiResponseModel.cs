using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSmpApiResponseModel
    {
        public int LeaveAccrualId { get; set; }
        public int? LeaveAccrualIdOmp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SmpEligibilityEnum Status { get; set; }
        public IList<StatutoryLeaveLogEvent> Log { get; set; }
        public IList<UkSmpApiRateResponseModel> Rates { get; set; }
    }
}
