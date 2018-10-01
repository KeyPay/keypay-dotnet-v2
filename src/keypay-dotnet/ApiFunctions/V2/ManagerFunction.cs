using KeyPay.DomainModels.V2.Business;
using KeyPay.DomainModels.V2.Manager;
using System.Collections.Generic;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerFunction : BaseFunction
    {
        public ManagerFunction(ApiRequestExecutor api) : base(api)
        {
            LeaveRequests = new ManagerLeaveRequestsFunction(api);
        }

        public ManagerLeaveRequestsFunction LeaveRequests { get; set; }

        public List<ManagerLeaveEmployeeModel> Employees(int businessId)
        {
            return ApiRequest<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/employees");
        }

        public List<LocationModel> Locations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/locations");
        }
    }
}