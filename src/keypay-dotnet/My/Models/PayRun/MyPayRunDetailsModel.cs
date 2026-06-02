using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyPayRunDetailsModel
    {
        public IList<MyPayRunTotalDetailModel> PayRunTotals { get; set; }
        public MyPayRunGrandTotalModel GrandTotal { get; set; }
        public PayRunModel PayRun { get; set; }
    }
}
