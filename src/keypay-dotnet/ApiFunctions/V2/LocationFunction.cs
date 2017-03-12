using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class LocationFunction : BaseFunction
    {
        public LocationFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public IList<LocationModel> List(int businessId)
        {
            return ApiRequest<List<LocationModel>>("/business/" + businessId + "/location");
        }

        public LocationModel Get(int businessId, int locationId)
        {
            return ApiRequest<LocationModel>("/business/" + businessId + "/location/" + locationId);
        }

        public LocationModel Create(int businessId, LocationModel model)
        {
            return ApiRequest<LocationModel, LocationModel>("/business/" + businessId + "/location", model, Method.POST);
        }

        public void Update(int businessId, LocationModel model)
        {
            ApiRequest<LocationModel, LocationModel>("/business/" + businessId + "/location/" + model.Id, model, Method.PUT);
        }
    }

}