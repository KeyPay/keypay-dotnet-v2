using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.LeaveCategories;

namespace KeyPayV2.Nz.Functions
{
    public interface ILeaveCategoriesFunction
    {
        BusinessHolidayLeaveSettingsDetailModel GetHolidayLeaveSettings(int businessId);
        Task<BusinessHolidayLeaveSettingsDetailModel> GetHolidayLeaveSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        NzLeaveAllowanceModel SetHolidayLeaveSettings(int businessId, BusinessHolidayLeaveSettingsModel model);
        Task<NzLeaveAllowanceModel> SetHolidayLeaveSettingsAsync(int businessId, BusinessHolidayLeaveSettingsModel model, CancellationToken cancellationToken = default);
        List<NzLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzLeaveCategoryModel CreateLeaveCategory(int businessId, NzLeaveCategoryModel leaveCategory);
        Task<NzLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, NzLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        NzLeaveCategoryModel GetLeaveCategoryById(int businessId, int id);
        Task<NzLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        NzLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, NzLeaveCategoryModel leaveCategory);
        Task<NzLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, NzLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        void DeleteLeaveCategory(int businessId, int id);
        Task DeleteLeaveCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class LeaveCategoriesFunction : BaseFunction, ILeaveCategoriesFunction
    {
        public LeaveCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Holiday Leave Settings
        /// </summary>
        /// <remarks>
        /// Gets the holiday leave settings for the business
        /// </remarks>
        public BusinessHolidayLeaveSettingsDetailModel GetHolidayLeaveSettings(int businessId)
        {
            return ApiRequest<BusinessHolidayLeaveSettingsDetailModel>($"/business/{businessId}/holidayleavesettings", Method.Get);
        }

        /// <summary>
        /// Get Holiday Leave Settings
        /// </summary>
        /// <remarks>
        /// Gets the holiday leave settings for the business
        /// </remarks>
        public Task<BusinessHolidayLeaveSettingsDetailModel> GetHolidayLeaveSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BusinessHolidayLeaveSettingsDetailModel>($"/business/{businessId}/holidayleavesettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Holiday Leave Settings
        /// </summary>
        /// <remarks>
        /// Sets the holiday leave settings for the business
        /// </remarks>
        public NzLeaveAllowanceModel SetHolidayLeaveSettings(int businessId, BusinessHolidayLeaveSettingsModel model)
        {
            return ApiRequest<NzLeaveAllowanceModel,BusinessHolidayLeaveSettingsModel>($"/business/{businessId}/holidayleavesettings", model, Method.Put);
        }

        /// <summary>
        /// Set Holiday Leave Settings
        /// </summary>
        /// <remarks>
        /// Sets the holiday leave settings for the business
        /// </remarks>
        public Task<NzLeaveAllowanceModel> SetHolidayLeaveSettingsAsync(int businessId, BusinessHolidayLeaveSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveAllowanceModel,BusinessHolidayLeaveSettingsModel>($"/business/{businessId}/holidayleavesettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public NzLeaveCategoryModel CreateLeaveCategory(int businessId, NzLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public Task<NzLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, NzLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public NzLeaveCategoryModel GetLeaveCategoryById(int businessId, int id)
        {
            return ApiRequest<NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public Task<NzLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public NzLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, NzLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public Task<NzLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, NzLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put, cancellationToken);
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
    }
}
