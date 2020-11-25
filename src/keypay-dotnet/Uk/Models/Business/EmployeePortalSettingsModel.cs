using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Business
{
    public class EmployeePortalSettingsModel
    {
        public bool AllowEmployeeLeaveSelfService { get; set; }
        public bool AllowEmployeeSelfEditing { get; set; }
        public ESSTimesheetSettingModelEnum TimesheetSetting { get; set; }
        public bool AllowEmployeeToSetUnavailability { get; set; }
        public bool AllowEmployeeBankAccountSelfService { get; set; }
        public bool AllowEmployeeSatisfactionSurvey { get; set; }
        public bool AllowEmployeesToViewAllApprovedLeave { get; set; }
        public int UnavailabilityCutOff { get; set; }
        public bool AllowEmployeesToUploadProfilePicture { get; set; }
        public bool AllowEmployeeExpensesSelfService { get; set; }
        public bool AllowEmployeeOverrideTaxCodes { get; set; }
        public bool ShowPayDaysInEmployeeCalendar { get; set; }
        public bool EnableWorkZoneClockOn { get; set; }
        public bool RequirePhoto { get; set; }
        public bool AllowEmployeeShiftSelection { get; set; }
        public int? ClockOnWindowMinutes { get; set; }
        public int? ClockOffWindowMinutes { get; set; }
        public int? ClockOffReminderNotificationMinutes { get; set; }
        public bool SendEmployeeDetailsUpdateNotifications { get; set; }
    }
}
