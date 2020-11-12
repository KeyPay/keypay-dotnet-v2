using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class OrdinaryTimeEarningsReportQueryModel
    {
        public int PayScheduleId { get; set; }
        public int? EmployingEntityId { get; set; }
        public int FinancialYearEnding { get; set; }
    }
}
