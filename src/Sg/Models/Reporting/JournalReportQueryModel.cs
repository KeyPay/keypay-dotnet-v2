using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class JournalReportQueryModel
    {
        public int PayRunId { get; set; }
        public JournalView JournalView { get; set; }
        public ExternalService JournalService { get; set; }
    }
}
