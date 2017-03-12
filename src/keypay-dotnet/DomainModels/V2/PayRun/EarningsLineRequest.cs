using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class EarningsLineRequest
    {
        public EarningsLineRequest()
        {
            EarningsLines = new Dictionary<string, List<PayRunEarningsLineModel>>();
        }
        public int PayRunId { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string, List<PayRunEarningsLineModel>> EarningsLines { get; set; }
    }
}