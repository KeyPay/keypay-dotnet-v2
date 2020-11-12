using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class ShiftCostingBreakdownModel
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal Cost { get; set; }
        public string Type { get; set; }
        public int? LiabilityCategoryId { get; set; }
        public string LiabilityCategoryName { get; set; }
    }
}
