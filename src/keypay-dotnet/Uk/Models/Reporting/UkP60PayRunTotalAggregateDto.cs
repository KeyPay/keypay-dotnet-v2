using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP60PayRunTotalAggregateDto
    {
        public int EmployeeId { get; set; }
        public int LocationId { get; set; }
        public DateTime? MaxDatePaid { get; set; }
        public DateTime MaxFinalisedDate { get; set; }
        public decimal PayThisEmployment { get; set; }
        public decimal TaxThisEmployment { get; set; }
        public decimal PayPreviousEmployment { get; set; }
        public decimal TaxPreviousEmployment { get; set; }
        public decimal StatutoryMaternityPay { get; set; }
        public decimal StatutoryPaternityPay { get; set; }
        public decimal StatutoryParentalBereavementPay { get; set; }
        public decimal StatutorySharedParentalPay { get; set; }
        public decimal StatutoryAdoptionPay { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal PostgraduateLoan { get; set; }
        public string TaxCode { get; set; }
    }
}
