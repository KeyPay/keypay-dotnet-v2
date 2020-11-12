using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class NzUnstructuredEmployeeModel
    {
        public decimal? HoursPerDay { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PreviousSurname { get; set; }
        public string BankAccount1_BankCode { get; set; }
        public string BankAccount2_BankCode { get; set; }
        public string BankAccount3_BankCode { get; set; }
        public int? KiwiSaver_EmployeeContribution { get; set; }
        public int? KiwiSaver_EmployerContribution { get; set; }
        public DateTime? KiwiSaver_OptOutDate { get; set; }
        public DateTime? KiwiSaver_SavingsSuspensionFromDate { get; set; }
        public DateTime? KiwiSaver_SavingsSuspensionToDate { get; set; }
        public string KiwiSaver_EnrollmentStatus { get; set; }
        public string KiwiSaver_IneligibilityReason { get; set; }
        public string TaxCodeDeclaration_IrdNumber { get; set; }
        public bool? TaxCodeDeclaration_NewZealandResident { get; set; }
        public string TaxCodeDeclaration_SpecialTaxCode { get; set; }
        public bool? TaxCodeDeclaration_IsPrimaryIncome { get; set; }
        public bool? TaxCodeDeclaration_MeetsMainIncomeMeansTest { get; set; }
        public bool? TaxCodeDeclaration_IncomeAppliedToTestedBenefit { get; set; }
        public bool? TaxCodeDeclaration_StudentLoan { get; set; }
        public bool? TaxCodeDeclaration_FtcOverseasSuperOrPension { get; set; }
        public DateTime? TaxCodeDeclaration_DateSigned { get; set; }
        public decimal? TaxCodeDeclaration_SpecialTaxCodeRate { get; set; }
        public int? TaxCodeDeclaration_IncomeBand { get; set; }
        public bool? TaxCodeDeclaration_IsNonDisclosed { get; set; }
        public decimal? TaxCodeDeclaration_ElectedExtraPayRate { get; set; }
        public decimal? TaxCodeDeclaration_EsctRate { get; set; }
        public decimal? TaxCodeDeclaration_StudentLoanRate { get; set; }
        public DateTime? TaxCodeDeclaration_SpecialTaxCodeRateEndDate { get; set; }
        public DateTime? TaxCodeDeclaration_StudentLoanRateEndDate { get; set; }
        public string EmployingEntityNZBN { get; set; }
        public bool? TaxCodeDeclaration_IrregularEmployment { get; set; }
        public string EmployingEntityId { get; set; }
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
        public bool? ResidentialAddressIsOverseas { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalPostCode { get; set; }
        public string PostalCountry { get; set; }
        public bool? PostalAddressIsOverseas { get; set; }
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
