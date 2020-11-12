using System;
using System.Collections.Generic;

namespace KeyPayV2.Uk.Enums
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
        FailureKnownError
    }
}
