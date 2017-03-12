using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunTotalSummaryModel
    {
        public PayRunGridModel PayRun { get; set; }
        public List<PayRunTotalGridModel> PayRunTotals { get; set; }
        public PayRunGrandTotalModel GrandTotal { get; set; }
    }
}