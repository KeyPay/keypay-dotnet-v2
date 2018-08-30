using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class StandardHoursFunction : BaseFunction
    {
        public StandardHoursFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public StandardHoursModel Get(int businessId, int employeeId)
        {
            return ApiRequest<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours");
        }

        public StandardHoursModel Update(int businessId, int employeeId, StandardHoursModel model)
        {
            return ApiRequest<StandardHoursModel, StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.PUT);
        }
    }
}