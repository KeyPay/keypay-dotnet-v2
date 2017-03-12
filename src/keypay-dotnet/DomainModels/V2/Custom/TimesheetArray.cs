using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Custom
{
    public class TimesheetArray
    {
        public int Id { get; set; }
        public int Employee { get; set; }
        public int EmployeeHistory { get; set; }
        public int EmployeeAgreement { get; set; }
        public string Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string Mealbreak { get; set; }
        //public string MealbreakSlots { get; set; }
        public decimal TotalTime { get; set; }
        public decimal TotalTimeInv { get; set; }
        public decimal Cost { get; set; }
        public int? Roster { get; set; }
        public string EmployeeComment { get; set; }
        public string SupervisorComment { get; set; }
        public string Supervisor { get; set; }
        public bool Disputed { get; set; }
        public bool TimeApproved { get; set; }
        public int TimeApprover { get; set; }
        public bool? Discarded { get; set; }
        public int ValidationFlag { get; set; }
        public int? OperationalUnit { get; set; }
        public bool? IsInProgress { get; set; }
        public bool IsLeave { get; set; }
        public int? LeaveId { get; set; }
        public int? LeaveRule { get; set; }
        public bool Invoiced { get; set; }
        public string InvoiceComment { get; set; }
        public bool PayRuleApproved { get; set; }
        public bool? Exported { get; set; }
        public int? StagingId { get; set; }
        public bool PayStaged { get; set; }
        public int PaycycleId { get; set; }
        public string File { get; set; }
        public int Creator { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string StartTimeLocalized { get; set; }
        public string EndTimeLocalized { get; set; }
        public List<TimesheetPayReturnArray> TimesheetPayReturnArray { get; set; }
    }
}