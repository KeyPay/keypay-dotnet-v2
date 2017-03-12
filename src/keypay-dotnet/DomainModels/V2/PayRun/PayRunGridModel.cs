using System;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunGridModel
    {
        public string PayCycleName { get; set; }
        public string BusinessName { get; set; }
        public int BusinessId { get; set; }
        public string PayPeriodEnding { get; set; }
        public DateTime PayPeriodEndingDate { get; set; }
        public string PayCycleId { get; set; }
        public int Id { get; set; }
        public bool IsFinalised { get; set; }
        public string FinalisedBy { get; set; }
        public string Message { get; set; }
        public bool SaasuEnabled { get; set; }
        public bool ABAEnabled { get; set; }
        public DateTime? DateFinalised { get; set; }
        public DateTime? NotificationDate { get; set; }
        public DateTime? DatePaid { get; set; }

        public string DatePaidDisplayValue { get { return DatePaid.HasValue ? DatePaid.Value.ToString("dd/MM/yyyy") : ""; } }

        public string NotificationText
        {
            get { return NotificationDate.HasValue ? "Notifications were sent on " + NotificationDate.Value.ToString("dd/MM/yyyy") : "Notifications have not been sent"; }
        }

        public bool NotificationsSent { get { return NotificationDate.HasValue; } }

        public bool HasNotifications
        {
            get { return !string.IsNullOrEmpty(NotificationText); }
        }

        public int TotalEmployees { get; set; }

        public decimal TotalPaid { get; set; }

        public string ConvertedTotalPaid { get { return TotalPaid == 0 ? "0.00" : TotalPaid.ToString("#.##"); } }
        public string ExternalReferenceId { get; set; }
        public bool ExternalImportComplete { get; set; }
        public bool DeputyEnabled { get; set; }
    }
}