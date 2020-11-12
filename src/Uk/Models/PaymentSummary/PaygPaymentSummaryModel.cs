using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaymentSummary
{
    public class PaygPaymentSummaryModel
    {
        public int EmployeeId { get; set; }
        public int? EmployingEntityId { get; set; }
        public DateTime DateGenerated { get; set; }
        public PaygPaymentSummaryTypeEnum PaymentSummaryType { get; set; }
        public PaygPaymentSummaryStatus Status { get; set; }
        public string EtpCode { get; set; }
        public bool IsAmended { get; set; }
        public string PayeeName { get; set; }
        public string PayeeAddress { get; set; }
        public string PayeeAddressLine2 { get; set; }
        public string PayeeSuburb { get; set; }
        public string PayeePostCode { get; set; }
        public string PayeeState { get; set; }
        public string PayeeCountry { get; set; }
        public DateTime PaymentPeriodStart { get; set; }
        public DateTime PaymentPeriodEnd { get; set; }
        public DateTime FinancialYearStart { get; set; }
        public DateTime FinancialYearEnd { get; set; }
        public string PayeeTaxFileNumber { get; set; }
        public int TotalTaxWithheld { get; set; }
        public int GrossPayments { get; set; }
        public int CdepPayments { get; set; }
        public int FringeBenefits { get; set; }
        public bool? IsExemptFromFringeBenefitsTax { get; set; }
        public int EmployerSuperContributions { get; set; }
        public int TotalAllowances { get; set; }
        public int LumpSumA { get; set; }
        public int LumpSumB { get; set; }
        public int LumpSumD { get; set; }
        public int LumpSumE { get; set; }
        public string LumpSumAType { get; set; }
        public int NotReportedAmount { get; set; }
        public Dictionary<String,Int32> Allowances { get; set; }
        public Dictionary<String,Int32> UnionFeeDeductions { get; set; }
        public int WorkplaceGiving { get; set; }
        public int ExemptForeignEmploymentIncome { get; set; }
        public int DeductibleAmountOfUndeductedAnnuityPrice { get; set; }
        public IList<OtherAmounts> OtherAmounts { get; set; }
        public string PayerABN { get; set; }
        public string PayerName { get; set; }
        public string PayerBranch { get; set; }
        public string PayerSignatory { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsTransitionalTerminationPayment { get; set; }
        public bool IsPartOfEarlierPayment { get; set; }
        public int TaxableComponent { get; set; }
        public int TaxFreeComponent { get; set; }
        public string PayeeABN { get; set; }
        public string PaymentType { get; set; }
        public string GrossPaymentType { get; set; }
        public int ForeignTaxPaid { get; set; }
        public int TaxableComponentTaxedElement { get; set; }
        public int TaxableComponentUntaxedElement { get; set; }
        public int TaxableComponentTaxFreeComponent { get; set; }
        public int TaxableComponentTaxOffsetAmount { get; set; }
        public int LumpSumInArrearsTaxedElement { get; set; }
        public int LumpSumInArrearsUntaxedElement { get; set; }
        public int LumpSumInArrearsTaxFreeComponent { get; set; }
        public bool IsDeathBenefit { get; set; }
        public string DeathBenefitType { get; set; }
        public decimal? InputGrossEarnings { get; set; }
        public decimal? InputPreTaxDeductionAmount { get; set; }
        public decimal TotalDeductions { get; set; }
    }
}
