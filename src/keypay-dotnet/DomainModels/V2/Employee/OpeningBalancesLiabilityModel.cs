namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesLiabilityModel
    {
        public int EmployerLiabilityCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}