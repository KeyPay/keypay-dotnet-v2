using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PayrollTaxReportExportModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public decimal Amount { get; set; }
        public bool EmployeePayrollTaxExempt { get; set; }
        public bool PayCategoryPayrollTaxExempt { get; set; }
        public bool TerminationPayment { get; set; }
        public bool Allowance { get; set; }
        public bool Etp { get; set; }
        public bool GenuineRedundancy { get; set; }
        public bool LumpSumD { get; set; }
    }
}
