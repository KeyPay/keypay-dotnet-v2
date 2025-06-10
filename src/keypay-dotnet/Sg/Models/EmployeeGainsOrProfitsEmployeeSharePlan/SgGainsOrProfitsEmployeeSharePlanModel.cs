using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeGainsOrProfitsEmployeeSharePlan
{
    public class SgGainsOrProfitsEmployeeSharePlanModel
    {
        public int Id { get; set; }
        public int BasisPeriod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SchemeType SchemeType { get; set; }
        public string CompanyName { get; set; }
        public string Uen { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PlanType PlanType { get; set; }
        public DateTime? IncorporationDate { get; set; }
        public DateTime? GrantDate { get; set; }
        public DateTime? ExerciseVestingDate { get; set; }
        public decimal? ExercisePriceAmount { get; set; }
        public decimal? MarketValuePerShareDateOfGrantAmount { get; set; }
        public decimal? MarketValuePerShareDateOfExerciseVestingAmount { get; set; }
        public decimal? NumberOfSharesAcquired { get; set; }
    }
}
