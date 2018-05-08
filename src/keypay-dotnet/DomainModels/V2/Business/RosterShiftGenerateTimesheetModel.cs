using System;
using System.Collections.Generic;
using System.Web;

namespace KeyPay.DomainModels.V2.Business
{
    public class RosterShiftGenerateTimesheetModel : BaseRosterShiftModel
    {
        public string Description { get; set; }
        public bool IsDifferent { get; set; }
        public string FullyQualifiedLocationName { get; set; }

    }

    public class BaseRosterShiftModel
    {
        protected BaseRosterShiftModel()
        {
            SelectedQualifications = new List<int>();
            Breaks = new List<RosterShiftBreakModel>();
        }

        public int Id { get; set; }

        private int? _employeeId;
        public int? EmployeeId
        {
            get => _employeeId;
            set => _employeeId = value == 0 ? null : value;
        }

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
        public IList<int> SelectedQualifications { get; set; }
        public IList<RosterShiftBreakModel> Breaks { get; set; }
        public int? WorkTypeId { get; set; }
        public int? ClassificationId { get; set; }
        public string Classification { get; set; }
        public string WorkType { get; set; }
        public IList<int> ShiftConditionIds { get; set; }
        public int? RoleId { get; set; }
        public DateTime? DatePublished { get; set; }
        public int? ResourceId { get; set; }
    }

    public class RosterShiftBreakModel
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}