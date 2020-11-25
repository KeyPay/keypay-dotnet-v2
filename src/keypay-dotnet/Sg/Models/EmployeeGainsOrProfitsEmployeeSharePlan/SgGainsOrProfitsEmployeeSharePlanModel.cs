using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.EmployeeGainsOrProfitsEmployeeSharePlan
{
    public class SgGainsOrProfitsEmployeeSharePlanModel
    {
        public int Id { get; set; }
        public int BasisPeriod { get; set; }
        public SchemeType SchemeType { get; set; }
        public string CompanyName { get; set; }
        public string Uen { get; set; }
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
