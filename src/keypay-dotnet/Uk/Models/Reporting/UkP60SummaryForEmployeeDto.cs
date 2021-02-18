using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP60SummaryForEmployeeDto
    {
        public List<UkP60PayRunTotalAggregateDto> PayRunTotals { get; set; }
        public List<UkP60SnapshotNIContributionDto> NiContributions { get; set; }
    }
}
