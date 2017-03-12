using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class WorkTypeFunction : BaseFunction
    {
        public WorkTypeFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public WorkTypeModel Get(int businessId, int workTypeId)
        {
            return ApiRequest<WorkTypeModel>(string.Format("/business/{0}/worktype/{1}", businessId, workTypeId));
        }

        public IList<WorkTypeModel> List(int businessId)
        {
            return ApiRequest<List<WorkTypeModel>>(string.Format("/business/{0}/worktype", businessId));
        }

        public WorkTypeModel Create(int businessId, WorkTypeModel model)
        {
            return ApiRequest<WorkTypeModel, WorkTypeModel>("/business/" + businessId + "/worktype", model, Method.POST);
        }

        public void Update(int businessId, WorkTypeModel model)
        {
            ApiRequest("/business/" + businessId + "/worktype/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int workTypeId)
        {
            ApiRequest("/business/" + businessId + "/worktype/" + workTypeId, Method.DELETE);
        }
    }
}