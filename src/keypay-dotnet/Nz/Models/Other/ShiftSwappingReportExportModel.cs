using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class ShiftSwappingReportExportModel
    {
        public int FromEmployeeId { get; set; }
        public string FromEmployeeName { get; set; }
        public int ToEmployeeId { get; set; }
        public string ToEmployeeName { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime End { get; set; }
        public TimeSpan EndTime { get; set; }
        public string LocationId { get; set; }
        public string Location { get; set; }
        public string WorkTypeId { get; set; }
        public string WorkType { get; set; }
        public string Status { get; set; }
        public decimal? OldCost { get; set; }
        public decimal? NewCost { get; set; }
    }
}
