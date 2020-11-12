using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class NzPayRunDetailsModel
    {
        public IList<NzPayRunTotalDetailModel> PayRunTotals { get; set; }
        public NzPayRunGrandTotalModel GrandTotal { get; set; }
        public PayRunModel PayRun { get; set; }
    }
}
