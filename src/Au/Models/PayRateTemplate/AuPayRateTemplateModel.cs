using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRateTemplate
{
    public class AuPayRateTemplateModel
    {
        public decimal? SuperThresholdAmount { get; set; }
        public decimal? MaximumQuarterlySuperContributionsBase { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrimaryPayCategoryId { get; set; }
        public List<PayRateTemplatePayCategoryExportModel> PayCategories { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool ReapplyToLinkedEmployees { get; set; }
    }
}
