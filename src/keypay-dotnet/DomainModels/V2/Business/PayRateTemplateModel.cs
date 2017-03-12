using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class PayRateTemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrimaryPayCategoryId { get; set; }
        public List<PayRateTemplatePayCategoryModel> PayCategories { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public decimal? MaximumQuarterlySuperContributionsBase { get; set; }
    }
}