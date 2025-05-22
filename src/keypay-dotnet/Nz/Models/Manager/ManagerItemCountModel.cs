using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class ManagerItemCountModel
    {
        public int ItemCount { get; set; }
        public IList<EmployeeItemCountModel> ItemCountByEmployeeId { get; set; }
    }
}
