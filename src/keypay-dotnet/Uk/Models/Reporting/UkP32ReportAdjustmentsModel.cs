using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP32ReportAdjustmentsModel
    {
        public decimal Paye { get; set; }
        public decimal StudentLoans { get; set; }
        public decimal PostGradLoans { get; set; }
        public decimal NetCISDeductions { get; set; }
        public decimal EmployerNationalInsurance { get; set; }
        public decimal EmployeeNationalInsurance { get; set; }
        public decimal NationalInsuranceDeductions { get; set; }
        public decimal HmrcPayment { get; set; }
        public decimal AdvanceFunding { get; set; }
        public decimal NationalInsuranceEligibleEarnings { get; set; }
        public decimal ApprenticeshipLevyAllowance { get; set; }
        public decimal NetApprenticeshipLevy { get; set; }
        public decimal SapRecovered { get; set; }
        public decimal NicCompensationOnSap { get; set; }
        public decimal ShppRecovered { get; set; }
        public decimal NicCompensationOnShpp { get; set; }
        public decimal SmpRecovered { get; set; }
        public decimal NicCompensationOnSmp { get; set; }
        public decimal SncpRecovered { get; set; }
        public decimal NicCompensationOnSncp { get; set; }
        public decimal SppRecovered { get; set; }
        public decimal NicCompensationOnSpp { get; set; }
        public decimal SpbpRecovered { get; set; }
        public decimal NicCompensationOnSpbp { get; set; }
        public int? PayeSchemeId { get; set; }
    }
}
