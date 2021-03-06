using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkOpeningBalancesModel
    {
        public List<UkInitialDeductionModel> Deductions { get; set; }
        public decimal? PayeWithholdingAmount { get; set; }
        public OpeningNationalInsuranceModel NationalInsurance { get; set; }
        public OpeningPensionsModel Pension { get; set; }
        public decimal? StudentLoanAmount { get; set; }
        public decimal? PostGradLoanAmount { get; set; }
        public decimal? PayrolledBenefitsAmount { get; set; }
        public IList<UkInitialEarningsModel> EarningsLines { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? GrossEarnings { get; set; }
        public IList<InitialLeaveBalanceModel> LeaveBalances { get; set; }
        public List<InitialEmployerLiabilityModel> EmployerLiabilities { get; set; }
        public int? FinancialYearStartingYear { get; set; }
        public string LocationName { get; set; }
    }
}
