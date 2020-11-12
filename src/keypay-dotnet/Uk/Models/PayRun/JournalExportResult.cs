using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class JournalExportResult
    {
        public JournalExportStatus Status { get; set; }
        public string Message { get; set; }
        public IList<String> Items { get; set; }
    }
}
