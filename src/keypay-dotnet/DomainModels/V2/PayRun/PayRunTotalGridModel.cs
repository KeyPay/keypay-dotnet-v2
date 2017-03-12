using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunTotalGridModel
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
        public decimal TaxableEarnings { get; set; }
        public decimal SalarySacrificedAmounts { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public decimal GrossPlusSuper { get { return GrossEarnings + SuperContribution; } }
        public int EmployeeId { get; set; }
        public List<PayRunPayCategorySelectModel> PayCategoryList { get; set; }
        public List<LocationEditModel> Locations { get; set; }
        public bool IsTermination { get; set; }
        public List<LeaveCategoryGridModel> LeaveCategories { get; set; }
        public List<SalarySacrificeCategoryGridModel> SalarySacrificeCategories { get; set; }
        public List<DeductionCategoryGridModel> DeductionCategories { get; set; }
        public string Notation { get; set; }
        public DateTime? EmployeeStartDate { get; set; }
        public string EmployeeExternalReferenceId { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}