using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgCostingReportApiModel
    {
        public decimal CpfEmployerContribution { get; set; }
        public decimal VoluntaryEmployerContribution { get; set; }
        public decimal SdlContribution { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public IDictionary<String,Decimal> PayCategories { get; set; }
    }
}
