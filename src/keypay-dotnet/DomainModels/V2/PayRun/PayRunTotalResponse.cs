using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunTotalResponse
    {
        public int PayRunId { get; set; }
        public Dictionary<string, PayRunTotalModel> PayRunTotals { get; set; }
    }
}