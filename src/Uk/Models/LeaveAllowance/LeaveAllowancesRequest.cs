using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveAllowance
{
    public class LeaveAllowancesRequest
    {
        public IdType EmployeeIdType { get; set; }
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,List<LeaveAllowanceApiModel>> LeaveAllowances { get; set; }
    }
}
