using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class FeaturesModel
    {
        public bool AllowEmployeeLeaveSelfService { get; set; }
        public bool AllowEmployeeSelfEditing { get; set; }
        public bool AllowEmployeeTimesheetsSelfService { get; set; }
        public bool AllowEmployeeToSetUnavailability { get; set; }
        public bool AllowEmployeeToDeclineShifts { get; set; }
        public bool AllowEmployeeSuperFundSelfService { get; set; }
        public bool AllowEmployeeKiwiSaverSelfService { get; set; }
        public bool AllowEmployeeBankAccountSelfService { get; set; }
        public bool AllowEmployeeSatisfactionSurvey { get; set; }
        public bool AllowEmployeesToViewAllApprovedLeave { get; set; }
        public int UnavailabilityCutOff { get; set; }
        public bool AllowEmployeesToUploadProfilePicture { get; set; }
        public bool AllowEmployeeRosteringSelfService { get; set; }
        public bool AllowEmployeeExpensesSelfService { get; set; }
        public bool AllowEmployeeOverrideTaxCodes { get; set; }
        public bool AllowEmployeesToEditKioskTimesheets { get; set; }
        public ESSTimesheetSetting EssTimesheetSetting { get; set; }
        public bool EmployeeMustAcceptShifts { get; set; }
        public bool AllowEmployeeTimesheetsWithoutStartStopTimes { get; set; }
        public bool AllowEmployeeToSwapShifts { get; set; }
        public bool ClockOnCanSpecifyHigherClassification { get; set; }
        public bool ClockOnRequirePhoto { get; set; }
        public bool ClockOnAllowEmployeeShiftSelection { get; set; }
        public int? ClockOnWindowMinutes { get; set; }
        public int? ClockOffWindowMinutes { get; set; }
        public bool TimesheetsRequireLocation { get; set; }
        public bool TimesheetsRequireWorkType { get; set; }
        public bool EnableWorkZoneClockOn { get; set; }
        public bool HasLeavingEmployeeForm { get; set; }
        public bool ShiftBidding { get; set; }
    }
}
