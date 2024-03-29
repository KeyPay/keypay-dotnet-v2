using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRateTemplate
{
    public class PayRateTemplateExportModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrimaryPayCategoryId { get; set; }
        public List<PayRateTemplatePayCategoryExportModel> PayCategories { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool ReapplyToLinkedEmployees { get; set; }
    }
}
