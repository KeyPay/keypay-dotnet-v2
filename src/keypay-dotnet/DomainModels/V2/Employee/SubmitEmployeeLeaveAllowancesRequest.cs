using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Employee
{
    public class SubmitEmployeeLeaveAllowancesRequest
    {
        public IdType EmployeeIdType { get; set; }
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string, List<LeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}