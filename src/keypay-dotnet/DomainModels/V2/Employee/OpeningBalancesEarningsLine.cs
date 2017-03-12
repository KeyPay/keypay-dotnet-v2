namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesEarningsLine
    {
        public int PayCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}