using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class AuRosterShiftGenerateTimesheetModel
    {
        public int? ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public string Description { get; set; }
        public bool IsDifferent { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public int Id { get; set; }
        public string Token { get; set; }
        public IList<QualificationModel> Qualifications { get; set; }
        public IList<RosterShiftBreakApiModel> Breaks { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        public RosterShiftRole Role { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public bool Published { get; set; }
        public bool Accepted { get; set; }
        public RosterShiftSwapModel PendingSwap { get; set; }
        public DateTime? DatePublished { get; set; }
        public bool Biddable { get; set; }
    }
}
