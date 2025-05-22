using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class NzBusinessTimesheetSettingsModel
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
        public bool AllowPaidBreaks { get; set; }
        public bool HasMaximumPaidBreakDuration { get; set; }
        public int? MaximumPaidBreakDuration { get; set; }
    }
}
