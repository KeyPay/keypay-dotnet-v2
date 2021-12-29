using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class ReportsTasksReport_GetQueryModel
    {
        public int EmployeeId { get; set; }
        public int PayRunId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int PayScheduleId { get; set; }
        public TasksReportStatusEnum Status { get; set; }
    }
}
