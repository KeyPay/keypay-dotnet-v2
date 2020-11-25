using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class OpeningNationalInsuranceCalculationModel
    {
        public NationalInsuranceType? Category { get; set; }
        public decimal EligibleEarnings { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal LelCalculation { get; set; }
        public decimal PtCalculation { get; set; }
        public decimal StCalculation { get; set; }
        public decimal UelCalculation { get; set; }
        public decimal UelPlusCalculation { get; set; }
        public bool DirectorsNi { get; set; }
        public decimal UstCalculation { get; set; }
    }
}
