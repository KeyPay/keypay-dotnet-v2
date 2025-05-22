using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class NzManagerRosterDataModel
    {
        public IList<ManagerRosterShiftModel> RosteredShifts { get; set; }
        public IList<ManagerRosterShiftModel> UnassignedShifts { get; set; }
        public IList<ManagerBiddableRosterShiftModel> BiddableShifts { get; set; }
        public IList<ManagerUnavailabilityModel> Unavailability { get; set; }
        public List<ILeaveBasedRosterShift> LeaveRequests { get; set; }
    }
}
