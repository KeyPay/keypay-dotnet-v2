using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class EssLeaveRequestModel
    {
        public int LeaveCategoryId { get; set; }
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
        public decimal TotalHours { get; set; }
        public string Notes { get; set; }
        public decimal TotalDays { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public string StatusUpdateNotes { get; set; }
        public bool CanCancel { get; set; }
        public bool CanModify { get; set; }
        public bool RequireNotesForLeaveRequests { get; set; }
        public AttachmentModel Attachment { get; set; }
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
