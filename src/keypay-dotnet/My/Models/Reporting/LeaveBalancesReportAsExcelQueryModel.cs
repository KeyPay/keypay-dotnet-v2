using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class LeaveBalancesReportAsExcelQueryModel
    {
        public DateTypeEnum FilterType { get; set; }
        public DateTime? AsAtDate { get; set; }
        public int? PayRunId { get; set; }
        public LeaveReportDisplayEnum GroupBy { get; set; }
        public int LocationId { get; set; }
        public List<Int32> LeaveTypeIds { get; set; }
        public int? EmployingEntityId { get; set; }
        public bool HideLeaveValues { get; set; }
    }
}
