using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
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
