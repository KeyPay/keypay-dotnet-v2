using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Contractor
{
    public class ContractorUnstructuredModel
    {
        public string TaxFileNumber { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string EmployingEntityABN { get; set; }
        public string EmployingEntityId { get; set; }
        public string BankAccount1_BSB { get; set; }
        public string BankAccount2_BSB { get; set; }
        public string BankAccount3_BSB { get; set; }
        public string SuperFund1_ProductCode { get; set; }
        public string SuperFund1_FundName { get; set; }
        public string SuperFund1_MemberNumber { get; set; }
        public decimal? SuperFund1_AllocatedPercentage { get; set; }
        public decimal? SuperFund1_FixedAmount { get; set; }
        public bool? SuperFund1_EmployerNominatedFund { get; set; }
        public string SuperFund2_ProductCode { get; set; }
        public string SuperFund2_FundName { get; set; }
        public string SuperFund2_MemberNumber { get; set; }
        public decimal? SuperFund2_AllocatedPercentage { get; set; }
        public decimal? SuperFund2_FixedAmount { get; set; }
        public bool? SuperFund2_EmployerNominatedFund { get; set; }
        public string SuperFund3_ProductCode { get; set; }
        public string SuperFund3_FundName { get; set; }
        public string SuperFund3_MemberNumber { get; set; }
        public decimal? SuperFund3_AllocatedPercentage { get; set; }
        public decimal? SuperFund3_FixedAmount { get; set; }
        public bool? SuperFund3_EmployerNominatedFund { get; set; }
        public decimal? HoursPerDay { get; set; }
        public bool? PostalAddressIsOverseas { get; set; }
        public bool? ResidentialAddressIsOverseas { get; set; }
        public string TerminationReason { get; set; }
        public string Abn { get; set; }
        public string TradingName { get; set; }
        public string RegisteredForGst { get; set; }
        public decimal? CommissionerInstalmentRate { get; set; }
        public string TaxCalculation { get; set; }
        public string PayrollId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PreferredName { get; set; }
        public DateTime? DateOfBirth { get; set; }
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
        public string MobilePhone { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PaySchedule { get; set; }
        public string PrimaryPayCategory { get; set; }
        public string PrimaryLocation { get; set; }
        public decimal? Rate { get; set; }
        public string RateUnit { get; set; }
        public decimal? HoursPerWeek { get; set; }
        public string AutomaticallyPayEmployee { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeStatusEnum Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string ReportingDimensionValues { get; set; }
    }
}
