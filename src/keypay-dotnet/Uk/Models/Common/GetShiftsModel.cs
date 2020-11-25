using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Common
{
    public class GetShiftsModel
    {
        public int? KioskId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? FromDateUtc { get; set; }
        public DateTime? ToDateUtc { get; set; }
    }
}
