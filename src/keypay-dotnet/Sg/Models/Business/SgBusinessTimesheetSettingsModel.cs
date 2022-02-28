using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class SgBusinessTimesheetSettingsModel
    {
        public bool RequireStartAndStopTimes { get; set; }
        public bool RequireWorkType { get; set; }
        public bool CanSetRequireWorkTypeSetting { get; set; }
        public bool RequireLocation { get; set; }
        public bool IncludeAllTimesheetNotesInPayRun { get; set; }
        public bool TimesheetRejectionNotifications { get; set; }
        public bool ManagersCanCreateTimesheetsForEmployeesThatAreNotEnabled { get; set; }
        public bool TimesheetsEnabled { get; set; }
        public bool ApproveIfMatchesRosterShift { get; set; }
    }
}
