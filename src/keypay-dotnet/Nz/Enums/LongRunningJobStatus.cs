using System;
using System.Collections.Generic;

namespace KeyPayV2.Nz.Enums
{
    public enum LongRunningJobStatus
    {
        Queued,
        Running,
        Complete,
        Failed,
        Cancelled
    }
}
