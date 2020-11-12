using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ChartOfAccounts
{
    public class NzChartOfAccountsLocationAccountsModel
    {
        public int? PayeLiabilityAccountId { get; set; }
        public int? PayeExpenseAccountId { get; set; }
        public int? KiwiSaverEmployerExpenseAccountId { get; set; }
        public int? KiwiSaverEmployerLiabilityAccountId { get; set; }
        public int? KiwiSaverEmployeeLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}
