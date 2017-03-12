namespace KeyPay.DomainModels.V2.PayRun
{
    public class SuperAdjustmentModel
    {
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string ContributionType { get; set; }
    }
}