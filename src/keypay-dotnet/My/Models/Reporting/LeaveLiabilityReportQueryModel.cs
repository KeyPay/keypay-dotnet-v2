using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class LeaveLiabilityReportQueryModel
    {
        public int LocationId { get; set; }
        public int LeaveTypeId { get; set; }
        public bool IncludeApprovedLeave { get; set; }
        public DateTime? AsAtDate { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
