using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployeeGroupFunction : BaseFunction
    {
        public EmployeeGroupFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<EmployeeGroupModel> List(int businessId)
        {
            return ApiRequest<List<EmployeeGroupModel>>($"/business/{businessId}/employeegroup");
        }

        public EmployeeGroupModel Get(int businessId, int employeeGroupId)
        {
            return ApiRequest<EmployeeGroupModel>($"/business/{businessId}/employeegroup/{employeeGroupId}");
        }

        public EmployeeGroupModel Create(int businessId, CreateEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<EmployeeGroupModel, CreateEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.POST);
        }

        public EmployeeGroupModel Update(int businessId, EmployeeGroupModel employeeGroup)
        {
            ApiRequest<EmployeeGroupModel, EmployeeGroupModel>($"/business/{businessId}/employeegroup/{employeeGroup.Id}", employeeGroup, Method.PUT);
            return Get(businessId, employeeGroup.Id);
        }

        public void Delete(int businessId, int employeeGroupId)
        {
            ApiRequest($"/business/{businessId}/employeegroup/{employeeGroupId}", Method.DELETE);
        }
    }
}