using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class DeductionsResponse
    {
        public DeductionsResponse()
        {
            Deductions = new Dictionary<string, List<DeductionModel>>();
        }
        public int PayRunId { get; set; }
        public Dictionary<string, List<DeductionModel>> Deductions { get; set; }
    }
}