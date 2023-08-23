using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class RosterVsTimesheetComparisonReportQueryModel
    {
        public int? EmploymentTypeId { get; set; }
        public int? EmployeeId { get; set; }
        public bool IncludeCosts { get; set; }
        public IList<TimesheetLineStatusType> TimesheetStatuses { get; set; }
        public int? WorkTypeId { get; set; }
        public int RosterLocationId { get; set; }
        public int TimesheetLocationId { get; set; }
        public IList<RosterShiftStatus> RosterStatuses { get; set; }
        public int PayScheduleId { get; set; }
        public bool IncludePostTaxDeductions { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
