using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class TimesheetReportQueryModel
    {
        public int? EmployeeId { get; set; }
        public bool IncludeCosts { get; set; }
        public IList<TimesheetLineStatusType> Statuses { get; set; }
        public int? WorkTypeId { get; set; }
        public int PayScheduleId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
