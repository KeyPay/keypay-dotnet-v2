using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class P45PdfReportQueryModel
    {
        public int? PayRunId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? PayScheduleId { get; set; }
        public int? LocationId { get; set; }
        public IList<Int32> EmployeeIds { get; set; }
    }
}
