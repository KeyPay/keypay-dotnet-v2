using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class MyCostingReportApiModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public IDictionary<String,Decimal> PayCategories { get; set; }
    }
}
