using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSapApiCalculationResultViewModel
    {
        public SapEligibilityEnum Status { get; set; }
        public IList<StatutoryLeaveLogEvent> Log { get; set; }
        public decimal AverageWeeklyEarnings { get; set; }
        public IDictionary<Decimal,Int32> Rates { get; set; }
        public SapPayment[] Payments { get; set; }
        public SapCalculationTypeEnum CalculationTypeUsed { get; set; }
    }
}
