using System.Collections.Generic;
using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class LeaveAllowanceFunction : BaseFunction
    {
        public LeaveAllowanceFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public Dictionary<string, List<LeaveAllowanceModel>> List(int businessId, int employeeId)
        {
            return ApiRequest<Dictionary<string, List<LeaveAllowanceModel>>>("/business/" + businessId + "/employee/" + employeeId + "/leaveallowances");
        }

        public void Update(int businessId,int employeeId,  SubmitEmployeeLeaveAllowancesRequest leaveAllowances)
        {
            ApiRequest<object, SubmitEmployeeLeaveAllowancesRequest>("/business/" + businessId + "/employee/" + employeeId + "/leaveallowances", leaveAllowances, Method.POST);
        }
    }
}