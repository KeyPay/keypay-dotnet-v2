using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class UkBenefitCategoryExtCarEditModel
    {
        public string RegistrationNumber { get; set; }
        public string MakeAndModel { get; set; }
        public DateTime? DateRegistered { get; set; }
        public string FuelType { get; set; }
        public int? ApprovedCO2Emissions { get; set; }
        public bool NoApprovedCO2Figure { get; set; }
        public string EngineSize { get; set; }
        public int? ZeroEmissionMileage { get; set; }
    }
}
