using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunDetailsModel
    {
        public PayRunModel PayRun { get; set; }
        public List<PayRunTotalDetailsModel> PayRunTotals { get; set; }
        public PayRunGrandTotalModel GrandTotal { get; set; }
    }
}