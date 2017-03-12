namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesLeaveBalanceModel
    {
        public int LeaveCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}