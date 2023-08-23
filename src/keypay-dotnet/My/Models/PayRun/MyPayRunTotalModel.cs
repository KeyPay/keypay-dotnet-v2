using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyPayRunTotalModel
    {
        public decimal BikTaxableAmount { get; set; }
        public decimal BikTaxExemptAmount { get; set; }
        public decimal Cp38Amount { get; set; }
        public decimal PcbBorneByEmployerAmount { get; set; }
        public decimal EpfEmployerAmount { get; set; }
        public decimal EpfEmployeeAmount { get; set; }
        public decimal EisEmployerAmount { get; set; }
        public decimal EisEmployeeAmount { get; set; }
        public decimal SocsoEmployerAmount { get; set; }
        public decimal SocsoEmployeeAmount { get; set; }
        public decimal HrdfAmount { get; set; }
        public int Id { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductions { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TotalEmployeeExpenses { get; set; }
        public decimal TotalEmployerLiabilities { get; set; }
        public bool IsPublished { get; set; }
        public int PayRunId { get; set; }
        public string Notation { get; set; }
    }
}
