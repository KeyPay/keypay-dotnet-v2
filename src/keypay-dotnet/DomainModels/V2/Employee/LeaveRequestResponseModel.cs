using System;

namespace KeyPay.DomainModels.V2.Employee
{
    public class LeaveRequestResponseModel : BaseLeaveRequestResponseModel
    {
        public int Id { get; set; }
        public decimal TotalHours { get; set; }
        public decimal HoursApplied { get; set; }
        public string Employee { get; set; }
        public string LeaveCategory { get; set; }
        public string Status { get; set; }
        public int? AttachmentId { get; set; }
    }

    public class CreateLeaveRequestModel : BaseLeaveRequestResponseModel
    {
        public bool AutomaticallyApprove { get; set; }
        public decimal Hours { get; set; }
    }

    public class UpdateLeaveRequestModel : CreateLeaveRequestModel
    {
        public int Id { get; set; }
    }

    public abstract class BaseLeaveRequestResponseModel
    {
        public int EmployeeId { get; set; }
        public int LeaveCategoryId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Notes { get; set; }
    }
}