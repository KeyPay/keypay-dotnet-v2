using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class LeaveHistoryReportQueryModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int PayScheduleId { get; set; }
        public int LocationId { get; set; }
        public IList<String> EmployeeId { get; set; }
        public int LeaveCategoryId { get; set; }
        public int EmployingEntityId { get; set; }
    }
}
