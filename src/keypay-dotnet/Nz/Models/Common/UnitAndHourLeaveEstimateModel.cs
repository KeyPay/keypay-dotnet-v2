using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Common
{
    public class UnitAndHourLeaveEstimateModel
    {
        public decimal? Hours { get; set; }
        public decimal? Units { get; set; }
        public int EmployeeId { get; set; }
        public IList<String> Details { get; set; }
    }
}
