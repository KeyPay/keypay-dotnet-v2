using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;

namespace KeyPay.DomainModels.V2.Manager
{

    public class ManagerRosterShiftModel
    {
        public ManagerRosterShiftModel()
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

        public int? RoleId { get; set; }
        public string RoleName { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }

        public bool Published { get; set; }
        public bool Accepted { get; set; }

        public EmployeeRosterShiftSwapModel PendingSwap { get; set; }
        public DateTime? DatePublished { get; set; }
        public bool Biddable { get; set; }
    }

}