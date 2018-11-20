using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class CreatePayRunStatus
    {
        public LongRunningJobStatus Status { get; set; }
    }
}