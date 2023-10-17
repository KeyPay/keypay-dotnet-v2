using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;

namespace KeyPayV2.Sg.Functions
{
    public interface IQualificationsFunction
    {
        List<QualificationModel> ListQualifications(int businessId, ODataQuery oDataQuery = null);
        Task<List<QualificationModel>> ListQualificationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateQualification(int businessId, QualificationModel qualification);
        Task CreateQualificationAsync(int businessId, QualificationModel qualification, CancellationToken cancellationToken = default);
        QualificationModel GetQualificationById(int businessId, int id);
        Task<QualificationModel> GetQualificationByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateQualification(int businessId, int id, QualificationModel qualification);
        Task UpdateQualificationAsync(int businessId, int id, QualificationModel qualification, CancellationToken cancellationToken = default);
        void DeleteQualification(int businessId, int id);
        Task DeleteQualificationAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class QualificationsFunction : BaseFunction, IQualificationsFunction
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
            return ApiRequest<List<QualificationModel>>($"/business/{businessId}/qualification{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Qualifications
        /// </summary>
        /// <remarks>
        /// Lists all of the qualifications for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<QualificationModel>> ListQualificationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<QualificationModel>>($"/business/{businessId}/qualification{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Qualification
        /// </summary>
        /// <remarks>
        /// Creates a new employee qualification for the business.
        /// </remarks>
        public void CreateQualification(int businessId, QualificationModel qualification)
        {
            ApiRequest($"/business/{businessId}/qualification", qualification, Method.Post);
        }

        /// <summary>
        /// Create Qualification
        /// </summary>
        /// <remarks>
        /// Creates a new employee qualification for the business.
        /// </remarks>
        public Task CreateQualificationAsync(int businessId, QualificationModel qualification, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/qualification", qualification, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Qualification by ID
        /// </summary>
        /// <remarks>
        /// Gets the qualification with the specified ID.
        /// </remarks>
        public QualificationModel GetQualificationById(int businessId, int id)
        {
            return ApiRequest<QualificationModel>($"/business/{businessId}/qualification/{id}", Method.Get);
        }

        /// <summary>
        /// Get Qualification by ID
        /// </summary>
        /// <remarks>
        /// Gets the qualification with the specified ID.
        /// </remarks>
        public Task<QualificationModel> GetQualificationByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<QualificationModel>($"/business/{businessId}/qualification/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Qualification
        /// </summary>
        /// <remarks>
        /// Updates the qualification with the specified ID.
        /// </remarks>
        public void UpdateQualification(int businessId, int id, QualificationModel qualification)
        {
            ApiRequest($"/business/{businessId}/qualification/{id}", qualification, Method.Put);
        }

        /// <summary>
        /// Update Qualification
        /// </summary>
        /// <remarks>
        /// Updates the qualification with the specified ID.
        /// </remarks>
        public Task UpdateQualificationAsync(int businessId, int id, QualificationModel qualification, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/qualification/{id}", qualification, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Qualification
        /// </summary>
        /// <remarks>
        /// Deletes the qualification with the specified ID.
        /// </remarks>
        public void DeleteQualification(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/qualification/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Qualification
        /// </summary>
        /// <remarks>
        /// Deletes the qualification with the specified ID.
        /// </remarks>
        public Task DeleteQualificationAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/qualification/{id}", Method.Delete, cancellationToken);
        }
    }
}
