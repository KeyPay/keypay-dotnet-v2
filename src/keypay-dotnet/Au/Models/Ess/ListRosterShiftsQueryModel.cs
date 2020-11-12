using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class ListRosterShiftsQueryModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
