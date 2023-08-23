using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class PayRateTemplatePayCategoryModel
    {
        public int PayCategoryId { get; set; }
        public decimal UserSuppliedRate { get; set; }
        public decimal CalculatedRate { get; set; }
        public decimal StandardWeeklyHours { get; set; }
        public decimal? SuperRate { get; set; }
    }
}
