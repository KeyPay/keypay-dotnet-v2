namespace KeyPay.DomainModels.V2.Business
{
    public class PayRateTemplatePayCategoryModel
    {
        public int PayCategoryId { get; set; }
        public decimal UserSuppliedRate { get; set; }
        public decimal CalculatedRate { get; set; }
        public decimal StandardWeeklyHours { get; set; }
        public decimal SuperRate { get; set; }
    }
}