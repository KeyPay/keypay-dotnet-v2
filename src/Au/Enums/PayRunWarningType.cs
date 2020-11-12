using System;
using System.Collections.Generic;

namespace KeyPayV2.Au.Enums
{
    public enum PayRunWarningType
    {
        PaymentFile,
        MoreLeaveThanAccrued,
        UnpaidEarnings,
        Birthday,
        Anniversary,
        NegativeEarnings,
        PreviouslyTerminated,
        TerminatedWithExpenseReimbursements,
        ExpiredQualification,
        DuplicateEarningsLines,
        TaxCodeMissing,
        Bpay,
        LeaveYearCapReached,
        AutoEnrolmentChanges,
        EmployeePensionContributionRefund,
        PensionSchemeRequiresAuthorization,
        UkTaxCodeUpdate,
        UkTaxCodeUpdateError,
        NINOUnknown,
        ProRataEarnings,
        HmrcLateReasonWarning,
        BelowMinimumWage,
        ExpiredSpecialTaxRate,
        ExpiredStudentLoanRate,
        PendingLeaveRequest,
        LeaveRequestBeyondPayPeriod,
        PrecedingLeaveRequest,
        IncompletePayRunTasks,
        PendingExpenseRequests,
        PayDayFiling,
        PayDayFilingAmendment,
        EmployeeInformation,
        IrdSettings,
        AutoUpdatedNICategory,
        UkStudentLoanUpdate,
        PensionProviderDoesNotAllowOverseasAddress,
        MissingLeaveYearEntitlement,
        LeaveRequestUnitTypeMismatch
    }
}
