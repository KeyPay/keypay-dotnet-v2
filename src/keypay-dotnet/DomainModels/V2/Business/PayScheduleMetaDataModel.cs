using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class PayScheduleMetaDataModel
    {
        public List<PayRunWarningModel> PayRunWarnings { get; set; }
        public List<string> Frequencies { get; set; }
        public List<string> EmploymentSelectionStrategies { get; set; }
        public List<string> TimesheetImportOptions { get; set; }
        public List<string> PublishPaySlipsPreferences { get; set; }
        public List<ReportPackModel> ReportPacks { get; set; }
        public List<string> UsersToNotify { get; set; }
    }
}