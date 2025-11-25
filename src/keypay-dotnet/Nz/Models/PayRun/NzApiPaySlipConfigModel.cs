using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class NzApiPaySlipConfigModel
    {
        public bool ShowKiwiSaverPercentages { get; set; }
        public bool ShowUnitsWorked { get; set; }
        public bool ShowRemainingBalanceForDeductions { get; set; }
        public bool ShowYearToDateAmounts { get; set; }
    }
}
