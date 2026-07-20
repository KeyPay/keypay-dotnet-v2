using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class OspPayPercentByDayModel
    {
        public DateTime Date { get; set; }
        public decimal Days { get; set; }
        public decimal Percent { get; set; }
    }
}
