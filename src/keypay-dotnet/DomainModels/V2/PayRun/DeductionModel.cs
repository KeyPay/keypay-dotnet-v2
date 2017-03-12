namespace KeyPay.DomainModels.V2.PayRun
{
    public class DeductionModel
    {
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DeductionCategoryId { get; set; }
        public string DeductionCategoryName { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string PayToBankAccountBSB { get; set; }
        public string PayToBankAccountNumber { get; set; }
        public string PayToSuperFundName { get; set; }
        public string PayToSuperFundMemberNumber { get; set; }
        public string PayTo { get; set; }
    }
}