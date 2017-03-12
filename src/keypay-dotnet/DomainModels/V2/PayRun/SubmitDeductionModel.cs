namespace KeyPay.DomainModels.V2.PayRun
{
    public class SubmitDeductionModel
    {
        public string DeductionCategoryId { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
    }
}