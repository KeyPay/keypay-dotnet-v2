using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class AuUnstructuredEmployeeModel
    {
        public string TaxFileNumber { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string EmployingEntityABN { get; set; }
        public string EmployingEntityId { get; set; }
        public string PreviousSurname { get; set; }
        public bool? AustralianResident { get; set; }
        public bool? ClaimTaxFreeThreshold { get; set; }
        public bool? SeniorsTaxOffset { get; set; }
        public bool? OtherTaxOffset { get; set; }
        public bool? StslDebt { get; set; }
        public bool? IsExemptFromFloodLevy { get; set; }
        public bool? HasApprovedWorkingHolidayVisa { get; set; }
        public string WorkingHolidayVisaCountry { get; set; }
        public DateTime? WorkingHolidayVisaStartDate { get; set; }
        public bool? IsSeasonalWorker { get; set; }
        public bool? HasWithholdingVariation { get; set; }
        public decimal? TaxVariation { get; set; }
        public DateTime? DateTaxFileDeclarationSigned { get; set; }
        public DateTime? DateTaxFileDeclarationReported { get; set; }
        public string BusinessAwardPackage { get; set; }
        public string EmploymentAgreement { get; set; }
        public bool? IsExemptFromPayrollTax { get; set; }
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
        public decimal? SuperThresholdAmount { get; set; }
        public decimal? MaximumQuarterlySuperContributionsBase { get; set; }
        public string MedicareLevyExemption { get; set; }
        public bool? CloselyHeldEmployee { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CloselyHeldReportingEnum? CloselyHeldReporting { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StpIncomeTypeEnum? SingleTouchPayroll { get; set; }
        public decimal? HoursPerDay { get; set; }
        public bool? PostalAddressIsOverseas { get; set; }
        public bool? ResidentialAddressIsOverseas { get; set; }
        public string EmploymentType { get; set; }
        public string ContractorABN { get; set; }
        public string TerminationReason { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxFileDeclarationTaxCategoryCombination? TaxCategory { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MedicareLevySurchargeWithholdingTier? MedicareLevySurchargeWithholdingTier { get; set; }
        public bool? ClaimMedicareLevyReduction { get; set; }
        public bool? MedicareLevyReductionSpouse { get; set; }
        public int? MedicareLevyReductionDependentCount { get; set; }
        public string DvlPaySlipDescription { get; set; }
        public string PortableLongServiceLeaveId { get; set; }
        public bool? IncludeInPortableLongServiceLeaveReport { get; set; }
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
        public string ReportingDimensionValues { get; set; }
    }
}
