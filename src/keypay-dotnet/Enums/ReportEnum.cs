using System;
using System.ComponentModel;

namespace KeyPay.Enums
{
    [Flags]
    public enum ReportEnum : long
    {
        [Description("Detailed Activity Report")]
        DetailedActivityReport = 1L << 0,

        [Description("Pay Run Comparison Report")]
        PayRunComparisonReport = 1L << 1,

        [Description("Super Contributions")]
        SuperContributionsReport = 1L << 2,

        [Description("Ordinary Time Earnings Report")]
        OrdinaryTimeEarningsReport = 1L << 3,

        [Description("Deductions Report")]
        DeductionsReport = 1L << 4,

        [Description("Payroll Tax")]
        PayrollTaxReport = 1L << 5,

        [Description("PAYG Withholding")]
        PaygReport = 1L << 6,

        [Description("Pay Categories Report")]
        PayCategoriesReport = 1L << 7,

        [Description("Pay Run Audit Report")]
        PayRunAuditReport = 1L << 8,

        [Description("Costing Report")]
        CostingReport = 1L << 9,

        [Description("Timesheets Report")]
        TimesheetReport = 1L << 10,

        [Description("Expense Reimbursements Report")]
        ExpensesReport = 1L << 11,

        [Description("Employee Payment History")]
        PaymentHistoryReport = 1L << 12,

        [Description("Leave Balances")]
        LeaveBalancesReport = 1L << 13,

        [Description("Leave Liability")]
        LeaveLiabilityReport = 1L << 14,

        [Description("Leave History")]
        LeaveHistoryReport = 1L << 15,

        [Description("Employee Birthdays")]
        BirthdayReport = 1L << 16,

        [Description("Employee Details Report")]
        EmployeeDetailsReport = 1L << 17,

        [Description("Unpaid Employees Report")]
        UnpaidEmployeesReport = 1L << 18,

        [Description("Employee Qualifications Report")]
        QualificationsReport = 1L << 19,

        [Description("Employee Satisfaction Report")]
        EmployeeSatisfactionReport = 1L << 20,

        [Description("Attendance Report")]
        AttendanceReport = 1L << 21,

        [Description("Emergency Contact Details")]
        EmergencyContactsReport = 1L << 22,

        [Description("Employer Liabilities Report")]
        EmployerLiabilitiesReport = 1L << 23,

        [Description("Pay Run Variance Report")]
        PayRunVarianceReport = 1L << 24,

        [Description("Employee Details Audit Report")]
        EmployeeDetailsAuditReport = 1L << 25,

        [Description("Gross to Net Report")]
        GrossToNetReport = 1L << 26,

        [Description("Live View")]
        LiveView = 1L << 27,

        [Description("Tasks Report")]
        TasksReport = 1L << 28,

        [Description("Shift Swapping Report")]
        ShiftSwappingReport = 1L << 29,

        [Description("Pension Contributions Report")]
        PensionContributionsReport = 1L << 30,

        [Description("Employer Payment Summary (EPS)")]
        EmployerPaymentSummaryReport = 1L << 31,

        [Description("Pay Run Inclusions Report")]
        PayRunInclusionsReport = 1L << 32,
    }
}