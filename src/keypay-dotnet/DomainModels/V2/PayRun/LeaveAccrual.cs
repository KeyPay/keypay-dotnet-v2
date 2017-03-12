namespace KeyPay.DomainModels.V2.PayRun
{
    public class LeaveAccrual
    {
        public string LeaveCategoryName { get; set; }
        public string LeaveCategoryId { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string AccrualType { get; set; }
    }
}