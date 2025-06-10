using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class MyEssTimesheetDataModel
    {
        public List<EssTimesheetModel> Timesheets { get; set; }
        public List<EssLeaveRequestModel> LeaveRequests { get; set; }
        public List<MyEssRosterShiftModel> RosterShifts { get; set; }
        public List<PublicHolidayModel> PublicHolidays { get; set; }
    }
}
