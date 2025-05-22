using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class UkEssTimesheetDataModel
    {
        public List<EssTimesheetModel> Timesheets { get; set; }
        public List<EssLeaveRequestModel> LeaveRequests { get; set; }
        public List<UkEssRosterShiftModel> RosterShifts { get; set; }
        public List<PublicHolidayModel> PublicHolidays { get; set; }
    }
}
