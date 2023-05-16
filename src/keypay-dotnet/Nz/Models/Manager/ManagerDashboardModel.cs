using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class ManagerDashboardModel
    {
        public ManagerItemCountModel PendingLeaveRequests { get; set; }
        public ManagerItemCountModel SubmittedTimesheets { get; set; }
        public ManagerItemCountModel PendingExpenseRequests { get; set; }
    }
}
