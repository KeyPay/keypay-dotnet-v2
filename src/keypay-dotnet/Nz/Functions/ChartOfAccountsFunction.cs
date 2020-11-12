using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.ChartOfAccounts;

namespace KeyPayV2.Nz.Functions
{
    public class ChartOfAccountsFunction : BaseFunction
    {
        public ChartOfAccountsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Journal Accounts
        /// </summary>
        /// <remarks>
        /// Gets the list of available journal accounts for the business.
        /// </remarks>
        public List<JournalAccountModel> GetJournalAccounts(int businessId)
        {
            return ApiRequest<List<JournalAccountModel>>($"/business/{businessId}/accounts");
        }

        /// <summary>
        /// Create a new Journal Account
        /// </summary>
        /// <remarks>
        /// Create a new journal account for the Business.
        /// </remarks>
        public JournalAccountModel CreateANewJournalAccount(int businessId, JournalAccountModel request)
        {
            return ApiRequest<JournalAccountModel,JournalAccountModel>($"/business/{businessId}/accounts", request, Method.POST);
        }

        /// <summary>
        /// Get Journal Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the journal account with the specified ID.
        /// </remarks>
        public JournalAccountModel GetJournalAccountById(int businessId, int id)
        {
            return ApiRequest<JournalAccountModel>($"/business/{businessId}/accounts/{id}");
        }

        /// <summary>
        /// Update an existing Journal Account
        /// </summary>
        /// <remarks>
        /// Update an existing journal account for the Business.
        /// </remarks>
        public JournalAccountModel UpdateAnExistingJournalAccount(int businessId, int id, JournalAccountModel request)
        {
            return ApiRequest<JournalAccountModel,JournalAccountModel>($"/business/{businessId}/accounts/{id}", request, Method.PUT);
        }

        /// <summary>
        /// Delete an existing Journal Account
        /// </summary>
        /// <remarks>
        /// Delete an existing journal account for the Business.
        /// </remarks>
        public void DeleteAnExistingJournalAccount(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/accounts/{id}", Method.DELETE);
        }

        /// <summary>
        /// Bulk insert Journal Accounts
        /// </summary>
        /// <remarks>
        /// Create new journal accounts for the Business. This will not replace any existing journal accounts.
        /// </remarks>
        public JournalAccountBulkCreateModel BulkInsertJournalAccounts(int businessId, List<JournalAccountModel> request)
        {
            return ApiRequest<JournalAccountBulkCreateModel,List<JournalAccountModel>>($"/business/{businessId}/accounts/bulk", request, Method.POST);
        }

        /// <summary>
        /// Get Journal Service provider
        /// </summary>
        /// <remarks>
        /// Gets the name of the journal service provider.
        /// </remarks>
        public JournalServiceProviderModel GetJournalServiceProvider(int businessId)
        {
            return ApiRequest<JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice");
        }

        /// <summary>
        /// Update Journal Service provider
        /// </summary>
        /// <remarks>
        /// Updates the journal service provider.
        /// </remarks>
        public JournalServiceProviderModel UpdateJournalServiceProvider(int businessId, JournalServiceProviderModel model)
        {
            return ApiRequest<JournalServiceProviderModel,JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice", model, Method.PUT);
        }

        /// <summary>
        /// Get Journal Service providers
        /// </summary>
        /// <remarks>
        /// Gets the Journal Service providers that can be configured via the API.
        /// </remarks>
        public List<string> GetJournalServiceProviders(int businessId)
        {
            return ApiRequest<List<string>>($"/business/{businessId}/accounts/journalservices");
        }

        /// <summary>
        /// Get Journal Account Types
        /// </summary>
        /// <remarks>
        /// Gets the reference list of Journal Account Types.
        /// </remarks>
        public List<string> GetJournalAccountTypes(int businessId)
        {
            return ApiRequest<List<string>>($"/business/{businessId}/accounts/types");
        }

        /// <summary>
        /// Get Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Gets the default chart of accounts configuration for the business.
        /// </remarks>
        public NzChartOfAccountsModel GetChartOfAccounts(int businessId)
        {
            return ApiRequest<NzChartOfAccountsModel>($"/business/{businessId}/chartofaccounts");
        }

        /// <summary>
        /// Update Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Updates the default chart of accounts configuration for the business.
        /// </remarks>
        public NzChartOfAccountsModel UpdateChartOfAccounts(int businessId, NzChartOfAccountsGroupModel chartOfAccounts)
        {
            return ApiRequest<NzChartOfAccountsModel,NzChartOfAccountsGroupModel>($"/business/{businessId}/chartofaccounts", chartOfAccounts, Method.POST);
        }

        /// <summary>
        /// Get Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Gets the location specific chart of accounts configuration for a given location.
        /// </remarks>
        public NzChartOfAccountsLocationGroupModel GetLocationSpecificChartOfAccounts(int businessId, int locationId)
        {
            return ApiRequest<NzChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}");
        }

        /// <summary>
        /// Update Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Updates the location specific chart of accounts configuration for the business.
        /// </remarks>
        public NzChartOfAccountsLocationGroupModel UpdateLocationSpecificChartOfAccounts(int businessId, int locationId, NzChartOfAccountsLocationGroupModel chartOfAccounts)
        {
            return ApiRequest<NzChartOfAccountsLocationGroupModel,NzChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}", chartOfAccounts, Method.POST);
        }

        /// <summary>
        /// Delete Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Deletes a location specific chart of accounts configuration for the business.
        /// </remarks>
        public void DeleteLocationSpecificChartOfAccounts(int businessId, int locationId)
        {
            ApiRequest($"/business/{businessId}/chartofaccounts/location/{locationId}", Method.DELETE);
        }
    }
}
