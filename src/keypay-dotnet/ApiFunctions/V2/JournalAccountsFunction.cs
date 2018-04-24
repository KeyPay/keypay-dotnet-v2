using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class JournalAccountsFunction : BaseFunction
    {
        public JournalAccountsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<JournalAccountModel> List(int businessId)
        {
            return ApiRequest<List<JournalAccountModel>>($"/business/{businessId}/accounts", Method.GET);
        }

        public JournalAccountModel Get(int businessId, int journalAccountId)
        {
            return ApiRequest<JournalAccountModel>($"/business/{businessId}/accounts/{journalAccountId}", Method.GET);
        }

        public JournalAccountModel Create(int businessId, JournalAccountModel model)
        {
            return ApiRequest<JournalAccountModel, JournalAccountModel>($"/business/{businessId}/accounts", model, Method.POST);
        }

        public JournalAccountModel Update(int businessId, JournalAccountModel model)
        {
            return ApiRequest<JournalAccountModel, JournalAccountModel>($"/business/{businessId}/accounts/{model.Id}", model, Method.PUT);
        }

        public JournalAccountBulkCreateModel BulkCreate(int businessId, List<JournalAccountModel> model)
        {
            return ApiRequest<JournalAccountBulkCreateModel, List<JournalAccountModel>>($"/business/{businessId}/accounts/bulk", model, Method.POST);
        }

        public void Delete(int businessId, int journalAccountId)
        {
            ApiRequest($"/business/{businessId}/accounts/{journalAccountId}", Method.DELETE);
        }
    }
}