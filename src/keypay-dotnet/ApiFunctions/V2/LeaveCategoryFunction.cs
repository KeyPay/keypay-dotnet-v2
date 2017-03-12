using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class LeaveCategoryFunction : BaseFunction
    {
        public LeaveCategoryFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public IList<LeaveCategoryModel> List(int businessId)
        {
            return ApiRequest<List<LeaveCategoryModel>>("/business/" + businessId + "/leavecategory");
        }

        public LeaveCategoryModel Get(int businessId, int leaveCategoryId)
        {
            return ApiRequest<LeaveCategoryModel>("/business/" + businessId + "/leavecategory/" + leaveCategoryId);
        }

        public LeaveCategoryModel Create(int businessId, LeaveCategoryModel model)
        {
            return ApiRequest<LeaveCategoryModel, LeaveCategoryModel>("/business/" + businessId + "/leavecategory", model, Method.POST);
        }

        public LeaveCategoryModel Update(int businessId, LeaveCategoryModel model)
        {
            return ApiRequest<LeaveCategoryModel, LeaveCategoryModel>("/business/" + businessId + "/leavecategory/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int leaveCategoryId)
        {
            ApiRequest("/business/" + businessId + "/leavecategory/" + leaveCategoryId, Method.DELETE);
        }

    }
}