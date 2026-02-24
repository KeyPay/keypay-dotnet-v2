using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class TimeAndAttendanceKioskModel
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public int? LocationId { get; set; }
        public string Name { get; set; }
        public string TimeZone { get; set; }
        public bool AllowHigherClassificationSelection { get; set; }
        public WhiteLabelBrandingModel Branding { get; set; }
        public bool IsLocationRequired { get; set; }
        public bool IsWorkTypeRequired { get; set; }
        public bool RestrictLocationsForEmployees { get; set; }
        public bool? AllowEmployeeShiftSelection { get; set; }
        public int? ClockOnWindowMinutes { get; set; }
        public int? ClockOffWindowMinutes { get; set; }
        public string IanaTimeZone { get; set; }
        public bool? IsPhotoRequired { get; set; }
        public bool CanAddEmployees { get; set; }
        public bool AvailableToAllRestrictedUsersWithKioskAccess { get; set; }
        public bool PaidBreaksEnabled { get; set; }
        public bool TimesheetDimensionsEnabled { get; set; }
    }
}
