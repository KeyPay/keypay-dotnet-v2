using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SgApiPaySlipModel
    {
        public string EmployeeNricNumber { get; set; }
        public string Uen { get; set; }
        public IList<ApiPaySlipCpfAdjustmentModel> CpfAdjustments { get; set; }
        public IList<ApiPaySlipTaxAdjustmentModel> ForeignTaxAdjustments { get; set; }
        public IList<SgApiPaySlipBankPaymentModel> BankPayments { get; set; }
        public decimal WithholdingTaxAmountYtd { get; set; }
        public decimal ClearanceTaxAmountYtd { get; set; }
        public decimal CpfEmployeeContributionYtd { get; set; }
        public decimal CpfEmployerContributionYtd { get; set; }
        public decimal SdlContributionYtd { get; set; }
        public decimal EmployerVoluntaryCpfYtd { get; set; }
        public decimal EmployerVoluntaryMediSaveYtd { get; set; }
        public string EmployeePostalAddressType { get; set; }
        public string EmployeePostalBlockNumber { get; set; }
        public string EmployeePostalUnitNumber { get; set; }
        public string EmployeePostalLevelNumber { get; set; }
        public string EmployeePostalStreetName { get; set; }
        public string EmployeePostalAddressLine3 { get; set; }
        public string EmployeePostalSuburbName { get; set; }
        public string EmployeePostalSuburbPostcode { get; set; }
        public string EmployeePostalSuburbState { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public RateUnitEnum EmployeeBaseRateUnit { get; set; }
    }
}
