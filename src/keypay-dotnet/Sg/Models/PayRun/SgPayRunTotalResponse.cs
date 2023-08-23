using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SgPayRunTotalResponse
    {
        public int PayRunId { get; set; }
        public Dictionary<String,SgPayRunTotalModel> PayRunTotals { get; set; }
    }
}
