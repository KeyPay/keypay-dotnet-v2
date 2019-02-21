using System;
using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class PayScheduleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PayCycleFrequencyEnum Frequency { get; set; }
        public PayRunEmployeeSelectionStrategy? EmployeeSelectionStrategy { get; set; }
        public DateTime? LastDatePaid { get; set; }
        public DateTime? LastPayRun { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public List<int> Locations { get; set; }
        public bool EqualMonthlyPayments { get; set; }
        public List<int> IgnoredPayRunWarnings { get; set; }
        public int? AbaDetailsId { get; set; }
        public AutoPayConfigurationModel AutoPayConfiguration { get; set; }
    }
}