using System;

namespace KeyPay.DomainModels.V2.Custom
{
    public class TimesheetPayReturnArray
    {
        public int Id { get; set; }
        public int Timesheet { get; set; }
        public int PayRule { get; set; }
        public bool Overridden { get; set; }
        public decimal Value { get; set; }
        public decimal Cost { get; set; }
        public string OverrideComment { get; set; }
        public int PayCycleId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}