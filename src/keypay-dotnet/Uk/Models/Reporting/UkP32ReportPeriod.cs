using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP32ReportPeriod
    {
        public string TaxMonth { get; set; }
        public DateTime Date { get; set; }
        public decimal Paye { get; set; }
        public decimal StudentLoans { get; set; }
        public decimal PostGradLoans { get; set; }
        public decimal NetCISDeductions { get; set; }
        public decimal TotalPAYE { get; set; }
        public decimal EmployerNationalInsurance { get; set; }
        public decimal NiClass1A { get; set; }
        public decimal EmployeeNationalInsurance { get; set; }
        public decimal NationalInsuranceDeductions { get; set; }
        public decimal EmploymentAllowanceUsed { get; set; }
        public decimal TotalNationalInsurance { get; set; }
        public decimal ApprenticeshipLevy { get; set; }
        public int AdvanceFundingId { get; set; }
        public decimal AdvanceFunding { get; set; }
        public int HmrcPaymentId { get; set; }
        public decimal HmrcPayment { get; set; }
        public decimal TotalDue { get; set; }
        public decimal Balance { get; set; }
        public decimal? RemainingEmploymentAllowance { get; set; }
    }
}
