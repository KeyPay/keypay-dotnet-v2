using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ChartOfAccounts
{
    public class MyChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public MyChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<MyChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
    }
}
