using KeyPay.DomainModels.V2.Business;
using RestSharp;
using System.Collections.Generic;

namespace KeyPay.ApiFunctions.V2
{
    public class BusinessActionItems : BaseFunction
    {
        public BusinessActionItems(ApiRequestExecutor api) : base(api)
        {
        }

        public List<BusinessAction> ListBusinessNotifications(int businessId)
        {
            var result = ApiRequest<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications");
            return result;
        }

        public void DismissBusinessNotifications(int businessId, int id)
        {
            ApiRequest<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications/{id}/dismiss", Method.DELETE);
        }
    }
}
