using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class ABAFunction : BaseFunction
    {
        public ABAFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<ABAModel> Get(int businessId)
        {
            return ApiRequest<List<ABAModel>>(string.Format("/business/{0}/ABA", businessId));
        }

        public void Update(int businessId, ABAModel model)
        {
            ApiRequest(string.Format("/business/{0}/ABA", businessId), model, Method.POST);
        }
    }
}