using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class UkBenefitCategoryEditModel
    {
        public string Name { get; set; }
        public int? Year { get; set; }
        public bool CarryBenefitForward { get; set; }
        public string BenefitType { get; set; }
        public string NiTreatment { get; set; }
        public decimal? AmountForegone { get; set; }
        public bool PayrollingBenefit { get; set; }
        public UkBenefitCategoryExtCarEditModel Car { get; set; }
        public UkBenefitCategoryExtVanEditModel Van { get; set; }
    }
}
