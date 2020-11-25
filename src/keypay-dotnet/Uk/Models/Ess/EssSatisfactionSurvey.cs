using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Ess
{
    public class EssSatisfactionSurvey
    {
        public EmployeeSatisfactionValue Value { get; set; }
        public DateTime WeekStartDate { get; set; }
    }
}
