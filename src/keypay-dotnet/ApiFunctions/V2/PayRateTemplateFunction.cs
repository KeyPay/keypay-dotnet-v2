using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class PayRateTemplateFunction : BaseFunction
    {
        public PayRateTemplateFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<PayRateTemplateModel> List(int businessId)
        {
            return ApiRequest<List<PayRateTemplateModel>>(string.Format("/business/{0}/payratetemplate", businessId));
        }

        public int Create(int businessId, PayRateTemplateModel model)
        {
            return ApiRequest<int, PayRateTemplateModel>("/business/" + businessId + "/payratetemplate", model, Method.POST);
        }
    }
}