using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class DeprecatedDetailedActivityReportAsExcelQueryModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public EarningsReportDisplayEnum GroupBy { get; set; }
        public DateTypeEnum FilterType { get; set; }
        public int? PayRunId { get; set; }
        public int? PayScheduleId { get; set; }
        public List<Int32> LocationsIds { get; set; }
        public IList<Int32> EmployeeIds { get; set; }
        public bool IncludePostTaxDeductions { get; set; }
        public bool ShowLocationTotalsOnly { get; set; }
        public bool IncludeEmployeePayRunBreakdown { get; set; }
    }
}
