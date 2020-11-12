using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgRosterTimesheetComparisonReportExportModel
    {
        public string EmploymentType { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeExternalId { get; set; }
        public string EmployeeDefaultLocation { get; set; }
        public string PayScheduleName { get; set; }
        public int? RosteredId { get; set; }
        public string RosteredStatus { get; set; }
        public string RosteredLocation { get; set; }
        public string RosteredWorkType { get; set; }
        public DateTime? RosteredStart { get; set; }
        public TimeSpan? RosteredStartTime { get; set; }
        public DateTime? RosteredEnd { get; set; }
        public TimeSpan? RosteredEndTime { get; set; }
        public TimeSpan? RosteredDuration { get; set; }
        public TimeSpan? RosteredBreaks { get; set; }
        public decimal? RosteredCost { get; set; }
        public int? TimesheetId { get; set; }
        public string TimesheetStatus { get; set; }
        public string TimesheetLocation { get; set; }
        public string TimesheetWorkType { get; set; }
        public DateTime? TimesheetStart { get; set; }
        public TimeSpan? TimesheetStartTime { get; set; }
        public DateTime? TimesheetEnd { get; set; }
        public TimeSpan? TimesheetEndTime { get; set; }
        public TimeSpan? TimesheetDuration { get; set; }
        public TimeSpan? TimesheetBreaks { get; set; }
        public decimal? TimesheetUnits { get; set; }
        public string TimesheetUnitType { get; set; }
        public decimal? TimesheetCost { get; set; }
        public TimeSpan TimeVariance { get; set; }
        public decimal CostVariance { get; set; }
    }
}
