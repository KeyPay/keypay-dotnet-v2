using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class PensionContributionDataApiModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string PayrollId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string StreetAddress { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal EmployerContributions { get; set; }
        public decimal EmployeeContributions { get; set; }
        public decimal EmployeeSacrificeContributions { get; set; }
        public decimal NiRebateAmounts { get; set; }
        public decimal NationalInsuranceEligibleEarnings { get; set; }
        public decimal PensionableEarnings { get; set; }
        public decimal Salary { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PensionSalarySacrificePercentage { get; set; }
        public decimal EmployeeContributionPercentage { get; set; }
        public decimal EmployerContributionPercentage { get; set; }
        public string ContributionGroupId { get; set; }
        public string SchemeName { get; set; }
        public string GroupName { get; set; }
        public bool IsAutoEnrolmentScheme { get; set; }
        public DateTime? DatePaid { get; set; }
        public string MobilePhone { get; set; }
        public DateTime? OptOutDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal PensionablePay { get; set; }
        public string HomePhone { get; set; }
        public string NationalInsuranceNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType NationalInsuranceCategory { get; set; }
    }
}
