using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class EmployeeItemCountModel
    {
        public int EmployeeId { get; set; }
        public int ItemCount { get; set; }
    }
}
