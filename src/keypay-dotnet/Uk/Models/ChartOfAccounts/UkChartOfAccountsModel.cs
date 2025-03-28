using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.ChartOfAccounts
{
    public class UkChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public UkChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<UkChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
        public List<UkChartOfAccountsEmployingEntityGroupModel> EmployingEntitySpecificChartOfAccounts { get; set; }
    }
}
