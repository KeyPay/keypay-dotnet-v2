using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class EmploymentAgreementPayRateTemplateModel
    {
        public int? PayRateTemplateId { get; set; }
        public PayRateTemplateModel PayRateTemplate { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int? MinAnniversaryMonths { get; set; }
        public int? MaxAnniversaryMonths { get; set; }
    }
}
