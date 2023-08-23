using System;
using System.Collections.Generic;

namespace KeyPayV2.Au.Enums
{
    public enum SuperInterchangeStatus
    {
        New,
        SubmittedForProcessing,
        SubmissionFailed,
        SubmissionProcessed,
        SubmissionQueuedForPayment,
        SubmissionPaid,
        AwaitingPayment,
        AwaitingClearance,
        Reconciled,
        SentToFund,
        SentToFundWithResponse,
        SentToFundWithRefund,
        Cancelled,
        Submitted,
        Refunded,
        Cancelling,
        Paid,
        PaymentFailed
    }
}
