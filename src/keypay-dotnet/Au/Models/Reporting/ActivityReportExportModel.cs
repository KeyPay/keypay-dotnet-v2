using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class ActivityReportExportModel
    {
        public int EmployeeId { get; set; }
        public int LocationId { get; set; }
        public string Location { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PaygWithholding { get; set; }
        public decimal SuperContributions { get; set; }
        public decimal EmployerContributions { get; set; }
        public decimal NetEarnings { get; set; }
    }
}
