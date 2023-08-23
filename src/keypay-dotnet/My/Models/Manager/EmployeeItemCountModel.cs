using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class EmployeeItemCountModel
    {
        public int EmployeeId { get; set; }
        public int ItemCount { get; set; }
    }
}
