using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.AbaSettings;

namespace KeyPayV2.Au.Functions
{
    public class AbaSettingsFunction : BaseFunction
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
            return ApiRequest<List<BusinessAbaModel>>($"/business/{businessId}/aba{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Creates a new ABA settings record for the business.
        /// </remarks>
        public void CreateAbaSettingsRecord(int businessId, BusinessAbaModel abaDetails)
        {
            ApiRequest($"/business/{businessId}/aba", abaDetails, Method.POST);
        }

        /// <summary>
        /// Get ABA Settings Record by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the ABA settings record with the specified ID.
        /// </remarks>
        public BusinessAbaModel GetAbaSettingsRecordById(int businessId, int id)
        {
            return ApiRequest<BusinessAbaModel>($"/business/{businessId}/aba/{id}");
        }

        /// <summary>
        /// Update ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Updates the ABA settings record with the specified ID.
        /// </remarks>
        public void UpdateAbaSettingsRecord(int businessId, int id, BusinessAbaModel abaDetails)
        {
            ApiRequest($"/business/{businessId}/aba/{id}", abaDetails, Method.PUT);
        }

        /// <summary>
        /// Delete ABA Settings Record
        /// </summary>
        /// <remarks>
        /// Deletes the ABA settings record with the specified ID.
        /// </remarks>
        public void DeleteAbaSettingsRecord(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/aba/{id}", Method.DELETE);
        }
    }
}
