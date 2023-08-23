using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class TerminateEmployeeRequest
    {
        public int EmployeeId { get; set; }
        public string TerminationReason { get; set; }
        public DateTime? TerminationDate { get; set; }
    }
}
