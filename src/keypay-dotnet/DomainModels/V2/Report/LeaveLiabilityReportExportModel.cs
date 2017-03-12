using System;

namespace KeyPay.DomainModels.V2.Report
{
    public class LeaveLiabilityReportExportModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? LastPaidDate { get; set; }
        public decimal CalculatedWeeks { get; set; }
        public string Location { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? ApprovedLeaveAmount { get; set; }
        public decimal AccruedAmount { get; set; }
        public decimal AccruedAmountInDays { get; set; }
        public decimal LeaveValue { get; set; }
        public decimal LeaveLoadingDollarValue { get; set; }
    }
}