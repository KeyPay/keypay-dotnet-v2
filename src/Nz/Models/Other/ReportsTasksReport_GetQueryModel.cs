using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
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
