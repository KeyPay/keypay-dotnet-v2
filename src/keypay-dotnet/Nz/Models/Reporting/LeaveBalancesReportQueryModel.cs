using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class LeaveBalancesReportQueryModel
    {
        public int PayScheduleId { get; set; }
        public IList<Int32> EmployeeIds { get; set; }
        public int LocationId { get; set; }
        public int? LeaveTypeId { get; set; }
        public LeaveReportDisplayEnum GroupBy { get; set; }
        public int? EmployingEntityId { get; set; }
        public DateTime? AsAtDate { get; set; }
    }
}
