using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PaySlip
{
    public class PaySlipModel
    {
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string ABN { get; set; }
        public string PayPeriodStarting { get; set; }
        public string PayPeriodEnding { get; set; }
        public string Message { get; set; }
        public string Notation { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePostalStreetAddress { get; set; }
        public string EmployeePostalSuburbName { get; set; }
        public string EmployeePostalSuburbPostcode { get; set; }
        public string EmployeePostalSuburbState { get; set; }
        public bool IsPublished { get; set; }

        public List<PaySlipLeaveModel> TotalAccruedLeave { get; set; }
        public List<PaySlipLeaveModel> AccruedLeave { get; set; }
        public List<PaySlipLeaveModel> LeaveTaken { get; set; }
        public List<PaySlipPaygAdjustmentModel> PaygAdjustments { get; set; }
        public List<PaySlipSuperAdjustmentModel> SuperAdjustments { get; set; }
        public List<PaySlipEarningsLineModel> EarningsLines { get; set; }
        public List<PaySlipDeductionModel> Deductions { get; set; }
        public List<PaySlipExpenseModel> EmployeeExpenses { get; set; }
        public List<PaySlipSuperPaymentModel> SuperPayments { get; set; }
        public List<PaySlipBankPaymentModel> BankPayments { get; set; }
        public List<PaySlipYearToDateEarningsBreakdownModel> GrossYTDDetails { get; set; } 
    
        public decimal GrossYTD { get; set; }
        
        public decimal NetYTD { get; set; }
        
        public decimal PaygYTD { get; set; }
        
        public decimal SuperYTD { get; set; }
        
        public decimal TaxableEarningsYTD { get; set; }

        public string BaseRate { get; set; }
        
        public decimal HourlyRate { get; set; }
        
        public decimal PreTaxDeductionsYTD { get; set; }
        
        public decimal PostTaxDeductionsYTD { get; set; }
        
        public decimal SfssYTD { get; set; }
        
        public decimal HelpYTD { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal PaygWithholdingAmount { get; set; }
        public decimal SfssAmount { get; set; }
        public decimal HelpAmount { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal SuperContribution { get; set; }
    }
}