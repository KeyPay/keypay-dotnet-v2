namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesEarningsModel
    {
        public int PayCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}