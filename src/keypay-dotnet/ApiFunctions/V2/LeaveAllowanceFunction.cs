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

        public Dictionary<string, List<LeaveAllowanceModel>> List(int businessId)
        {
            return ApiRequest<Dictionary<string, List<LeaveAllowanceModel>>>("/business/" + businessId + "/leaveallowances");
        }

        public void Update(int businessId, SubmitEmployeeLeaveAllowancesRequest leaveAllowances)
        {
            ApiRequest<object, SubmitEmployeeLeaveAllowancesRequest>("/business/" + businessId + "/leaveallowances", leaveAllowances, Method.PUT);
        }
    }
}