namespace KeyPay.DomainModels.V2.PaySlip
{
    public class PaySlipLeaveModel
    {
        public string LeaveCategory { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}