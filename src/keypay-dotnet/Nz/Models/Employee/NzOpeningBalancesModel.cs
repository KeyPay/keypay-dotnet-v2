using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class NzOpeningBalancesModel
    {
        public List<NzInitialDeductionModel> Deductions { get; set; }
        public decimal? PayeWithholdingAmount { get; set; }
        public decimal? AccLevyAmount { get; set; }
        public decimal? StudentLoanAmount { get; set; }
        public OpeningKiwiSaverModel KiwiSaver { get; set; }
        public IList<NzInitialEarningsModel> EarningsLines { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? GrossEarnings { get; set; }
        public IList<InitialLeaveBalanceModel> LeaveBalances { get; set; }
        public List<InitialEmployerLiabilityModel> EmployerLiabilities { get; set; }
        public int? FinancialYearStartingYear { get; set; }
        public string LocationName { get; set; }
    }
}
