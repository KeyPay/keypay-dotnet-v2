using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class ManagerItemCountModel
    {
        public int ItemCount { get; set; }
        public IList<EmployeeItemCountModel> ItemCountByEmployeeId { get; set; }
    }
}
