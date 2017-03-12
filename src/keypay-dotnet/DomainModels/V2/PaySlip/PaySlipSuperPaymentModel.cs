namespace KeyPay.DomainModels.V2.PaySlip
{
    public class PaySlipSuperPaymentModel
    {
        public string FundName { get; set; }
        public string MemberNumber { get; set; }
        public decimal Amount { get; set; }
    }
}