using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class JournalReportQueryModel
    {
        public int PayRunId { get; set; }
        public JournalView JournalView { get; set; }
        public ExternalService JournalService { get; set; }
    }
}
