using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
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
