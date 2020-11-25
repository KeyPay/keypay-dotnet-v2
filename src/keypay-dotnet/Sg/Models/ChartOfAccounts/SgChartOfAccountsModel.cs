using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.ChartOfAccounts
{
    public class SgChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public SgChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<SgChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
    }
}
