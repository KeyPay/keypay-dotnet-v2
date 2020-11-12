using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
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
        public bool HasPostGradLoan { get; set; }
        public StudentLoanType StudentLoanType { get; set; }
        public TaxCalculationMethodEnum TaxCalculationMethod { get; set; }
        public NationalInsuranceCalculationMethodEnum NationalInsuranceCalculationMethod { get; set; }
        public bool IsCompanyDirector { get; set; }
        public DateTime? AppointmentStartDate { get; set; }
        public DateTime? AppointmentEndDate { get; set; }
        public bool HasBenefitsInKind { get; set; }
        public decimal BenefitsInKind { get; set; }
        public DateTime? DateSigned { get; set; }
        public DateTime StartDate { get; set; }
        public NationalInsuranceType NationalInsuranceCategory { get; set; }
        public bool NicCalculationOverrideWarning { get; set; }
        public EmployeeStatementEnum EmployeeStatement { get; set; }
        public EmployeeStarterTypeEnum EmployeeStarterType { get; set; }
    }
}
