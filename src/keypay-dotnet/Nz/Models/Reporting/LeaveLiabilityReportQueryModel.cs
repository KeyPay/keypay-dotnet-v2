using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class LeaveLiabilityReportQueryModel
    {
        public int PayScheduleId { get; set; }
        public IList<Int32> EmployeeIds { get; set; }
        public Guid? JobId { get; set; }
        public DateTypeEnum FilterType { get; set; }
        public int LocationId { get; set; }
        public int LeaveTypeId { get; set; }
        public bool IncludeApprovedLeave { get; set; }
        public DateTime? AsAtDate { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? PayRunId { get; set; }
        public List<Int32> LeaveTypeIds { get; set; }
        public LeaveReportDisplayEnum? GroupBy { get; set; }
    }
}
