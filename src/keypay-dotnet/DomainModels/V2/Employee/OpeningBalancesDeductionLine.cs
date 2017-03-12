namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesDeductionLine
    {
        public int DeductionCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsRESC { get; set; }
        public bool TaxExempt { get; set; }
    }
}