using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Business
{
    public class SgBusinessExportModel
    {
        public string Uen { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string CountryId { get; set; }
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }
        public string LevelNumber { get; set; }
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
        public DayOfWeek EndOfWeek { get; set; }
        public int? InitialFinancialYearStart { get; set; }
        public bool? ManagersCanEditRosterBudgets { get; set; }
        public decimal? BudgetWarningPercent { get; set; }
        public BudgetEntryMethodEnum BudgetEntryMethod { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostCode { get; set; }
        public string WhiteLabelName { get; set; }
        public string PromoCode { get; set; }
        public DateTime DateCreated { get; set; }
        public LeaveAccrualStartDateType LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        public ExternalService? Source { get; set; }
    }
}
