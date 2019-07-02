using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerRosterDataModel
    {
        public IList<ManagerRosterShiftModel> RosteredShifts { get; set; }
        public IList<ManagerRosterShiftModel> UnassignedShifts { get; set; }
        public IList<ManagerUnavailabilityModel> Unavailability { get; set; }
        public IList<ManagerLeaveRequestModel> LeaveRequests { get; set; }
    }
}
