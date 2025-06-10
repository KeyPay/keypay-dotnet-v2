using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.ReportingDimensions;

namespace KeyPayV2.My.Functions
{
    public interface IReportingDimensionsFunction
    {
        List<ReportingDimensionApiModel> ListDimensions(int businessId, ODataQuery oDataQuery = null);
        Task<List<ReportingDimensionApiModel>> ListDimensionsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        ReportingDimensionApiModel CreateDimension(int businessId, ReportingDimensionApiModel dimension);
        Task<ReportingDimensionApiModel> CreateDimensionAsync(int businessId, ReportingDimensionApiModel dimension, CancellationToken cancellationToken = default);
        List<ReportingDimensionValueApiModel> ListDimensionValues(int businessId, int dimensionId, ODataQuery oDataQuery = null);
        Task<List<ReportingDimensionValueApiModel>> ListDimensionValuesAsync(int businessId, int dimensionId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        ReportingDimensionValueApiModel CreateDimensionValue(int businessId, int dimensionId, ReportingDimensionValueApiModel dimensionValue);
        Task<ReportingDimensionValueApiModel> CreateDimensionValueAsync(int businessId, int dimensionId, ReportingDimensionValueApiModel dimensionValue, CancellationToken cancellationToken = default);
        ReportingDimensionValueApiModel GetDimensionValueById(int businessId, int id, int dimensionId);
        Task<ReportingDimensionValueApiModel> GetDimensionValueByIdAsync(int businessId, int id, int dimensionId, CancellationToken cancellationToken = default);
        ReportingDimensionValueApiModel UpdateDimensionValue(int businessId, int id, int dimensionId, ReportingDimensionValueApiModel dimensionValueModel);
        Task<ReportingDimensionValueApiModel> UpdateDimensionValueAsync(int businessId, int id, int dimensionId, ReportingDimensionValueApiModel dimensionValueModel, CancellationToken cancellationToken = default);
        void DeleteDimensionValue(int businessId, int id, int dimensionId);
        Task DeleteDimensionValueAsync(int businessId, int id, int dimensionId, CancellationToken cancellationToken = default);
        ReportingDimensionApiModel GetDimensionById(int businessId, int id);
        Task<ReportingDimensionApiModel> GetDimensionByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        ReportingDimensionApiModel UpdateDimension(int businessId, int id, ReportingDimensionApiModel dimensionModel);
        Task<ReportingDimensionApiModel> UpdateDimensionAsync(int businessId, int id, ReportingDimensionApiModel dimensionModel, CancellationToken cancellationToken = default);
        void DeleteDimension(int businessId, int id);
        Task DeleteDimensionAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class ReportingDimensionsFunction : BaseFunction, IReportingDimensionsFunction
    {
        public ReportingDimensionsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Dimensions
        /// </summary>
        /// <remarks>
        /// Lists all the dimensions defined for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<ReportingDimensionApiModel> ListDimensions(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<ReportingDimensionApiModel>>($"/business/{businessId}/dimension{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Dimensions
        /// </summary>
        /// <remarks>
        /// Lists all the dimensions defined for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<ReportingDimensionApiModel>> ListDimensionsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ReportingDimensionApiModel>>($"/business/{businessId}/dimension{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Dimension
        /// </summary>
        /// <remarks>
        /// Creates a new dimension for the business.
        /// </remarks>
        public ReportingDimensionApiModel CreateDimension(int businessId, ReportingDimensionApiModel dimension)
        {
            return ApiRequest<ReportingDimensionApiModel,ReportingDimensionApiModel>($"/business/{businessId}/dimension", dimension, Method.Post);
        }

        /// <summary>
        /// Create Dimension
        /// </summary>
        /// <remarks>
        /// Creates a new dimension for the business.
        /// </remarks>
        public Task<ReportingDimensionApiModel> CreateDimensionAsync(int businessId, ReportingDimensionApiModel dimension, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportingDimensionApiModel,ReportingDimensionApiModel>($"/business/{businessId}/dimension", dimension, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Dimension Values
        /// </summary>
        /// <remarks>
        /// Lists all the values defined for the specified dimension.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<ReportingDimensionValueApiModel> ListDimensionValues(int businessId, int dimensionId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<ReportingDimensionValueApiModel>>($"/business/{businessId}/dimension/{dimensionId}/value{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Dimension Values
        /// </summary>
        /// <remarks>
        /// Lists all the values defined for the specified dimension.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<ReportingDimensionValueApiModel>> ListDimensionValuesAsync(int businessId, int dimensionId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ReportingDimensionValueApiModel>>($"/business/{businessId}/dimension/{dimensionId}/value{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Dimension Value
        /// </summary>
        /// <remarks>
        /// Creates a new value for the specified dimension.
        /// </remarks>
        public ReportingDimensionValueApiModel CreateDimensionValue(int businessId, int dimensionId, ReportingDimensionValueApiModel dimensionValue)
        {
            return ApiRequest<ReportingDimensionValueApiModel,ReportingDimensionValueApiModel>($"/business/{businessId}/dimension/{dimensionId}/value", dimensionValue, Method.Post);
        }

        /// <summary>
        /// Create Dimension Value
        /// </summary>
        /// <remarks>
        /// Creates a new value for the specified dimension.
        /// </remarks>
        public Task<ReportingDimensionValueApiModel> CreateDimensionValueAsync(int businessId, int dimensionId, ReportingDimensionValueApiModel dimensionValue, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportingDimensionValueApiModel,ReportingDimensionValueApiModel>($"/business/{businessId}/dimension/{dimensionId}/value", dimensionValue, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Dimension Value by ID
        /// </summary>
        /// <remarks>
        /// Gets the dimension value with the specified ID.
        /// </remarks>
        public ReportingDimensionValueApiModel GetDimensionValueById(int businessId, int id, int dimensionId)
        {
            return ApiRequest<ReportingDimensionValueApiModel>($"/business/{businessId}/dimension/{dimensionId}/value/{id}", Method.Get);
        }

        /// <summary>
        /// Get Dimension Value by ID
        /// </summary>
        /// <remarks>
        /// Gets the dimension value with the specified ID.
        /// </remarks>
        public Task<ReportingDimensionValueApiModel> GetDimensionValueByIdAsync(int businessId, int id, int dimensionId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportingDimensionValueApiModel>($"/business/{businessId}/dimension/{dimensionId}/value/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Dimension Value
        /// </summary>
        /// <remarks>
        /// Updates the dimension value with the specified ID.
        /// </remarks>
        public ReportingDimensionValueApiModel UpdateDimensionValue(int businessId, int id, int dimensionId, ReportingDimensionValueApiModel dimensionValueModel)
        {
            return ApiRequest<ReportingDimensionValueApiModel,ReportingDimensionValueApiModel>($"/business/{businessId}/dimension/{dimensionId}/value/{id}", dimensionValueModel, Method.Put);
        }

        /// <summary>
        /// Update Dimension Value
        /// </summary>
        /// <remarks>
        /// Updates the dimension value with the specified ID.
        /// </remarks>
        public Task<ReportingDimensionValueApiModel> UpdateDimensionValueAsync(int businessId, int id, int dimensionId, ReportingDimensionValueApiModel dimensionValueModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportingDimensionValueApiModel,ReportingDimensionValueApiModel>($"/business/{businessId}/dimension/{dimensionId}/value/{id}", dimensionValueModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Dimension Value
        /// </summary>
        /// <remarks>
        /// Deletes the dimension value with the specified ID.
        /// </remarks>
        public void DeleteDimensionValue(int businessId, int id, int dimensionId)
        {
            ApiRequest($"/business/{businessId}/dimension/{dimensionId}/value/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Dimension Value
        /// </summary>
        /// <remarks>
        /// Deletes the dimension value with the specified ID.
        /// </remarks>
        public Task DeleteDimensionValueAsync(int businessId, int id, int dimensionId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/dimension/{dimensionId}/value/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Dimension by ID
        /// </summary>
        /// <remarks>
        /// Gets the dimension with the specified ID.
        /// </remarks>
        public ReportingDimensionApiModel GetDimensionById(int businessId, int id)
        {
            return ApiRequest<ReportingDimensionApiModel>($"/business/{businessId}/dimension/{id}", Method.Get);
        }

        /// <summary>
        /// Get Dimension by ID
        /// </summary>
        /// <remarks>
        /// Gets the dimension with the specified ID.
        /// </remarks>
        public Task<ReportingDimensionApiModel> GetDimensionByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportingDimensionApiModel>($"/business/{businessId}/dimension/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Dimension
        /// </summary>
        /// <remarks>
        /// Updates the dimension with the specified ID.
        /// </remarks>
        public ReportingDimensionApiModel UpdateDimension(int businessId, int id, ReportingDimensionApiModel dimensionModel)
        {
            return ApiRequest<ReportingDimensionApiModel,ReportingDimensionApiModel>($"/business/{businessId}/dimension/{id}", dimensionModel, Method.Put);
        }

        /// <summary>
        /// Update Dimension
        /// </summary>
        /// <remarks>
        /// Updates the dimension with the specified ID.
        /// </remarks>
        public Task<ReportingDimensionApiModel> UpdateDimensionAsync(int businessId, int id, ReportingDimensionApiModel dimensionModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportingDimensionApiModel,ReportingDimensionApiModel>($"/business/{businessId}/dimension/{id}", dimensionModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Dimension
        /// </summary>
        /// <remarks>
        /// Deletes the dimension with the specified ID.
        /// </remarks>
        public void DeleteDimension(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/dimension/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Dimension
        /// </summary>
        /// <remarks>
        /// Deletes the dimension with the specified ID.
        /// </remarks>
        public Task DeleteDimensionAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/dimension/{id}", Method.Delete, cancellationToken);
        }
    }
}
