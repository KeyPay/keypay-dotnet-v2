using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class OpeningBalancesFunction : BaseFunction
    {
        public OpeningBalancesFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public OpeningBalancesModel Get(int businessId, int employeeId)
        {
            return ApiRequest<OpeningBalancesModel>("/business/" + businessId + "/employee/" + employeeId + "/OpeningBalances");
        }

        public void Update(int businessId, int employeeId, OpeningBalancesModel model)
        {
            ApiRequest("/business/" + businessId + "/employee/" + employeeId + "/OpeningBalances", model, Method.POST);
        }
    }
}