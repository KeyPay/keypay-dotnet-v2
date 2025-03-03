using System;
using System.Collections.Generic;

namespace KeyPayV2.Nz.Enums
{
    public enum JournalExportStatus
    {
        NotExported,
        Success,
        FailureUnknownError,
        FailureAccountsNotConfigured,
        FailureItemsDeleted,
        FailureAccountPeriodClosed,
        FailureNotAuthenticated,
        FailureAlreadyExported,
        FailureFunctionDisabled,
        FailureCannotUseAccountsPayableAccount,
        FailureVendorMessage,
        FailureIntercompanyLoanAccountsNotConfigured,
        FailureGSTSetup,
        FailureKnownError,
        FailuresTenantNotSupplied,
        FailureNoJournalId,
        FailureAPIError,
        FailureMissingTaxInfo,
        FailureRecordingJournalReference,
        FailureNoProviderFound,
        FailureUsingManuallyEnteredDimension,
        ResultUnknown
    }
}
