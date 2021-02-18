using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class AuLeaveLiabilityExportModel
    {
        public decimal LeaveLoadingDollarValue { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? LastPaidDate { get; set; }
        public DateTime? LastPayPeriodEnding { get; set; }
        public decimal CalculatedWeeks { get; set; }
        public string Location { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? ApprovedLeaveAmount { get; set; }
        public decimal AccruedAmount { get; set; }
        public decimal LeaveValue { get; set; }
        public decimal ApprovedLeaveAmountInHours { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum UnitType { get; set; }
        public decimal AccruedAmountInHours { get; set; }
    }
}
