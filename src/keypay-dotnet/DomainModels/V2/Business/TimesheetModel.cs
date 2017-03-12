using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class TimesheetModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public float Units { get; set; }
        public int WorkTypeId { get; set; }
        public int LocationId { get; set; }
        public string Comments { get; set; }
        public List<TimesheetBreakModel> Breaks { get; set; }
        public string Status { get; set; }
    }
}