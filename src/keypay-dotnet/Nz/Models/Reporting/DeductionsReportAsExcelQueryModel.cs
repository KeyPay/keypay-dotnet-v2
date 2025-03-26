using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class DeductionsReportAsExcelQueryModel
    {
        public int? PayRunId { get; set; }
        public int? EmployeeId { get; set; }
        public int? PayScheduleId { get; set; }
        public int? LocationId { get; set; }
        public int? DeductionCategoryId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTypeEnum? FilterType { get; set; }
    }
}
