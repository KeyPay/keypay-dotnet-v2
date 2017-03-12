using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class EarningsLineResponse
    {
        public EarningsLineResponse()
        {
            EarningsLines = new Dictionary<string, List<PayRunEarningsLineModel>>();
        }

        public int PayRunId { get; set; }
        public Dictionary<string, List<PayRunEarningsLineModel>> EarningsLines { get; set; }       
    }
}