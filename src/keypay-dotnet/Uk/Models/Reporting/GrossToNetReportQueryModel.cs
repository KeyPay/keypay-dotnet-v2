using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class GrossToNetReportQueryModel
    {
        public int EmployeeId { get; set; }
        public List<Int32> PayCategoryIds { get; set; }
        public string GroupBy { get; set; }
        public int? PayRunId { get; set; }
        public DateTypeEnum? FilterType { get; set; }
        public bool? IncludeExpenses { get; set; }
        public int PayScheduleId { get; set; }
        public bool IncludePostTaxDeductions { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
