using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class NzPayRunTotalResponse
    {
        public int PayRunId { get; set; }
        public Dictionary<String,NzPayRunTotalModel> PayRunTotals { get; set; }
    }
}
