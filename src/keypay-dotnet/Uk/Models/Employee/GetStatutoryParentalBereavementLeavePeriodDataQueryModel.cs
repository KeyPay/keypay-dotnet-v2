using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class GetStatutoryParentalBereavementLeavePeriodDataQueryModel
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
    }
}
