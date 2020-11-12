using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class RosterShiftGenerateTimesheetModel
    {
        public string Description { get; set; }
        public bool IsDifferent { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string NoteAuthor { get; set; }
        public string Notes { get; set; }
        public int LocationId { get; set; }
        public string EmployeeName { get; set; }
        public string Initials { get; set; }
        public string LocationName { get; set; }
        public bool Published { get; set; }
        public bool IsAccepted { get; set; }
        public IList<Int32> SelectedQualifications { get; set; }
        public IList<RosterShiftBreakModel> Breaks { get; set; }
        public int? WorkTypeId { get; set; }
        public int? ClassificationId { get; set; }
        public string Classification { get; set; }
        public string WorkType { get; set; }
        public IList<Int32> ShiftConditionIds { get; set; }
        public int? RoleId { get; set; }
        public DateTime? DatePublished { get; set; }
        public int? ResourceId { get; set; }
        public bool Biddable { get; set; }
        public IList<BiddingEmployeeModel> BiddingEmployees { get; set; }
    }
}
