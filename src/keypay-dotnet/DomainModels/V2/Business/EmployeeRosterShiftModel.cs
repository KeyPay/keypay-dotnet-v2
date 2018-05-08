using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class EmployeeRosterShiftModel
    {
        public EmployeeRosterShiftModel()
        {
            Qualifications = new List<EmployeeQualificationModel>();
            Breaks = new List<EmployeeRosterShiftBreakModel>();
        }

        public int Id { get; set; }
        public string Token { get; set; }

        public IList<EmployeeQualificationModel> Qualifications { get; set; }
        public IList<EmployeeRosterShiftBreakModel> Breaks { get; set; }

        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public int? LocationId { get; set; }
        public string LocationName { get; set; }

        public int? ClassificationId { get; set; }
        public string ClassificationName { get; set; }

        public int? WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }

        public bool Published { get; set; }
        public bool Accepted { get; set; }

        public EmployeeRosterShiftSwapModel PendingSwap { get; set; }
        public DateTime? DatePublished { get; set; }
    }

    public class EmployeeQualificationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeRosterShiftBreakModel
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class EmployeeRosterShiftSwapModel
    {
        public int Id { get; set; }
        public string FromEmployee { get; set; }
        public string ToEmployee { get; set; }
        public int FromEmployeeId { get; set; }
        public int ToEmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public string RejectedReason { get; set; }
        public int Status { get; set; }
        public string StatusDescription { get; set; }
    }
}