using System.Collections.Generic;
using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployeeLeaveAllowanceFunction : BaseFunction
    {
        public EmployeeLeaveAllowanceFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<LeaveAllowanceModel> List(int businessId, int employeeId)
        {
            return ApiRequest<List<LeaveAllowanceModel>>("/business/" + businessId + "/employee/" + employeeId + "/leaveallowances");
        }

        public void Update(int businessId, int employeeId, IList<LeaveAllowanceModel> leaveAllowances)
        {
            ApiRequest<object, IList<LeaveAllowanceModel>>("/business/" + businessId + "/employee/" + employeeId + "/leaveallowances", leaveAllowances, Method.PUT);
        }
    }
}