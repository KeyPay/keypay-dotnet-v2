using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Report
{
    public class PaygPaymentSummaryModel
    {
        public int EmployeeId { get; set; }
        public int? EmployingEntityId { get; set; }
        public DateTime DateGenerated { get; set; }
        public string PaymentSummaryType { get; set; }
        public string Status { get; set; }

        public bool IsAmended { get; set; }

        public string PayeeName { get; set; }
        public string PayeeAddress { get; set; }
        public string PayeeAddressLine2 { get; set; }
        public string PayeeSuburb { get; set; }
        public string PayeePostCode { get; set; }
        public string PayeeState { get; set; }

        public DateTime PaymentPeriodStart { get; set; }
        public DateTime PaymentPeriodEnd { get; set; }
        public string PayeeTaxFileNumber { get; set; }
        public int TotalTaxWithheld { get; set; }
        public int GrossPayments { get; set; }
        public int CdepPayments { get; set; }
        public int FringeBenefits { get; set; }
        public int EmployerSuperContributions { get; set; }
        public int TotalAllowances { get; set; }
        public int LumpSumA { get; set; }
        public int LumpSumB { get; set; }
        public int LumpSumD { get; set; }
        public int LumpSumE { get; set; }
        public string LumpSumAType { get; set; }
        public int NotReportedAmount { get; set; }

        public Dictionary<string, int> Allowances { get; set; }
        public Dictionary<string, int> UnionFeeDeductions { get; set; }
        public int WorkplaceGiving { get; set; } // Shown on summary as "Workplace Giving DGR(s)"
        public int ExemptForeignEmploymentIncome { get; set; } // Shown on summary as "Exempt foreign employment income"
        public int DeductibleAmountOfUndeductedAnnuityPrice { get; set; } // Shown on summart as "Deductible amount of the undeducted purchase price of the annuity"


        public string PayerABN { get; set; }
        public string PayerName { get; set; }
        public string PayerBranch { get; set; }
        public string PayerSignatory { get; set; }

        //additional information for the employment termination payment summary 
        public DateTime PaymentDate { get; set; }
        public bool IsTransitionalTerminationPayment { get; set; }
        public bool IsPartOfEarlierPayment { get; set; }
        public int TaxableComponent { get; set; }
        public int TaxFreeComponent { get; set; }

        //additional information for the business and personal services income payment summary
        public string PayeeABN { get; set; }
        public string PaymentType { get; set; }

        //additional information for the foreign employment payment summary
        public string GrossPaymentType { get; set; }
        public int ForeignTaxPaid { get; set; }

        //additional information for the superannuation income stream payment summary
        public int TaxableComponentTaxedElement { get; set; }
        public int TaxableComponentUntaxedElement { get; set; }
        public int TaxableComponentTaxFreeComponent { get; set; }
        public int TaxableComponentTaxOffsetAmount { get; set; }

        public int LumpSumInArrearsTaxedElement { get; set; }
        public int LumpSumInArrearsUntaxedElement { get; set; }
        public int LumpSumInArrearsTaxFreeComponent { get; set; }

        //additional information for the superannuation lump sum payment summary 
        public bool IsDeathBenefit { get; set; }
        public string DeathBenefitType { get; set; }
    }
}