using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class ManagerRosterDataModel
    {
        public IList<ManagerRosterShiftModel> RosteredShifts { get; set; }
        public IList<ManagerRosterShiftModel> UnassignedShifts { get; set; }
        public IList<ManagerBiddableRosterShiftModel> BiddableShifts { get; set; }
        public IList<ManagerUnavailabilityModel> Unavailability { get; set; }
        public List<ILeaveBasedRosterShift> LeaveRequests { get; set; }
    }
}
