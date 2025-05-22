using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class EssBulkRosterShiftSwapModel
    {
        public IList<Int32> Shifts { get; set; }
    }
}
