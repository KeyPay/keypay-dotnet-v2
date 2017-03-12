namespace KeyPay.DomainModels.V2.Business
{
    public class ABAModel
    {
        public int Id { get; set; }
        public string Bsb { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string FinancialInstitutionCode { get; set; }
        public string LodgementReference { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public bool IncludeSelfBalancingTransaction { get; set; }
        public bool MergeMultipleAccountPayments { get; set; }
    }
}