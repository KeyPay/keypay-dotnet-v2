using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeReportingDimensionEarningsLineSplit
{
    public class ReducedReportingDimensionValueApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportingDimensionId { get; set; }
    }
}
