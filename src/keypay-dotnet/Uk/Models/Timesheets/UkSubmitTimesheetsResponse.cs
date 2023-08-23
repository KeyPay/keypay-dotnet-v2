using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Timesheets
{
    public class UkSubmitTimesheetsResponse
    {
        public IDictionary<string,IList<UkIndividualTimesheetLineModel>> Timesheets { get; set; }
    }
}
