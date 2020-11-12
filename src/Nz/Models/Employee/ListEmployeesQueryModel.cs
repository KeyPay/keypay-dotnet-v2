using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class ListEmployeesQueryModel
    {
        public int? PayScheduleId { get; set; }
        public int? LocationId { get; set; }
    }
}
