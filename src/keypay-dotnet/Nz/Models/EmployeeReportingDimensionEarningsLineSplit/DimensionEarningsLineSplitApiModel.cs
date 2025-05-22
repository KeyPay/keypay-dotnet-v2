using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeReportingDimensionEarningsLineSplit
{
    public class DimensionEarningsLineSplitApiModel
    {
        public int Id { get; set; }
        public IList<ReportingDimensionValueBaseApiModel> ReportingDimensionValues { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public bool AllocateBalance { get; set; }
    }
}
