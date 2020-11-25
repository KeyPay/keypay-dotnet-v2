using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.ChartOfAccounts
{
    public class ChartOfAccountsLocationAccountsModel
    {
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
        public int? StudentLoanLiabilityAccountId { get; set; }
        public int? PostgraduateStudentLoanLiabilityAccountId { get; set; }
        public int? EmployerNationalInsuranceLiabilityAccountId { get; set; }
        public int? EmployeeNationalInsuranceLiabilityAccountId { get; set; }
    }
}
