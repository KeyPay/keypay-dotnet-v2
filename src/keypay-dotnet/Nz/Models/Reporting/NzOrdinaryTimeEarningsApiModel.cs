using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class NzOrdinaryTimeEarningsApiModel
    {
        public decimal KiwiSaverEmployeeContribution { get; set; }
        public decimal KiwiSaverEmployerContribution { get; set; }
        public decimal EsctContribution { get; set; }
        public decimal KiwiSaverPercentageOfEarnings { get; set; }
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
