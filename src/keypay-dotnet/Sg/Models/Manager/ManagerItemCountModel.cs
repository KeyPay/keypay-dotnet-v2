using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class ManagerItemCountModel
    {
        public int ItemCount { get; set; }
        public IList<EmployeeItemCountModel> ItemCountByEmployeeId { get; set; }
    }
}
