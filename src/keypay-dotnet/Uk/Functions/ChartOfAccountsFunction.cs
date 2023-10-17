using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.ChartOfAccounts;

namespace KeyPayV2.Uk.Functions
{
    public interface IChartOfAccountsFunction
    {
        List<JournalAccountModel> GetJournalAccounts(int businessId);
        Task<List<JournalAccountModel>> GetJournalAccountsAsync(int businessId, CancellationToken cancellationToken = default);
        JournalAccountModel CreateANewJournalAccount(int businessId, JournalAccountModel request);
        Task<JournalAccountModel> CreateANewJournalAccountAsync(int businessId, JournalAccountModel request, CancellationToken cancellationToken = default);
        JournalAccountModel GetJournalAccountById(int businessId, int id);
        Task<JournalAccountModel> GetJournalAccountByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        JournalAccountModel UpdateAnExistingJournalAccount(int businessId, int id, JournalAccountModel request);
        Task<JournalAccountModel> UpdateAnExistingJournalAccountAsync(int businessId, int id, JournalAccountModel request, CancellationToken cancellationToken = default);
        void DeleteAnExistingJournalAccount(int businessId, int id);
        Task DeleteAnExistingJournalAccountAsync(int businessId, int id, CancellationToken cancellationToken = default);
        JournalAccountBulkCreateModel BulkInsertJournalAccounts(int businessId, List<JournalAccountModel> request);
        Task<JournalAccountBulkCreateModel> BulkInsertJournalAccountsAsync(int businessId, List<JournalAccountModel> request, CancellationToken cancellationToken = default);
        JournalServiceProviderModel GetJournalServiceProvider(int businessId);
        Task<JournalServiceProviderModel> GetJournalServiceProviderAsync(int businessId, CancellationToken cancellationToken = default);
        JournalServiceProviderModel UpdateJournalServiceProvider(int businessId, JournalServiceProviderModel model);
        Task<JournalServiceProviderModel> UpdateJournalServiceProviderAsync(int businessId, JournalServiceProviderModel model, CancellationToken cancellationToken = default);
        List<string> GetJournalServiceProviders(int businessId);
        Task<List<string>> GetJournalServiceProvidersAsync(int businessId, CancellationToken cancellationToken = default);
        List<string> GetJournalAccountTypes(int businessId);
        Task<List<string>> GetJournalAccountTypesAsync(int businessId, CancellationToken cancellationToken = default);
        UkChartOfAccountsModel GetChartOfAccounts(int businessId);
        Task<UkChartOfAccountsModel> GetChartOfAccountsAsync(int businessId, CancellationToken cancellationToken = default);
        UkChartOfAccountsModel UpdateChartOfAccounts(int businessId, UkChartOfAccountsGroupModel chartOfAccounts);
        Task<UkChartOfAccountsModel> UpdateChartOfAccountsAsync(int businessId, UkChartOfAccountsGroupModel chartOfAccounts, CancellationToken cancellationToken = default);
        UkChartOfAccountsLocationGroupModel GetLocationSpecificChartOfAccounts(int businessId, int locationId);
        Task<UkChartOfAccountsLocationGroupModel> GetLocationSpecificChartOfAccountsAsync(int businessId, int locationId, CancellationToken cancellationToken = default);
        UkChartOfAccountsLocationGroupModel UpdateLocationSpecificChartOfAccounts(int businessId, int locationId, UkChartOfAccountsLocationGroupModel chartOfAccounts);
        Task<UkChartOfAccountsLocationGroupModel> UpdateLocationSpecificChartOfAccountsAsync(int businessId, int locationId, UkChartOfAccountsLocationGroupModel chartOfAccounts, CancellationToken cancellationToken = default);
        void DeleteLocationSpecificChartOfAccounts(int businessId, int locationId);
        Task DeleteLocationSpecificChartOfAccountsAsync(int businessId, int locationId, CancellationToken cancellationToken = default);
    }
    public class ChartOfAccountsFunction : BaseFunction, IChartOfAccountsFunction
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
            return ApiRequest<List<JournalAccountModel>>($"/business/{businessId}/accounts", Method.Get);
        }

        /// <summary>
        /// Get Journal Accounts
        /// </summary>
        /// <remarks>
        /// Gets the list of available journal accounts for the business.
        /// </remarks>
        public Task<List<JournalAccountModel>> GetJournalAccountsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<JournalAccountModel>>($"/business/{businessId}/accounts", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create a new Journal Account
        /// </summary>
        /// <remarks>
        /// Create a new journal account for the Business.
        /// </remarks>
        public JournalAccountModel CreateANewJournalAccount(int businessId, JournalAccountModel request)
        {
            return ApiRequest<JournalAccountModel,JournalAccountModel>($"/business/{businessId}/accounts", request, Method.Post);
        }

        /// <summary>
        /// Create a new Journal Account
        /// </summary>
        /// <remarks>
        /// Create a new journal account for the Business.
        /// </remarks>
        public Task<JournalAccountModel> CreateANewJournalAccountAsync(int businessId, JournalAccountModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<JournalAccountModel,JournalAccountModel>($"/business/{businessId}/accounts", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Journal Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the journal account with the specified ID.
        /// </remarks>
        public JournalAccountModel GetJournalAccountById(int businessId, int id)
        {
            return ApiRequest<JournalAccountModel>($"/business/{businessId}/accounts/{id}", Method.Get);
        }

        /// <summary>
        /// Get Journal Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the journal account with the specified ID.
        /// </remarks>
        public Task<JournalAccountModel> GetJournalAccountByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<JournalAccountModel>($"/business/{businessId}/accounts/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update an existing Journal Account
        /// </summary>
        /// <remarks>
        /// Update an existing journal account for the Business.
        /// </remarks>
        public JournalAccountModel UpdateAnExistingJournalAccount(int businessId, int id, JournalAccountModel request)
        {
            return ApiRequest<JournalAccountModel,JournalAccountModel>($"/business/{businessId}/accounts/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update an existing Journal Account
        /// </summary>
        /// <remarks>
        /// Update an existing journal account for the Business.
        /// </remarks>
        public Task<JournalAccountModel> UpdateAnExistingJournalAccountAsync(int businessId, int id, JournalAccountModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<JournalAccountModel,JournalAccountModel>($"/business/{businessId}/accounts/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete an existing Journal Account
        /// </summary>
        /// <remarks>
        /// Delete an existing journal account for the Business.
        /// </remarks>
        public void DeleteAnExistingJournalAccount(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/accounts/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete an existing Journal Account
        /// </summary>
        /// <remarks>
        /// Delete an existing journal account for the Business.
        /// </remarks>
        public Task DeleteAnExistingJournalAccountAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/accounts/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Bulk insert Journal Accounts
        /// </summary>
        /// <remarks>
        /// Create new journal accounts for the Business. This will not replace any existing journal accounts.
        /// </remarks>
        public JournalAccountBulkCreateModel BulkInsertJournalAccounts(int businessId, List<JournalAccountModel> request)
        {
            return ApiRequest<JournalAccountBulkCreateModel,List<JournalAccountModel>>($"/business/{businessId}/accounts/bulk", request, Method.Post);
        }

        /// <summary>
        /// Bulk insert Journal Accounts
        /// </summary>
        /// <remarks>
        /// Create new journal accounts for the Business. This will not replace any existing journal accounts.
        /// </remarks>
        public Task<JournalAccountBulkCreateModel> BulkInsertJournalAccountsAsync(int businessId, List<JournalAccountModel> request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<JournalAccountBulkCreateModel,List<JournalAccountModel>>($"/business/{businessId}/accounts/bulk", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Journal Service provider
        /// </summary>
        /// <remarks>
        /// Gets the name of the journal service provider.
        /// </remarks>
        public JournalServiceProviderModel GetJournalServiceProvider(int businessId)
        {
            return ApiRequest<JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice", Method.Get);
        }

        /// <summary>
        /// Get Journal Service provider
        /// </summary>
        /// <remarks>
        /// Gets the name of the journal service provider.
        /// </remarks>
        public Task<JournalServiceProviderModel> GetJournalServiceProviderAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Journal Service provider
        /// </summary>
        /// <remarks>
        /// Updates the journal service provider.
        /// </remarks>
        public JournalServiceProviderModel UpdateJournalServiceProvider(int businessId, JournalServiceProviderModel model)
        {
            return ApiRequest<JournalServiceProviderModel,JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice", model, Method.Put);
        }

        /// <summary>
        /// Update Journal Service provider
        /// </summary>
        /// <remarks>
        /// Updates the journal service provider.
        /// </remarks>
        public Task<JournalServiceProviderModel> UpdateJournalServiceProviderAsync(int businessId, JournalServiceProviderModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<JournalServiceProviderModel,JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Journal Service providers
        /// </summary>
        /// <remarks>
        /// Gets the Journal Service providers that can be configured via the API.
        /// </remarks>
        public List<string> GetJournalServiceProviders(int businessId)
        {
            return ApiRequest<List<string>>($"/business/{businessId}/accounts/journalservices", Method.Get);
        }

        /// <summary>
        /// Get Journal Service providers
        /// </summary>
        /// <remarks>
        /// Gets the Journal Service providers that can be configured via the API.
        /// </remarks>
        public Task<List<string>> GetJournalServiceProvidersAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<string>>($"/business/{businessId}/accounts/journalservices", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Journal Account Types
        /// </summary>
        /// <remarks>
        /// Gets the reference list of Journal Account Types.
        /// </remarks>
        public List<string> GetJournalAccountTypes(int businessId)
        {
            return ApiRequest<List<string>>($"/business/{businessId}/accounts/types", Method.Get);
        }

        /// <summary>
        /// Get Journal Account Types
        /// </summary>
        /// <remarks>
        /// Gets the reference list of Journal Account Types.
        /// </remarks>
        public Task<List<string>> GetJournalAccountTypesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<string>>($"/business/{businessId}/accounts/types", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Gets the default chart of accounts configuration for the business.
        /// </remarks>
        public UkChartOfAccountsModel GetChartOfAccounts(int businessId)
        {
            return ApiRequest<UkChartOfAccountsModel>($"/business/{businessId}/chartofaccounts", Method.Get);
        }

        /// <summary>
        /// Get Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Gets the default chart of accounts configuration for the business.
        /// </remarks>
        public Task<UkChartOfAccountsModel> GetChartOfAccountsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkChartOfAccountsModel>($"/business/{businessId}/chartofaccounts", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Updates the default chart of accounts configuration for the business.
        /// </remarks>
        public UkChartOfAccountsModel UpdateChartOfAccounts(int businessId, UkChartOfAccountsGroupModel chartOfAccounts)
        {
            return ApiRequest<UkChartOfAccountsModel,UkChartOfAccountsGroupModel>($"/business/{businessId}/chartofaccounts", chartOfAccounts, Method.Post);
        }

        /// <summary>
        /// Update Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Updates the default chart of accounts configuration for the business.
        /// </remarks>
        public Task<UkChartOfAccountsModel> UpdateChartOfAccountsAsync(int businessId, UkChartOfAccountsGroupModel chartOfAccounts, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkChartOfAccountsModel,UkChartOfAccountsGroupModel>($"/business/{businessId}/chartofaccounts", chartOfAccounts, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Gets the location specific chart of accounts configuration for a given location.
        /// </remarks>
        public UkChartOfAccountsLocationGroupModel GetLocationSpecificChartOfAccounts(int businessId, int locationId)
        {
            return ApiRequest<UkChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}", Method.Get);
        }

        /// <summary>
        /// Get Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Gets the location specific chart of accounts configuration for a given location.
        /// </remarks>
        public Task<UkChartOfAccountsLocationGroupModel> GetLocationSpecificChartOfAccountsAsync(int businessId, int locationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Updates the location specific chart of accounts configuration for the business.
        /// </remarks>
        public UkChartOfAccountsLocationGroupModel UpdateLocationSpecificChartOfAccounts(int businessId, int locationId, UkChartOfAccountsLocationGroupModel chartOfAccounts)
        {
            return ApiRequest<UkChartOfAccountsLocationGroupModel,UkChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}", chartOfAccounts, Method.Post);
        }

        /// <summary>
        /// Update Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Updates the location specific chart of accounts configuration for the business.
        /// </remarks>
        public Task<UkChartOfAccountsLocationGroupModel> UpdateLocationSpecificChartOfAccountsAsync(int businessId, int locationId, UkChartOfAccountsLocationGroupModel chartOfAccounts, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkChartOfAccountsLocationGroupModel,UkChartOfAccountsLocationGroupModel>($"/business/{businessId}/chartofaccounts/location/{locationId}", chartOfAccounts, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Deletes a location specific chart of accounts configuration for the business.
        /// </remarks>
        public void DeleteLocationSpecificChartOfAccounts(int businessId, int locationId)
        {
            ApiRequest($"/business/{businessId}/chartofaccounts/location/{locationId}", Method.Delete);
        }

        /// <summary>
        /// Delete Location Specific Chart of Accounts
        /// </summary>
        /// <remarks>
        /// Deletes a location specific chart of accounts configuration for the business.
        /// </remarks>
        public Task DeleteLocationSpecificChartOfAccountsAsync(int businessId, int locationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/chartofaccounts/location/{locationId}", Method.Delete, cancellationToken);
        }
    }
}
