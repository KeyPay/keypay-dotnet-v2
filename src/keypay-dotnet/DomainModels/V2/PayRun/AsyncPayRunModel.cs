using System;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class AsyncPayRunModel
    {
        public int PayRunId { get; set; }
        public Guid JobId { get; set; }
    }
}