using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class JournalReportQueryModel
    {
        public int PayRunId { get; set; }
        public JournalView JournalView { get; set; }
        public ExternalService JournalService { get; set; }
    }
}
