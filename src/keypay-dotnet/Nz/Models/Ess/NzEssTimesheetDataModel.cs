using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class NzEssTimesheetDataModel
    {
        public List<EssTimesheetModel> Timesheets { get; set; }
        public List<EssLeaveRequestModel> LeaveRequests { get; set; }
        public List<NzEssRosterShiftModel> RosterShifts { get; set; }
        public List<PublicHolidayModel> PublicHolidays { get; set; }
    }
}
