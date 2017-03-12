using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PaygAdjustmentResponse
    {
        public PaygAdjustmentResponse()
        {
            PaygAdjustments = new Dictionary<string, List<PaygAdjustmentModel>>();
        }

        public int PayRunId { get; set; }
        public Dictionary<string, List<PaygAdjustmentModel>> PaygAdjustments { get; set; }
    }
}