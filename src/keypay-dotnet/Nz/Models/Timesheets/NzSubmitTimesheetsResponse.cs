using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Timesheets
{
    public class NzSubmitTimesheetsResponse
    {
        public IDictionary<string,IList<NzIndividualTimesheetLineModel>> Timesheets { get; set; }
    }
}
