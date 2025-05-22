using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class EssTimesheetModel
    {
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public int StatusId { get; set; }
        public Attachment Attachment { get; set; }
        public int WorkDurationInMinutes { get; set; }
        public int BreaksDurationInMinutes { get; set; }
        public int TotalDurationInMinutes { get; set; }
        public int? AutoApprovedByRosterShiftId { get; set; }
        public bool LocationIsDeleted { get; set; }
        public string EmployeeName { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public int? ClassificationId { get; set; }
        public string ClassificationName { get; set; }
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
        public IList<TimesheetBreakViewModel> Breaks { get; set; }
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
        public ShiftCostingData CostingData { get; set; }
        public decimal? CostByLocation { get; set; }
        public ShiftCostingData CostingDataByLocation { get; set; }
        public bool Discard { get; set; }
        public IList<Int32> ShiftConditionIds { get; set; }
        public bool IsOverlapping { get; set; }
        public bool OverdrawsLeave { get; set; }
        public string ReviewedBy { get; set; }
        public TimeSpan? DurationOverride { get; set; }
        public string HiddenComments { get; set; }
        public bool ReadOnly { get; set; }
        public bool IgnoreRounding { get; set; }
        public IList<Int32> DimensionValueIds { get; set; }
    }
}
