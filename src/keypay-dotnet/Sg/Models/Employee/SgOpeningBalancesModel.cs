using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class SgOpeningBalancesModel
    {
        public decimal? WithholdingTaxAmount { get; set; }
        public decimal? ClearanceTaxAmount { get; set; }
        public OpeningBalanceCpfModel Cpf { get; set; }
        public OpeningBalancesLumpSumModel LumpSum { get; set; }
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
