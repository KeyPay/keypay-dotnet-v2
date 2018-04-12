using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesModel
    {
        public int? EmployeeId { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? GrossEarnings { get; set; }
        public decimal? PaygWithholdingAmount { get; set; }
        public decimal? SfssAmount { get; set; }
        public decimal? HelpAmount { get; set; }
        public decimal? SuperContribution { get; set; }
        public decimal? EmployerContribution { get; set; }
        public List<OpeningBalancesLeaveBalanceModel> LeaveBalances { get; set; }
        public List<OpeningBalancesEarningsModel> EarningsLines { get; set; }
        public List<OpeningBalancesDeductionModel> Deductions { get; set; }
        public List<OpeningBalancesLiabilityModel> EmployerLiabilities { get; set; }
        public OpeningBalancesEtpModel EtpTypeR { get; set; }
        public OpeningBalancesEtpModel EtpTypeO { get; set; }
        public int? FinancialYearStartingYear { get; set; }
    }
}