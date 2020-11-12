using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.LeaveAllowance
{
    public class AuLeaveAllowancesRequest
    {
        public IdType EmployeeIdType { get; set; }
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,List<AuLeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}
