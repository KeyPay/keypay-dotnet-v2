using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class PayRateTemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrimaryPayCategoryId { get; set; }
        public decimal? SuperThresholdAmount { get; set; }
        public List<PayRateTemplatePayCategoryModel> PayCategories { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public decimal? MaximumQuarterlySuperContributionsBase { get; set; }
        public bool ReapplyToLinkedEmployees { get; set; }
    }
}
