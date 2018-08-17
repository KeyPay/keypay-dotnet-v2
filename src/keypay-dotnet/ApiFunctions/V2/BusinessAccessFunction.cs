using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class BusinessAccessFunction : BaseFunction
    {
        public BusinessAccessFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<BusinessAccessModel> List(int businessId)
        {
            var result = ApiRequest<List<BusinessAccessModel>>($"/business/{businessId}/access");
            return result;
        }

        public BusinessAccessModel Get(int businessId, string email)
        {
            return ApiRequest<BusinessAccessModel>($"/business/{businessId}/access/user?email={email}");
        }

        public void Grant(int businessId, CreateBusinessAccessModel model)
        {
            ApiRequest($"/business/{businessId}/access", model, Method.POST);
        }

        public void Revoke(int businessId, string email)
        {
            ApiRequest($"/business/{businessId}/access?email={email}", Method.DELETE);
        }
    }
}