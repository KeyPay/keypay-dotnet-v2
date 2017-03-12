using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployeeGroupFunction : BaseFunction
    {
        public EmployeeGroupFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<EmployeeGroupModel> List(int businessId)
        {
            return ApiRequest<List<EmployeeGroupModel>>("/business/" + businessId + "/employeegroup");
        }
    }
}