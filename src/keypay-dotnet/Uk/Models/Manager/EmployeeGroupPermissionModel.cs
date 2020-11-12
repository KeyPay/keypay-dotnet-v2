using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class EmployeeGroupPermissionModel
    {
        public int Id { get; set; }
        public bool CanApproveLeaveRequests { get; set; }
        public bool CanViewLeaveRequests { get; set; }
        public bool CanApproveTimesheets { get; set; }
        public bool CanCreateTimesheets { get; set; }
        public bool CanApproveExpenses { get; set; }
        public bool CanViewExpenses { get; set; }
        public bool CanViewShiftCosts { get; set; }
    }
}