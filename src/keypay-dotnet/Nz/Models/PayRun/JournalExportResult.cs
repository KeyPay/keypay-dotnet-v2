using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class JournalExportResult
    {
        public JournalExportStatus Status { get; set; }
        public string Message { get; set; }
        public ExternalService JournalSource { get; set; }
        public string JournalExternalReferenceId { get; set; }
    }
}
