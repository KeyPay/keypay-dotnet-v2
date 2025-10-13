using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class ImportBenefitCategoryModel
    {
        public bool IsPayrollingBenefit { get; set; }
        public int? TaxYear { get; set; }
        public bool? CarryBenefitForward { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BenefitCategoryTypeEnum BenefitCategoryType { get; set; }
        public string BenefitCategoryName { get; set; }
        public decimal Value { get; set; }
        public int? BenefitCategoryEnumId { get; set; }
        public string Description { get; set; }
        public string RegistrationNumber { get; set; }
        public string MakeAndModel { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BenefitCategoryCarFuelType? FuelType { get; set; }
        public DateTime? DateFirstRegistered { get; set; }
        public int? ListPrice { get; set; }
        public int? ApprovedCo2Emissions { get; set; }
        public bool? NoApprovedCo2Emissions { get; set; }
        public int? ZeroEmissionMileage { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BenefitCategoryCarEngineSize? EngineSize { get; set; }
        public bool? IsVanZeroEmissions { get; set; }
        public bool? TradingOrganisation { get; set; }
    }
}
