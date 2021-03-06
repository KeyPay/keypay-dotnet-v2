using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class TerminateEmployeeRequest
    {
        public int EmployeeId { get; set; }
        public string TerminationReason { get; set; }
        public DateTime? TerminationDate { get; set; }
    }
}
