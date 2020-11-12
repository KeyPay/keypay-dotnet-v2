using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class AuPayRunDetailsModel
    {
        public IList<AuPayRunTotalDetailModel> PayRunTotals { get; set; }
        public AuPayRunGrandTotalModel GrandTotal { get; set; }
        public PayRunModel PayRun { get; set; }
    }
}
