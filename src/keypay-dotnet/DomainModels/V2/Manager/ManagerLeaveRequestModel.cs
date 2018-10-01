using System;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerLeaveRequestModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Progress { get; set; }
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
    }
}