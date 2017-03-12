using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Employee
{
    public class SubmitEmployeeLeaveAllowancesRequest
    {
        public SubmitEmployeeLeaveAllowancesRequest()
        {
            EmployeeIdType = "Standard";
            LeaveCategoryIdType = "Standard";
        }
        public string EmployeeIdType { get; set; }
        public string LeaveCategoryIdType { get; set; }
        public Dictionary<string, List<LeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}