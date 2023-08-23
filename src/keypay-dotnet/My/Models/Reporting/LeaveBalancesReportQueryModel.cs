using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class LeaveBalancesReportQueryModel
    {
        public int LocationId { get; set; }
        public int? LeaveTypeId { get; set; }
        public LeaveReportDisplayEnum GroupBy { get; set; }
        public int? EmployingEntityId { get; set; }
        public DateTime? AsAtDate { get; set; }
    }
}
