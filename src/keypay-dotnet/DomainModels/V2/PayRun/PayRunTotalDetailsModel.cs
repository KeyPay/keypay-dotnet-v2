using System;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunTotalDetailsModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal PaygWithholdingAmount { get; set; }
        public decimal SfssAmount { get; set; }
        public decimal HelpAmount { get; set; }
        public decimal SuperContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public int EmployeeId { get; set; }
        public bool IsTermination { get; set; }
        public string Notation { get; set; }
        public DateTime? EmployeeStartDate { get; set; }
        public string EmployeeExternalReferenceId { get; set; }
        public string EmployeeExternalId { get; set; }
        public decimal SuperAdjustmentsAmount { get; set; }
        public decimal EmployerContributionAdjustmentsAmount { get; set; }
        public decimal PaygAdjustmentsAmount { get; set; }
        public decimal SalarySacrificeSuperAmount { get; set; }
        public decimal MemberVoluntarySuperAmount { get; set; }
        public decimal NonSuperDeductionTotal { get; set; }
        public decimal SuperPaymentsTotal { get; set; }
        public decimal BankPaymentsTotal { get; set; }
        public DateTime? TerminationDate { get; set; }
        public decimal EmployeeExpensesTotal { get; set; }
        public decimal EmployerLiabilitiesTotal { get; set; }
        public bool SuperContributionsCapApplied { get; set; }
        public bool IsComplete { get; set; }
    }
}