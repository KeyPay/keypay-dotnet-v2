using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class SuperContributionsReportExportModel
    {
        public string LocationName { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string SuperFundName { get; set; }
        public string SuperFundNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
