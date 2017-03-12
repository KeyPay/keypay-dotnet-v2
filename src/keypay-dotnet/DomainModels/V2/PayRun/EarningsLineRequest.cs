using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class EarningsLineRequest
    {
        public EarningsLineRequest()
        {
            EarningsLines = new Dictionary<string, List<EarningsLineModel>>();
        }
        public int PayRunId { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string, List<EarningsLineModel>> EarningsLines { get; set; }
    }
}