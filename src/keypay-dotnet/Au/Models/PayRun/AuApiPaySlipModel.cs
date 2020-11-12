using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class AuApiPaySlipModel
    {
        public IList<ApiPaySlipPaygAdjustmentModel> PaygAdjustments { get; set; }
        public IList<ApiPaySlipSuperAdjustmentModel> SuperAdjustments { get; set; }
        public IList<ApiPaySlipSuperPaymentModel> SuperPayments { get; set; }
        public IList<AuApiPaySlipBankPaymentModel> BankPayments { get; set; }
        public decimal PaygWithholdingAmount { get; set; }
        public decimal SfssAmount { get; set; }
        public decimal HelpAmount { get; set; }
        public decimal SuperContribution { get; set; }
        public string EmployeePostalSuburbName { get; set; }
        public string EmployeePostalSuburbPostcode { get; set; }
        public string EmployeePostalSuburbState { get; set; }
        public decimal SuperYTD { get; set; }
        public decimal SfssYTD { get; set; }
        public decimal HelpYTD { get; set; }
        public decimal PaygYTD { get; set; }
        public string Abn { get; set; }
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
