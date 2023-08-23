using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class ManagerTimesheetLineModel
    {
        public int DefaultLocationId { get; set; }
        public string DefaultLocationName { get; set; }
        public int PayScheduleId { get; set; }
        public string PayScheduleName { get; set; }
        public List<ManagerEmployeeGroup> EmployeeGroups { get; set; }
        public IList<ShiftCondition> ShiftConditions { get; set; }
        public string CostFormatted { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public bool CanEditNotesOnly { get; set; }
        public bool CanViewCosts { get; set; }
        public bool CanApprove { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? EmployeeStartDate { get; set; }
        public IList<ReportingDimensionValueBaseApiModel> DimensionValues { get; set; }
        public ClassificationSelection Classification { get; set; }
        public string EmployeeName { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        public string LocationName { get; set; }
        public string UnitType { get; set; }
        public bool IsUnitBasedWorkType { get; set; }
        public int? PayRunId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? SubmittedStart { get; set; }
        public DateTime? SubmittedEnd { get; set; }
        public decimal? Units { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimesheetLineStatusType Status { get; set; }
        public string PaySlipUrl { get; set; }
        public IList<TimesheetBreakManagerModel> Breaks { get; set; }
        public string Comments { get; set; }
        public decimal? Rate { get; set; }
        public string ExternalReferenceId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public int? PayCategoryId { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? LeaveRequestId { get; set; }
        public bool IsLocked { get; set; }
        public decimal? Cost { get; set; }
        public bool Discard { get; set; }
        public AttachmentModel Attachment { get; set; }
        public bool IsOverlapping { get; set; }
        public bool OverdrawsLeave { get; set; }
        public string ReviewedBy { get; set; }
        public TimeSpan? DurationOverride { get; set; }
        public int? AutoApprovedByRosterShiftId { get; set; }
        public decimal WorkDurationInMinutes { get; set; }
        public decimal BreaksDurationInMinutes { get; set; }
        public decimal TotalDurationInMinutes { get; set; }
        public string HiddenComments { get; set; }
        public bool ReadOnly { get; set; }
        public bool IgnoreRounding { get; set; }
    }
}
