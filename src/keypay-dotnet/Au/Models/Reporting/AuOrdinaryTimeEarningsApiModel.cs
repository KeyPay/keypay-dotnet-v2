using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class AuOrdinaryTimeEarningsApiModel
    {
        public decimal Super { get; set; }
        public decimal SuperPercentageOfEarnings { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string PayRun { get; set; }
        public string PayCategory { get; set; }
        public DateTime PayPeriodStarting { get; set; }
        public DateTime PayPeriodEnding { get; set; }
        public decimal Earnings { get; set; }
    }
}
