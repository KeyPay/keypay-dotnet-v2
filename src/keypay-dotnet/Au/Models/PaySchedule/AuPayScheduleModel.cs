using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PaySchedule
{
    public class AuPayScheduleModel
    {
        public int? AbaDetailsId { get; set; }
        public string PaygAccountBsb { get; set; }
        public string PaygAccountNumber { get; set; }
        public string PaygAccountName { get; set; }
        public string PaygReference { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public PayCycleFrequencyEnum Frequency { get; set; }
        public PayRunEmployeeSelectionStrategy? EmployeeSelectionStrategy { get; set; }
        public DateTime? LastDatePaid { get; set; }
        public DateTime? LastPayRun { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public List<Int32> Locations { get; set; }
        public bool EqualMonthlyPayments { get; set; }
        public List<Int32> IgnoredPayRunWarnings { get; set; }
        public AutoPayConfigurationModel AutoPayConfiguration { get; set; }
    }
}
