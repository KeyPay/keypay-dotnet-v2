using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class SuperContributionReportAsExcelQueryModel
    {
        public SuperContributionsReportExportTypeEnum SuperContributionsReportExportType { get; set; }
        public DateTypeEnum FilterType { get; set; }
        public int? SuperBatchId { get; set; }
        public int? EmployeeId { get; set; }
        public SuperContributionType? ContributionType { get; set; }
        public ContributionsServiceType GroupBy { get; set; }
        public bool FundPerPage { get; set; }
        public int PayScheduleId { get; set; }
        public bool IncludePostTaxDeductions { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
