using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class AuOpeningBalancesModel
    {
        public decimal? PaygWithholdingAmount { get; set; }
        public decimal? SfssAmount { get; set; }
        public decimal? HelpAmount { get; set; }
        public decimal? SuperContribution { get; set; }
        public decimal? EmployerContribution { get; set; }
        public OpeningBalancesEtpModel EtpTypeR { get; set; }
        public OpeningBalancesEtpModel EtpTypeO { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? GrossEarnings { get; set; }
        public IList<InitialLeaveBalanceModel> LeaveBalances { get; set; }
        public IList<InitialEarningsModel> EarningsLines { get; set; }
        public List<InitialDeductionModel> Deductions { get; set; }
        public List<InitialEmployerLiabilityModel> EmployerLiabilities { get; set; }
        public int? FinancialYearStartingYear { get; set; }
        public string LocationName { get; set; }
    }
}
