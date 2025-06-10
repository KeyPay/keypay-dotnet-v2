using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class AuManagerRosterDataModel
    {
        public IList<AuManagerRosterShiftModel> RosteredShifts { get; set; }
        public IList<AuManagerRosterShiftModel> UnassignedShifts { get; set; }
        public IList<ManagerBiddableRosterShiftModel> BiddableShifts { get; set; }
        public IList<ManagerUnavailabilityModel> Unavailability { get; set; }
        public List<ILeaveBasedRosterShift> LeaveRequests { get; set; }
    }
}
