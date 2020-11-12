using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class JournalExportResult
    {
        public JournalExportStatus Status { get; set; }
        public string Message { get; set; }
        public ExternalService JournalSource { get; set; }
        public string JournalExternalReferenceId { get; set; }
    }
}
