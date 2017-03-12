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
        public List<OpeningBalancesLeaveBalance> LeaveBalances { get; set; }
        public List<OpeningBalancesEarningsLine> EarningsLines { get; set; }
        public List<OpeningBalancesDeductionLine> Deductions { get; set; }
    }
}