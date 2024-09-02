using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class MyOpeningBalancesModel
    {
        public OpeningBalancesMyBenefitsInKindModel BenefitsInKind { get; set; }
        public OpeningBalancesStatutoryContributionsModel StatutoryContributionsAndPcb { get; set; }
        public OpeningBalancesTaxReliefModel TaxReliefs { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? GrossEarnings { get; set; }
        public IList<InitialLeaveBalanceModel> LeaveBalances { get; set; }
        public List<InitialEmployerLiabilityModel> EmployerLiabilities { get; set; }
        public int? FinancialYearStartingYear { get; set; }
        public string LocationName { get; set; }
    }
}
