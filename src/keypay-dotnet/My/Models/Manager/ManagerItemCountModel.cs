using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class ManagerItemCountModel
    {
        public int ItemCount { get; set; }
        public IList<EmployeeItemCountModel> ItemCountByEmployeeId { get; set; }
    }
}
