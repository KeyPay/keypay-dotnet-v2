using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.RosterShift
{
    public class RosterShiftEditModel
    {
        public int? EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int LocationId { get; set; }
        public int? ResourceId { get; set; }
        public int? CopyId { get; set; }
    }
}
