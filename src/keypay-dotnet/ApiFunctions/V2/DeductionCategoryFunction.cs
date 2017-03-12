using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class DeductionCategoryFunction : BaseFunction
    {
        public DeductionCategoryFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public IList<DeductionCategoryModel> List(int businessId)
        {
            return ApiRequest<List<DeductionCategoryModel>>("/business/" + businessId + "/deductioncategory");
        }

        public DeductionCategoryModel Create(int businessId, DeductionCategoryModel model)
        {
            return ApiRequest<DeductionCategoryModel, DeductionCategoryModel>("/business/" + businessId + "/deductioncategory", model, Method.POST);
        }

        public DeductionCategoryModel Update(int businessId, DeductionCategoryModel model)
        {
            return ApiRequest<DeductionCategoryModel, DeductionCategoryModel>("/business/" + businessId + "/deductioncategory/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int deductionCategoryId)
        {
            ApiRequest("/business/" + businessId + "/deductioncategory/" + deductionCategoryId, Method.DELETE);
        }
    }
}