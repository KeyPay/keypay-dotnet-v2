using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.AbaSettings;

namespace KeyPayV2.Au.Functions
{
    public interface IAbaSettingsFunction
    {
        List<BusinessAbaModel> ListAbaSettings(int businessId, ODataQuery oDataQuery = null);
        Task<List<BusinessAbaModel>> ListAbaSettingsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateAbaSettingsRecord(int businessId, BusinessAbaModel abaDetails);
        Task CreateAbaSettingsRecordAsync(int businessId, BusinessAbaModel abaDetails, CancellationToken cancellationToken = default);
        BusinessAbaModel GetAbaSettingsRecordById(int businessId, int id);
        Task<BusinessAbaModel> GetAbaSettingsRecordByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateAbaSettingsRecord(int businessId, int id, BusinessAbaModel abaDetails);
        Task UpdateAbaSettingsRecordAsync(int businessId, int id, BusinessAbaModel abaDetails, CancellationToken cancellationToken = default);
        void DeleteAbaSettingsRecord(int businessId, int id);
        Task DeleteAbaSettingsRecordAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class AbaSettingsFunction : BaseFunction, IAbaSettingsFunction
    {
        public AbaSettingsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List ABA Settings
        /// </summary>
        /// <remarks>
        /// Retrieves all the ABA settings associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<BusinessAbaModel> ListAbaSettings(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<BusinessAbaModel>>($"/business/{businessId}/aba{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List ABA Settings
        /// </summary>
        /// <remarks>
        /// Retrieves all the ABA settings associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<BusinessAbaModel>> ListAbaSettingsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BusinessAbaModel>>($"/business/{businessId}/aba{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Creates a new ABA settings record for the business.
        /// </remarks>
        public void CreateAbaSettingsRecord(int businessId, BusinessAbaModel abaDetails)
        {
            ApiRequest($"/business/{businessId}/aba", abaDetails, Method.Post);
        }

        /// <summary>
        /// Create ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Creates a new ABA settings record for the business.
        /// </remarks>
        public Task CreateAbaSettingsRecordAsync(int businessId, BusinessAbaModel abaDetails, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/aba", abaDetails, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get ABA Settings Record by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the ABA settings record with the specified ID.
        /// </remarks>
        public BusinessAbaModel GetAbaSettingsRecordById(int businessId, int id)
        {
            return ApiRequest<BusinessAbaModel>($"/business/{businessId}/aba/{id}", Method.Get);
        }

        /// <summary>
        /// Get ABA Settings Record by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the ABA settings record with the specified ID.
        /// </remarks>
        public Task<BusinessAbaModel> GetAbaSettingsRecordByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BusinessAbaModel>($"/business/{businessId}/aba/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Updates the ABA settings record with the specified ID.
        /// </remarks>
        public void UpdateAbaSettingsRecord(int businessId, int id, BusinessAbaModel abaDetails)
        {
            ApiRequest($"/business/{businessId}/aba/{id}", abaDetails, Method.Put);
        }

        /// <summary>
        /// Update ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Updates the ABA settings record with the specified ID.
        /// </remarks>
        public Task UpdateAbaSettingsRecordAsync(int businessId, int id, BusinessAbaModel abaDetails, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/aba/{id}", abaDetails, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Deletes the ABA settings record with the specified ID.
        /// </remarks>
        public void DeleteAbaSettingsRecord(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/aba/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Deletes the ABA settings record with the specified ID.
        /// </remarks>
        public Task DeleteAbaSettingsRecordAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/aba/{id}", Method.Delete, cancellationToken);
        }
    }
}
