using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class MyUnstructuredEmployeeModel
    {
        public decimal? HoursPerDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressTypeEnum ResidentialAddressType { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialBlockNumber { get; set; }
        public string ResidentialUnitNumber { get; set; }
        public string ResidentialLevelNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressTypeEnum? PostalAddressType { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalBlockNumber { get; set; }
        public string PostalUnitNumber { get; set; }
        public string PostalLevelNumber { get; set; }
        public string BankAccount1_BankName { get; set; }
        public string BankAccount1_BankCode { get; set; }
        public string BankAccount1_BranchCode { get; set; }
        public string BankAccount2_BankName { get; set; }
        public string BankAccount2_BankCode { get; set; }
        public string BankAccount2_BranchCode { get; set; }
        public string BankAccount3_BankName { get; set; }
        public string BankAccount3_BankCode { get; set; }
        public string BankAccount3_BranchCode { get; set; }
        public string Ethnicity { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string EmployingEntityId { get; set; }
        public string ResidentialStreetName { get; set; }
        public string ResidentialAddressLine3 { get; set; }
        public string PostalStreetName { get; set; }
        public string PostalAddressLine3 { get; set; }
        public string EmploymentType { get; set; }
        public string TerminationReason { get; set; }
        public string IncomeTaxNumber { get; set; }
        public string IdentityCardNumber { get; set; }
        public string PassportNumber { get; set; }
        public string ResidenceStatus { get; set; }
        public string EpfNumber { get; set; }
        public string EisExempt { get; set; }
        public string SocsoType { get; set; }
        public string SsfwNumber { get; set; }
        public string ResidenceType { get; set; }
        public bool PcbTaxBorne { get; set; }
        public string DependentChildren { get; set; }
        public string EpfContributionType { get; set; }
        public string EpfRate { get; set; }
        public string WorkerStatus { get; set; }
        public string MaritalStatus { get; set; }
        public string PassportIssuingCountry { get; set; }
        public string TieredLeaveTemplate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAnniversarySetting? LeaveAnniversarySetting { get; set; }
        public DateTime? LeaveAnniversarySettingDate { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string PreferredName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ExternalId { get; set; }
        public string ResidentialStreetAddress { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public string ResidentialPostCode { get; set; }
        public string ResidentialCountry { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalPostCode { get; set; }
        public string PostalCountry { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string Tags { get; set; }
        public string JobTitle { get; set; }
        public string PaySchedule { get; set; }
        public string PrimaryPayCategory { get; set; }
        public string PrimaryLocation { get; set; }
        public string PaySlipNotificationType { get; set; }
        public decimal? Rate { get; set; }
        public string OverrideTemplateRate { get; set; }
        public string RateUnit { get; set; }
        public decimal? HoursPerWeek { get; set; }
        public string AutomaticallyPayEmployee { get; set; }
        public string LeaveTemplate { get; set; }
        public string PayRateTemplate { get; set; }
        public string PayConditionRuleSet { get; set; }
        public string IsEnabledForTimesheets { get; set; }
        public string Locations { get; set; }
        public string WorkTypes { get; set; }
        public string EmergencyContact1_Name { get; set; }
        public string EmergencyContact1_Relationship { get; set; }
        public string EmergencyContact1_Address { get; set; }
        public string EmergencyContact1_ContactNumber { get; set; }
        public string EmergencyContact1_AlternateContactNumber { get; set; }
        public string EmergencyContact2_Name { get; set; }
        public string EmergencyContact2_Relationship { get; set; }
        public string EmergencyContact2_Address { get; set; }
        public string EmergencyContact2_ContactNumber { get; set; }
        public string EmergencyContact2_AlternateContactNumber { get; set; }
        public string BankAccount1_AccountNumber { get; set; }
        public string BankAccount1_AccountName { get; set; }
        public decimal? BankAccount1_AllocatedPercentage { get; set; }
        public decimal? BankAccount1_FixedAmount { get; set; }
        public string BankAccount2_AccountNumber { get; set; }
        public string BankAccount2_AccountName { get; set; }
        public decimal? BankAccount2_AllocatedPercentage { get; set; }
        public decimal? BankAccount2_FixedAmount { get; set; }
        public string BankAccount3_AccountNumber { get; set; }
        public string BankAccount3_AccountName { get; set; }
        public decimal? BankAccount3_AllocatedPercentage { get; set; }
        public decimal? BankAccount3_FixedAmount { get; set; }
        public string RosteringNotificationChoices { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType? LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeStatusEnum Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
