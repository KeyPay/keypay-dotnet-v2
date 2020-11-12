using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class PayScheduleMetaDataModel
    {
        public List<PayRunWarningModel> PayRunWarnings { get; set; }
        public List<String> Frequencies { get; set; }
        public List<String> EmploymentSelectionStrategies { get; set; }
        public List<String> TimesheetImportOptions { get; set; }
        public List<String> PublishPaySlipsPreferences { get; set; }
        public List<ReportPackModel> ReportPacks { get; set; }
        public List<String> UsersToNotify { get; set; }
    }
}
