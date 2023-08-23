using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class ListEmployeesQueryModel
    {
        public int? PayScheduleId { get; set; }
        public int? LocationId { get; set; }
    }
}
