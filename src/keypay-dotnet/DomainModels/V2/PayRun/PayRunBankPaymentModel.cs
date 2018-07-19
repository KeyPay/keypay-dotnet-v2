namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunBankPaymentModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSurame { get; set; }

        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BSB { get; set; }
        public decimal Amount { get; set; }

        public string AccountType { get; set; }
        public string LodgementReference { get; set; }
    }
}