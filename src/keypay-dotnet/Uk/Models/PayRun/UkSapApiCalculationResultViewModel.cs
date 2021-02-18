using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSapApiCalculationResultViewModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SapEligibilityEnum Status { get; set; }
        public IList<StatutoryLeaveLogEvent> Log { get; set; }
        public decimal AverageWeeklyEarnings { get; set; }
        public IDictionary<Decimal,Int32> Rates { get; set; }
        public SapPayment[] Payments { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SapCalculationTypeEnum CalculationTypeUsed { get; set; }
    }
}
