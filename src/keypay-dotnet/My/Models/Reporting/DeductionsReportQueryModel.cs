using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class DeductionsReportQueryModel
    {
        public int EmployeeId { get; set; }
        public int DeductionCategoryId { get; set; }
        public bool DisableRollupReporting { get; set; }
        public int PayScheduleId { get; set; }
        public bool IncludePostTaxDeductions { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
