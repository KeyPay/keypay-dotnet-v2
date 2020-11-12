using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.ChartOfAccounts
{
    public class AuChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public AuChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<AuChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
    }
}
