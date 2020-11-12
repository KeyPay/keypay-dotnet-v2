using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkApiPaySlipModel
    {
        public IList<ApiPaySlipPaygAdjustmentModel> PayeAdjustments { get; set; }
        public IList<UkApiPaySlipBankPaymentModel> BankPayments { get; set; }
        public decimal PayeWithholdingAmount { get; set; }
        public string EmployeePostalAddressCity { get; set; }
        public string EmployeePostalAddressPostcode { get; set; }
        public string EmployeePostalAddressCounty { get; set; }
        public decimal EmployeeNationalInsuranceYTD { get; set; }
        public decimal EmployerNationalInsuranceYTD { get; set; }
        public decimal EmployeePensionYTD { get; set; }
        public decimal EmployerPensionYTD { get; set; }
        public string Crn { get; set; }
        public decimal PayeYTD { get; set; }
        public IList<ApiPaySlipLeaveModel> TotalAccruedLeave { get; set; }
        public IList<ApiPaySlipLeaveModel> AccruedLeave { get; set; }
        public IList<ApiPaySlipLeaveModel> LeaveTaken { get; set; }
        public IList<ApiPaySlipEarningsLineModel> EarningsLines { get; set; }
        public IList<ApiPaySlipDeductionModel> Deductions { get; set; }
        public IList<ApiYearToDateEarningsBreakdownModel> GrossYTDDetails { get; set; }
        public IList<ApiEmployeeExpenseGridModel> EmployeeExpenses { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string ContactName { get; set; }
        public string PayPeriodStarting { get; set; }
        public string PayPeriodEnding { get; set; }
        public string Message { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeePostalStreetAddress { get; set; }
        public string EmployeePostalAddressLine2 { get; set; }
        public string EmployeePostalAddressCountry { get; set; }
        public string Notation { get; set; }
        public bool IsPublished { get; set; }
        public decimal GrossYTD { get; set; }
        public decimal NetYTD { get; set; }
        public decimal WithholdingYTD { get; set; }
        public string BasePayRate { get; set; }
        public string BaseRate { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal PreTaxDeductionsYTD { get; set; }
        public decimal PostTaxDeductionsYTD { get; set; }
        public decimal EmployeeBaseRate { get; set; }
        public RateUnitEnum EmployeeBaseRateUnit { get; set; }
    }
}
