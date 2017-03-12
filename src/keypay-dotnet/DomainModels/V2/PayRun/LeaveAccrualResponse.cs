using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class LeaveAccrualResponse
    {
        public int PayRunId { get; set; }
        public Dictionary<string, List<LeaveAccrualModel>> Leave { get; set; } 
    }
}