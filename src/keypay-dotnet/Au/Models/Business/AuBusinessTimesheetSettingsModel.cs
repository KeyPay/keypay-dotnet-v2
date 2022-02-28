using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class AuBusinessTimesheetSettingsModel
    {
        public bool AllowToSelectHigherClassification { get; set; }
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
