using System;

namespace KeyPay.DomainModels.V2.Employee
{
    public class OpeningBalancesEtpModel
    {
        public decimal? TaxFreeComponent { get; set; }
        public decimal? TaxableComponent { get; set; }
        public decimal? TaxWithheld { get; set; }
        public decimal? LumpSumD { get; set; }
        public bool IsAmended { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool GeneratePaymentSummary { get; set; }
    }
}