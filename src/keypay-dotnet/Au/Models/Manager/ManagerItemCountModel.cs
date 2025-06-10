using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class ManagerItemCountModel
    {
        public int ItemCount { get; set; }
        public IList<EmployeeItemCountModel> ItemCountByEmployeeId { get; set; }
    }
}
