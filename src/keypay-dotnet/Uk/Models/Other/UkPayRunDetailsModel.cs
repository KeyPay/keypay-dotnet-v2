using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class UkPayRunDetailsModel
    {
        public IList<UkPayRunTotalDetailModel> PayRunTotals { get; set; }
        public UkPayRunGrandTotalModel GrandTotal { get; set; }
        public PayRunModel PayRun { get; set; }
    }
}
