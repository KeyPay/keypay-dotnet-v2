using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class NzEarningsLineModel
    {
        public decimal Paye { get; set; }
        public decimal KiwiSaverEmployeeContribution { get; set; }
        public decimal KiwiSaverEmployerContribution { get; set; }
        public decimal EsctContribution { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal StudentLoanMandatory { get; set; }
        public decimal StudentLoanVoluntary { get; set; }
        public string PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public string Notes { get; set; }
        public decimal? Rate { get; set; }
        public decimal Earnings { get; set; }
        public decimal LumpSumNumberOfPayPeriods { get; set; }
        public int? TimesheetLineId { get; set; }
        public string TimesheetLineExternalId { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
