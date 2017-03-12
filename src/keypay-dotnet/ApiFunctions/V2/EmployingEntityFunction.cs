using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployingEntityFunction : BaseFunction
    {
        public EmployingEntityFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<EmployingEntityModel> List(int businessId)
        {
            return ApiRequest<List<EmployingEntityModel>>("/business/" + businessId + "/employingentity");
        }

        public EmployingEntityModel Get(int businessId, int employingEntityId)
        {
            return ApiRequest<EmployingEntityModel>("/business/" + businessId + "/employingentity/" + employingEntityId);
        }

        public EmployingEntityModel Create(int businessId, EmployingEntityModel model)
        {
            return ApiRequest<EmployingEntityModel, EmployingEntityModel>("/business/" + businessId + "/employingentity", model, Method.POST);
        }

        public void Update(int businessId, EmployingEntityModel model)
        {
            ApiRequest<EmployingEntityModel, EmployingEntityModel>("/business/" + businessId + "/employingentity/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int id)
        {
            ApiRequest<EmployingEntityModel>("/business/" + businessId + "/employingentity/" + id, Method.DELETE);
        }
    }
}