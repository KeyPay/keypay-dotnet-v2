using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class LeaveBalancesReportQueryModel
    {
        public int LocationId { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveReportDisplayEnum GroupBy { get; set; }
        public int? EmployingEntityId { get; set; }
        public DateTime? AsAtDate { get; set; }
    }
}
