using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class ListEmployeesQueryModel
    {
        public int? PayScheduleId { get; set; }
        public int? LocationId { get; set; }
    }
}
