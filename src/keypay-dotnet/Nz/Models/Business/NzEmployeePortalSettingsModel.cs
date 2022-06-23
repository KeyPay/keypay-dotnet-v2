using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class NzEmployeePortalSettingsModel
    {
        public bool AllowEmployeeKiwiSaverSelfService { get; set; }
        public bool AllowEmployeeLeaveSelfService { get; set; }
        public bool AllowEmployeeSelfEditing { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
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
        public int? ClockOnReminderNotificationMinutes { get; set; }
        public int? ClockOffReminderNotificationMinutes { get; set; }
        public bool SendEmployeeDetailsUpdateNotifications { get; set; }
    }
}
