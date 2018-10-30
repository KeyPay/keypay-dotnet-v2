using System;
using System.ComponentModel;

namespace KeyPay.Enums
{
    [Flags]
    public enum UserPermission : long
    {
        [Description("Approve Timesheets")]
        ApproveTimesheets = 1 << 0, // 1
        [Description("Approve Leave Requests")]
        ApproveLeaveRequests = 1 << 1, // 2
        [Description("Create Timesheets")]
        CreateTimesheets = 1 << 2, // 4
        [Description("Create Leave Requests")]
        CreateLeaveRequests = 1 << 3, // 8
        [Description("View Leave Requests")]
        ViewLeaveRequests = 1 << 4, // 16
        [Description("Manage Employee Rosters")]
        ManageRosters = 1 << 5, // 32
        [Description("View Employee Rosters")]
        ViewRosters = 1 << 6, // 64
        [Description("View Shift Costs")]
        ViewShiftCosts = 1 << 7, // 128
        [Description("View Employee Expenses")]
        ViewExpenses = 1 << 8, // 256
        [Description("Create Employee Expenses")]
        CreateExpenses = 1 << 9, // 512
        [Description("Approve Expenses")]
        ApproveExpenses = 1 << 10, // 1024
        [Description("Create Tasks")]
        CreateTasks = 1 << 11, // 2048
        [Description("View Employee Documents")]
        ViewEmployeeDocuments = 1 << 12, // 4096
        [Description("Manage Employee Documents")]
        ManageEmployeeDocuments = 1 << 13, // 8192
        [Description("View Employee Qualifications")]
        ViewEmployeeQualifications = 1 << 14, // 16384
        [Description("Manage Employee Qualifications")]
        ManageEmployeeQualifications = 1 << 15, // 32768
        [Description("Initiate Self Setup")]
        InitiateEmployeeSelfSetup = 1 << 16, // 65536
        [Description("Add Employee From Kiosk")]
        AddEmployeeFromKiosk = 1 << 17 // 131072
    }
}