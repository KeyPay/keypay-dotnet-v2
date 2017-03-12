using System;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class DeductionModel
    {
        public int DeductionCategoryId { get; set; }
        public string DeductionCategoryName { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int PayRunId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime DatePaid { get; set; }
        public string PayTo { get; set; }
    }
}