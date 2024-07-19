using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkUnstructuredEmployeeModel
    {
        public string NationalInsuranceNumber { get; set; }
        public string TaxCode { get; set; }
        public string IsCompanyDirector { get; set; }
        public string EmployeePaidIrregularly { get; set; }
        public bool? ApplyRolledUpHolidayPay { get; set; }
        public decimal? RolledUpHolidayPayPercentage { get; set; }
        public string TaxCalculationMethod { get; set; }
        public string StudentLoanType { get; set; }
        public bool HasPostGradLoan { get; set; }
        public long PglCodingNoticeSequenceNumber { get; set; }
        public long Pgl2CodingNoticeSequenceNumber { get; set; }
        public bool HasStudentLoan { get; set; }
        public long SlCodingNoticeSequenceNumber { get; set; }
        public long Sl2CodingNoticeSequenceNumber { get; set; }
        public string NationalInsuranceCalculationMethod { get; set; }
        public string NationalInsuranceCategory { get; set; }
        public string PreviousEmployerOfficeNumber { get; set; }
        public string PreviousEmployerReferenceNumber { get; set; }
        public decimal? PreviousEmployerTaxablePay { get; set; }
        public decimal? PreviousEmployerTaxWithheld { get; set; }
        public DateTime? PreviousEmployerLeavingDate { get; set; }
        public bool? PreviousEmployerContinueStudentLoanDeductions { get; set; }
        public bool? PreviousEmployerW1M1 { get; set; }
        public string PreviousEmployerTaxPeriodFrequency { get; set; }
        public int? PreviousEmployerTaxPeriodNumber { get; set; }
        public string PreviousEmployerTaxCode { get; set; }
        public long P6CodingNoticeSequenceNumber { get; set; }
        public long P9CodingNoticeSequenceNumber { get; set; }
        public DateTime? AppointmentStartDate { get; set; }
        public DateTime? AppointmentEndDate { get; set; }
        public string EmployeeStarterType { get; set; }
        public string PayrollId { get; set; }
        public string EmployeeStatement { get; set; }
        public string PensionContributionGroup { get; set; }
        public string PensionAssessmentOption { get; set; }
        public string AssessmentStatus { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public DateTime? OptInDate { get; set; }
        public string ResidentialCity { get; set; }
        public string ResidentialCounty { get; set; }
        public string PostalCity { get; set; }
        public string PostalCounty { get; set; }
        public string BankAccount1_SortCode { get; set; }
        public string BankAccount2_SortCode { get; set; }
        public string BankAccount3_SortCode { get; set; }
        public string BankAccount1_RollNumber { get; set; }
        public string BankAccount2_RollNumber { get; set; }
        public string BankAccount3_RollNumber { get; set; }
        public string IsExemptFromMinimumWage { get; set; }
        public string IsApprentice { get; set; }
        public bool IsIR35Contractor { get; set; }
        public bool? IsSecondedEmployee { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SecondmentType? SecondmentType { get; set; }
        public bool? EuropeanEconomicAreaCitizen { get; set; }
        public bool? OccupationalPension { get; set; }
        public bool? PostalAddressIsOverseas { get; set; }
        public bool? ResidentialAddressIsOverseas { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PostponementOptionEnum? PostponementOption { get; set; }
        public DateTime? DeferralDate { get; set; }
        public DateTime? FreeportQualifyingEndDate { get; set; }
        public DateTime? VeteransQualifyingEndDate { get; set; }
        public DateTime? InvestmentQualifyingEndDate { get; set; }
        public bool? ExcludeEarningsFromAppLevy { get; set; }
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
