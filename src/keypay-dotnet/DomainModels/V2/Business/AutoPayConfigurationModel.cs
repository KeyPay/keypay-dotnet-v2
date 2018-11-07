using System;
using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class AutoPayConfigurationModel
    {
        public bool Enabled { get; set; }
        public bool Paused { get; set; }
        public DateTime InitialPayPeriodEnding { get; set; }
        public DateTime InitialDatePaid { get; set; }
        public DateTime InitialPayRunCreationDateTime { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime NextScheduledCreationDateTimeUtc { get; set; }
        public bool Finalise { get; set; }
        public TimesheetImportOption TimesheetImportOption { get; set; }
        public bool ExportJournals { get; set; }
        public bool LodgePayRun { get; set; }
        public bool SubmitToPensionSync { get; set; }
        public PublishPaySlipsPreference PublishPaySlips { get; set; }
        public int PublishPaySlipsHour { get; set; }
        public bool SuppressNotifications { get; set; }
        public List<string> UsersToNotify { get; set; }
        public bool RunOnSpecificDayOfMonth { get; set; }
        public bool AdjustRunDateToWorkDay { get; set; }
        public bool AdjustDatePaidToWorkDay { get; set; }
        public int SpecificDayOfMonth { get; set; }
        public int WeekOfMonth { get; set; }
        public int DayOfWeek { get; set; }
        public List<int> ReportPacksToRun { get; set; }
    }
}