using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class ChartOfAccountsFunction : BaseFunction
    {
        public ChartOfAccountsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public ChartOfAccountsModel Default(int businessId)
        {
            return ApiRequest<ChartOfAccountsModel>($"/business/{businessId}/chartofaccounts");
        }

        public ChartOfAccountsLocationGroupModel Location(int businessId, int locationId)
        {
            return ApiRequest<ChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}");
        }

        public ChartOfAccountsModel UpdateDefault(int businessId, ChartOfAccountsGroupModel chartOfAccounts)
        {
            return ApiRequest<ChartOfAccountsModel, ChartOfAccountsGroupModel>($"/business/{businessId}/chartofaccounts", chartOfAccounts, Method.POST);
        }

        public ChartOfAccountsLocationGroupModel UpdateLocation(int businessId, ChartOfAccountsLocationGroupModel chartOfAccounts)
        {
            return ApiRequest<ChartOfAccountsLocationGroupModel, ChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{chartOfAccounts.LocationId}", chartOfAccounts, Method.POST);
        }

        public void DeleteLocation(int businessId, int locationId)
        {
            ApiRequest($"/business/{businessId}/chartofaccounts/location/{locationId}", Method.DELETE);
        }
    }
}