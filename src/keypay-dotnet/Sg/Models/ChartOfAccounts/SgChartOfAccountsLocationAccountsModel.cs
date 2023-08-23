using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.ChartOfAccounts
{
    public class SgChartOfAccountsLocationAccountsModel
    {
        public int? CpfEmployerExpenseAccountId { get; set; }
        public int? CpfEmployerLiabilityAccountId { get; set; }
        public int? CpfEmployeeLiabilityAccountId { get; set; }
        public int? SdlEmployerExpenseAccountId { get; set; }
        public int? SdlEmployerLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}
