using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
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
