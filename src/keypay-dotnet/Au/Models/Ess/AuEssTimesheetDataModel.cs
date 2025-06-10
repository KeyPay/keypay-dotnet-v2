using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class AuEssTimesheetDataModel
    {
        public List<EssTimesheetModel> Timesheets { get; set; }
        public List<EssLeaveRequestModel> LeaveRequests { get; set; }
        public List<AuEssRosterShiftModel> RosterShifts { get; set; }
        public List<PublicHolidayModel> PublicHolidays { get; set; }
    }
}
