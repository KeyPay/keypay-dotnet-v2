using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class UkAutoPayConfigurationModel
    {
        public bool? PayOnSpecificDayOfMonth { get; set; }
        public int? SpecificPayDayOfMonth { get; set; }
        public int? PayWeekOfMonth { get; set; }
        public int? PayDayOfWeek { get; set; }
        public bool Enabled { get; set; }
        public bool Paused { get; set; }
        public DateTime InitialPayPeriodEnding { get; set; }
        public DateTime InitialDatePaid { get; set; }
        public DateTime InitialPayRunCreationDateTime { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime NextScheduledCreationDateTimeUtc { get; set; }
        public bool Finalise { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimesheetImportOption TimesheetImportOption { get; set; }
        public bool ExportJournals { get; set; }
        public bool LodgePayRun { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PublishPaySlipsPreference PublishPaySlips { get; set; }
        public int PublishPaySlipsHour { get; set; }
        public bool SuppressNotifications { get; set; }
        public List<String> UsersToNotify { get; set; }
        public bool RunOnSpecificDayOfMonth { get; set; }
        public bool AdjustRunDateToWorkDay { get; set; }
        public bool AdjustDatePaidToWorkDay { get; set; }
        public int SpecificDayOfMonth { get; set; }
        public int WeekOfMonth { get; set; }
        public int DayOfWeek { get; set; }
        public List<Int32> ReportPacksToRun { get; set; }
    }
}
