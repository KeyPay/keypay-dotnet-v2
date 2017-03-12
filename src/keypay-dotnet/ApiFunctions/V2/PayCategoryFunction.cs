using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class PayCategoryFunction : BaseFunction
    {
        public PayCategoryFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<PayCategoryModel> List(int businessId)
        {
            return ApiRequest<List<PayCategoryModel>>("/business/" + businessId + "/paycategory");
        }

        public PayCategoryModel Get(int businessId, int payCategoryId)
        {
                return ApiRequest<PayCategoryModel>("/business/" + businessId + "/paycategory/" + payCategoryId);
        }

        public PayCategoryModel Create(int businessId, PayCategoryModel model)
        {
            return ApiRequest<PayCategoryModel, PayCategoryModel>("/business/" + businessId + "/paycategory", model, Method.POST);
        }

        public PayCategoryModel Update(int businessId, PayCategoryModel model)
        {
            return ApiRequest<PayCategoryModel, PayCategoryModel>("/business/" + businessId + "/paycategory/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int payCategoryId)
        {
            ApiRequest("/business/" + businessId + "/paycategory/" + payCategoryId, Method.DELETE);
        }
        
    }
}