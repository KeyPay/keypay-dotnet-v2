using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class SgPayRunDetailsModel
    {
        public IList<SgPayRunTotalDetailModel> PayRunTotals { get; set; }
        public SgPayRunGrandTotalModel GrandTotal { get; set; }
        public PayRunModel PayRun { get; set; }
    }
}
