using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class EmployeeNationalInsuranceRecordModel
    {
        public int NationalInsuranceRecordId { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public string PayrollId { get; set; }
        public string TaxCode { get; set; }
        public bool HasStudentLoan { get; set; }
        public int SlCodingNoticeSequenceNumber { get; set; }
        public bool HasPostGradLoan { get; set; }
        public int PglCodingNoticeSequenceNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StudentLoanType StudentLoanType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxCalculationMethodEnum TaxCalculationMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceCalculationMethodEnum NationalInsuranceCalculationMethod { get; set; }
        public bool IsCompanyDirector { get; set; }
        public DateTime? AppointmentStartDate { get; set; }
        public DateTime? AppointmentEndDate { get; set; }
        public bool HasBenefitsInKind { get; set; }
        public decimal BenefitsInKind { get; set; }
        public DateTime? DateSigned { get; set; }
        public DateTime StartDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType NationalInsuranceCategory { get; set; }
        public bool NicCalculationOverrideWarning { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeStatementEnum EmployeeStatement { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeStarterTypeEnum EmployeeStarterType { get; set; }
        public int P6CodingNoticeSequenceNumber { get; set; }
        public int P9CodingNoticeSequenceNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsApprentice { get; set; }
        public bool? IsIR35Contractor { get; set; }
        public bool? IsSecondedEmployee { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SecondmentType? SecondmentType { get; set; }
        public bool? EuropeanEconomicAreaCitizen { get; set; }
        public bool? OccupationalPension { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService? Source { get; set; }
        public int NotNoticeSequenceNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeTypeEnum? EmployeeType { get; set; }
    }
}
