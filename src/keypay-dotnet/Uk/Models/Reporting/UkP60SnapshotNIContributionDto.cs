using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP60SnapshotNIContributionDto
    {
        public int EmployeeId { get; set; }
        public decimal EarningsAtLel { get; set; }
        public decimal EarningsFromLelToPt { get; set; }
        public decimal EarningsFromPtToUel { get; set; }
        public decimal NicDueOnEarningsAbovePt { get; set; }
        public decimal DirectorsEarningsAtLel { get; set; }
        public decimal DirectorsEarningsFromLelToPt { get; set; }
        public decimal DirectorsEarningsFromPtToUel { get; set; }
        public string NicTable { get; set; }
    }
}
