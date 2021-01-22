using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class UkBenefitCategoryReadModel
    {
        public int Id { get; set; }
        public IList<UkEmployeeBenefitCategoryModel> LinkedEmployees { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public bool CarryBenefitForward { get; set; }
        public string BenefitType { get; set; }
        public string NiTreatment { get; set; }
        public decimal? AmountForegone { get; set; }
    }
}
