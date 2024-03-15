using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSmpApiRequestModel
    {
        public int LeaveDataId { get; set; }
        public int LeaveAccrualId { get; set; }
        public int LeaveAccrualIdOmp { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? Rate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SmpPayTypeEnum PayType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DoNotPaySmpReasonEnum? DoNotPayReason { get; set; }
    }
}
