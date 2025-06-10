using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class MyBusinessExportModel
    {
        public string Crn { get; set; }
        public bool RegistrationNumberValidationBypassed { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string CountryId { get; set; }
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }
        public string LevelNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAnniversarySetting? LeaveAnniversarySetting { get; set; }
        public DateTime? LeaveAnniversarySettingDate { get; set; }
        public int StandardDaysPerWeek { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormulaForCalculatingOrdinaryRateOfPayEnum FormulaForCalculatingOrdinaryRateOfPay { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
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
        public string PostCode { get; set; }
        public string WhiteLabelName { get; set; }
        public int? WhiteLabelId { get; set; }
        public string PromoCode { get; set; }
        public DateTime DateCreated { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService? Source { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NumberOfEmployeesRangeEnum? NumberOfEmployees { get; set; }
        public string IndustryName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCycleFrequencyEnum? PayCycleFrequency { get; set; }
    }
}
