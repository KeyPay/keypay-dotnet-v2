using System;
using System.Collections.Generic;

namespace KeyPayV2.Sg.Enums
{
    public enum ShiftAssignmentStatusEnum
    {
        Pending,
        Assigned,
        Bidding,
        PendingShiftSwap,
        PendingShiftSwapAwaitingApproval,
        ProposedShiftSwap,
        ProposedShiftSwapAwaitingApproval
    }
}
