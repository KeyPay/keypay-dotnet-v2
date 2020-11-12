using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class PreviousEmployerEditModel
    {
        public int FinancialYearStarting { get; set; }
        public decimal TaxablePay { get; set; }
        public decimal TaxWithheld { get; set; }
        public DateTime? LeavingDate { get; set; }
        public string OfficeNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public bool StudentLoanDeductions { get; set; }
        public bool WeekOneMonthOne { get; set; }
        public string TaxPeriodFrequency { get; set; }
        public int? TaxPeriodNumber { get; set; }
        public string TaxCode { get; set; }
    }
}
