using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Timesheets
{
    public class SubmitTimesheetsRequest
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool Approved { get; set; }
        public IdType EmployeeIdType { get; set; }
        public IdType LocationIdType { get; set; }
        public IdType WorkTypeIdType { get; set; }
        public IDictionary<string,List<TimesheetLineModel>> Timesheets { get; set; }
    }
}