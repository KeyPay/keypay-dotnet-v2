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
using KeyPayV2.Uk.Models.LeaveCategories;

namespace KeyPayV2.Uk.Functions
{
    public interface ILeaveCategoriesFunction
    {
        List<UkLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkLeaveCategoryModel CreateLeaveCategory(int businessId, UkLeaveCategoryModel leaveCategory);
        Task<UkLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, UkLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        UkLeaveCategoryModel GetLeaveCategoryById(int businessId, int id);
        Task<UkLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, UkLeaveCategoryModel leaveCategory);
        Task<UkLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, UkLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        void DeleteLeaveCategory(int businessId, int id);
        Task DeleteLeaveCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void SaveLeaveYearSettings(int businessId, LeaveBusinessSettingsApiModel leaveBusinessSettingsModel);
        Task SaveLeaveYearSettingsAsync(int businessId, LeaveBusinessSettingsApiModel leaveBusinessSettingsModel, CancellationToken cancellationToken = default);
    }
    public class LeaveCategoriesFunction : BaseFunction, ILeaveCategoriesFunction
    {
        public LeaveCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public UkLeaveCategoryModel CreateLeaveCategory(int businessId, UkLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<UkLeaveCategoryModel,UkLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public Task<UkLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, UkLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkLeaveCategoryModel,UkLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public UkLeaveCategoryModel GetLeaveCategoryById(int businessId, int id)
        {
            return ApiRequest<UkLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public Task<UkLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public UkLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, UkLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<UkLeaveCategoryModel,UkLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public Task<UkLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, UkLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkLeaveCategoryModel,UkLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Category
        /// </summary>
        /// <remarks>
        /// Deletes the leave category with the specified ID.
        /// </remarks>
        public void DeleteLeaveCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leavecategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Category
        /// </summary>
        /// <remarks>
        /// Deletes the leave category with the specified ID.
        /// </remarks>
        public Task DeleteLeaveCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leavecategory/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Save Leave Year Settings
        /// </summary>
        public void SaveLeaveYearSettings(int businessId, LeaveBusinessSettingsApiModel leaveBusinessSettingsModel)
        {
            ApiRequest($"/business/{businessId}/leavecategory/saveleaveyearsettings", leaveBusinessSettingsModel, Method.Put);
        }

        /// <summary>
        /// Save Leave Year Settings
        /// </summary>
        public Task SaveLeaveYearSettingsAsync(int businessId, LeaveBusinessSettingsApiModel leaveBusinessSettingsModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leavecategory/saveleaveyearsettings", leaveBusinessSettingsModel, Method.Put, cancellationToken);
        }
    }
}
