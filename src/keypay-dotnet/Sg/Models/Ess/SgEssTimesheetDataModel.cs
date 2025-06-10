using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SgEssTimesheetDataModel
    {
        public List<EssTimesheetModel> Timesheets { get; set; }
        public List<EssLeaveRequestModel> LeaveRequests { get; set; }
        public List<SgEssRosterShiftModel> RosterShifts { get; set; }
        public List<PublicHolidayModel> PublicHolidays { get; set; }
    }
}
