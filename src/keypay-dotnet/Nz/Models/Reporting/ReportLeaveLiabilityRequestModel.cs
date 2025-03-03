using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class ReportLeaveLiabilityRequestModel
    {
        public Guid? JobId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DateTypeEnum FilterType { get; set; }
        public int LocationId { get; set; }
        public int LeaveTypeId { get; set; }
        public bool IncludeApprovedLeave { get; set; }
        public DateTime? AsAtDate { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? PayRunId { get; set; }
        public List<Int32> LeaveTypeIds { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveReportDisplayEnum? GroupBy { get; set; }
    }
}
