using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class LeaveHistoryReportGroupModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LeaveCategoryType { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public List<LeaveHistoryReportDetailModel> LeaveHistoryDetails { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
