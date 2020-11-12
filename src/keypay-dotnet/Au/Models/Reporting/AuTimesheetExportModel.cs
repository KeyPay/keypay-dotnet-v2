using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class AuTimesheetExportModel
    {
        public decimal? Super { get; set; }
        public decimal? Payg { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmployeeExternalId { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime End { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime ActualStart { get; set; }
        public TimeSpan ActualStartTime { get; set; }
        public DateTime ActualEnd { get; set; }
        public TimeSpan ActualEndTime { get; set; }
        public TimeSpan TimeVariance { get; set; }
        public string FormattedTimeVariance { get; set; }
        public TimeSpan DurationExcludingBreaks { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public string WorkType { get; set; }
        public string ShiftConditions { get; set; }
        public string Classification { get; set; }
        public int NumberOfBreaks { get; set; }
        public TimeSpan BreakDuration { get; set; }
        public string Comments { get; set; }
        public int? ConsolidatedWithTimesheetLineId { get; set; }
        public string ReviewedBy { get; set; }
        public decimal? Gross { get; set; }
        public decimal? NetEarnings { get; set; }
        public decimal? EmployerLiabilities { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalCostVariance { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateReviewed { get; set; }
        public IList<String> ShiftConditionShortCodes { get; set; }
        public IList<TimesheetBreakModel> Breaks { get; set; }
    }
}
