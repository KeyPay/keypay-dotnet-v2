using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class SubmitTimesheetRequest
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool Approved { get; set; }
        public string EmployeeIdType { get; set; }
        public string LocationIdType { get; set; }
        public string WorkTypeIdType { get; set; }
        public Dictionary<string,List<TimesheetModel>> Timesheets { get; set; }
    }
}