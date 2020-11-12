using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
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
        public List<Int32> Locations { get; set; }
        public bool EqualMonthlyPayments { get; set; }
        public List<Int32> IgnoredPayRunWarnings { get; set; }
        public AutoPayConfigurationModel AutoPayConfiguration { get; set; }
    }
}
