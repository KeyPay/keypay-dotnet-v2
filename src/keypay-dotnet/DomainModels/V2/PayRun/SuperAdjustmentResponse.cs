using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class SuperAdjustmentResponse
    {
        public SuperAdjustmentResponse()
        {
            SuperAdjustments = new Dictionary<string, List<SuperAdjustmentModel>>();
        }

        public int PayRunId { get; set; }
        public Dictionary<string, List<SuperAdjustmentModel>> SuperAdjustments { get; set; }
    }
}