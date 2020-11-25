using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
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
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
