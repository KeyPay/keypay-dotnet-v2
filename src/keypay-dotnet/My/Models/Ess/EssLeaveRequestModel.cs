using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class EssLeaveRequestModel
    {
        public decimal TotalHours { get; set; }
        public int LeaveCategoryId { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeclined { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsPending { get; set; }
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime RequestedDate { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal HoursPerDay { get; set; }
        public decimal TotalUnits { get; set; }
        public decimal PreviouslyAppliedUnits { get; set; }
        public bool CanPartiallyEdit { get; set; }
        public string Notes { get; set; }
        public decimal TotalDays { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public string StatusUpdateNotes { get; set; }
        public bool CanCancel { get; set; }
        public bool CanModify { get; set; }
        public bool RequireNotesForLeaveRequests { get; set; }
        public AttachmentModel Attachment { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum UnitType { get; set; }
        public PartiallyAppliedLeaveRequestBannerModel Banner { get; set; }
        public bool ManuallyApplied { get; set; }
        public string AppliedLeaveUnitTypeDescription { get; set; }
    }
}
