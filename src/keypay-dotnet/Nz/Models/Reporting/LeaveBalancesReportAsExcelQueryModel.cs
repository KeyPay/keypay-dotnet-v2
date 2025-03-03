using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
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
