using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class EarningsLineResponse
    {
        public EarningsLineResponse()
        {
            EarningsLines = new Dictionary<string, List<EarningsLineModel>>();
        }

        public int PayRunId { get; set; }
        public Dictionary<string, List<EarningsLineModel>> EarningsLines { get; set; }       
    }
}