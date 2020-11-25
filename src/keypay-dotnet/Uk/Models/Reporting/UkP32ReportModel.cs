using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP32ReportModel
    {
        public IList<UkP32ReportPeriod> P32ReportMonths { get; set; }
        public IList<UkP32ReportPeriod> P32ReportQuarters { get; set; }
        public UkP32ReportPeriod P32ReportTotals { get; set; }
    }
}
