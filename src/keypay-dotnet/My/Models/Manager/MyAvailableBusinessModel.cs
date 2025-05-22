using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class MyAvailableBusinessModel
    {
        public string BusinessNumber { get; set; }
        public WhiteLabelBrandingModel Branding { get; set; }
        public DateTime TimesheetEntryPeriodEnd { get; set; }
        public bool IsPayrollAdmin { get; set; }
        public bool CanApproveLeaveRequests { get; set; }
        public bool CanViewLeaveRequests { get; set; }
        public bool CanApproveTimesheets { get; set; }
        public bool CanApproveExpenses { get; set; }
        public bool CanViewExpenses { get; set; }
        public bool CanViewShiftCosts { get; set; }
        public bool TimesheetsRequireWorkType { get; set; }
        public bool TimesheetsRequireLocation { get; set; }
        public bool AllowEmployeeTimesheetsWithoutStartStopTimes { get; set; }
        public bool CanCreateTimesheets { get; set; }
        public bool CanCreateAndApproveTimesheets { get; set; }
        public bool NoTimesheetPermissions { get; set; }
        public bool CanViewRosterShifts { get; set; }
        public bool CanManageRosterShifts { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingStatusEnum? BillingStatus { get; set; }
        public bool PaidBreaksEnabled { get; set; }
        public IList<LocationPermissionModel> LocationPermissions { get; set; }
        public IList<EmployeeGroupPermissionModel> EmployeeGroupPermissions { get; set; }
        public bool TimesheetDimensionsEnabled { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string RegistrationNumber { get; set; }
        public bool RegistrationNumberValidationBypassed { get; set; }
        public string LegalName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFaxNumber { get; set; }
        public string ExternalId { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public string JournalService { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek EndOfWeek { get; set; }
        public int? InitialFinancialYearStart { get; set; }
        public bool? ManagersCanEditRosterBudgets { get; set; }
        public decimal? BudgetWarningPercent { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BudgetEntryMethodEnum BudgetEntryMethod { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string WhiteLabelName { get; set; }
        public string PromoCode { get; set; }
        public DateTime DateCreated { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        public string City { get; set; }
        public DateTime? AutoEnrolmentStagingDate { get; set; }
    }
}
