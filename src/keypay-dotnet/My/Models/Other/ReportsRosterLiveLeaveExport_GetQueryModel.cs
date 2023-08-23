using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class ReportsRosterLiveLeaveExport_GetQueryModel
    {
        public Int32[] PayScheduleIds { get; set; }
        public DateTime? AsAtDate { get; set; }
    }
}
