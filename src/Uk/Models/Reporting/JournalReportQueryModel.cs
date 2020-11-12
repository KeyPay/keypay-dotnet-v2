using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class JournalReportQueryModel
    {
        public int PayRunId { get; set; }
        public JournalView JournalView { get; set; }
        public ExternalService JournalService { get; set; }
    }
}
