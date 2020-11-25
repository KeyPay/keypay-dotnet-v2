using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Employee
{
    public class SgUnstructuredEmployeeModel
    {
        public decimal? HoursPerDay { get; set; }
        public AddressTypeEnum ResidentialAddressType { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialBlockNumber { get; set; }
        public string ResidentialUnitNumber { get; set; }
        public string ResidentialLevelNumber { get; set; }
        public AddressTypeEnum? PostalAddressType { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalBlockNumber { get; set; }
        public string PostalUnitNumber { get; set; }
        public string PostalLevelNumber { get; set; }
        public string BankAccount1_BankSwift { get; set; }
        public string BankAccount1_BranchCode { get; set; }
        public string BankAccount2_BankSwift { get; set; }
        public string BankAccount2_BranchCode { get; set; }
        public string BankAccount3_BankSwift { get; set; }
        public string BankAccount3_BranchCode { get; set; }
        public string NationalRegistrationIdentityNumber { get; set; }
        public string Ethnicity { get; set; }
        public string Religion { get; set; }
        public string LegalStatus { get; set; }
        public string EmployeeGroup { get; set; }
        public string Nationality { get; set; }
        public string CoveredByEmploymentAct { get; set; }
        public DateTime? ObtainedResidencyDate { get; set; }
        public DateTime? NationalRegistrationIdentityExpiryDate { get; set; }
        public bool? ApplyFullCpfRate { get; set; }
        public bool? SdlExempt { get; set; }
        public bool? CpfExempt { get; set; }
        public string EmployingEntityUen { get; set; }
        public string EmployingEntityId { get; set; }
        public string ResidentialStreetName { get; set; }
        public string ResidentialAddressLine3 { get; set; }
        public string PostalStreetName { get; set; }
        public string PostalAddressLine3 { get; set; }
        public string TieredLeaveTemplate { get; set; }
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
        public string EmploymentType { get; set; }
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
        public LeaveAccrualStartDateType? LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        public EmployeeStatusEnum Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
