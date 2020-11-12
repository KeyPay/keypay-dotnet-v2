using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ChartOfAccounts
{
    public class NzChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public NzChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<NzChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
    }
}
