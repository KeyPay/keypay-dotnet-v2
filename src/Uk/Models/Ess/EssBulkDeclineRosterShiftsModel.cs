using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class EssBulkDeclineRosterShiftsModel
    {
        public string Reason { get; set; }
        public IList<Int32> Shifts { get; set; }
    }
}
