using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Timesheets
{
    public class MySubmitTimesheetsResponse
    {
        public IDictionary<string,IList<MyIndividualTimesheetLineModel>> Timesheets { get; set; }
    }
}
