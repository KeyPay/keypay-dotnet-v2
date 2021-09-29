using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeEarningsLineSplit
{
    public class EarningsLineSplitEditModel
    {
        public int LocationId { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public bool AllocateBalance { get; set; }
    }
}
