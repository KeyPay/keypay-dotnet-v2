using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;

namespace KeyPayV2.Sg.Functions
{
    public class QualificationsFunction : BaseFunction
    {
        public QualificationsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Qualifications
        /// </summary>
        /// <remarks>
        /// Lists all of the qualifications for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<QualificationModel> ListQualifications(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<QualificationModel>>($"/business/{businessId}/qualification{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Qualification
        /// </summary>
        /// <remarks>
        /// Creates a new employee qualification for the business.
        /// </remarks>
        public void CreateQualification(int businessId, QualificationModel qualification)
        {
            ApiRequest($"/business/{businessId}/qualification", qualification, Method.POST);
        }

        /// <summary>
        /// Get Qualification by ID
        /// </summary>
        /// <remarks>
        /// Gets the qualification with the specified ID.
        /// </remarks>
        public QualificationModel GetQualificationById(int businessId, int id)
        {
            return ApiRequest<QualificationModel>($"/business/{businessId}/qualification/{id}");
        }

        /// <summary>
        /// Update Qualification
        /// </summary>
        /// <remarks>
        /// Updates the qualification with the specified ID.
        /// </remarks>
        public void UpdateQualification(int businessId, int id, QualificationModel qualification)
        {
            ApiRequest($"/business/{businessId}/qualification/{id}", qualification, Method.PUT);
        }

        /// <summary>
        /// Delete Qualification
        /// </summary>
        /// <remarks>
        /// Deletes the qualification with the specified ID.
        /// </remarks>
        public void DeleteQualification(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/qualification/{id}", Method.DELETE);
        }
    }
}
