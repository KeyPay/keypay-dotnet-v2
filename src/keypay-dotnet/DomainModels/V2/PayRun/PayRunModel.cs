using System;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunModel
    {
        public int Id { get; set; }
        public DateTime? DateFinalised { get; set; }
        public int PayScheduleId { get; set; }
        public DateTime PayPeriodStarting { get; set; }
        public DateTime PayPeriodEnding { get; set; }
        public DateTime DatePaid { get; set; }
        public bool IsFinalised { get; set; }
        /// <summary>
        /// Options are:
        /// None
        /// ThisPayPeriod
        /// AllOutstanding
        /// </summary>
        public string TimesheetImportOption { get; set; }
        public bool PaySlipsPublished { get; set; }
        public string Notation { get; set; }
        public string ExternalId { get; set; }
    }
}