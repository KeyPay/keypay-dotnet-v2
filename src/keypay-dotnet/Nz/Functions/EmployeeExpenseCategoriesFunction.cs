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

namespace KeyPayV2.Nz.Functions
{
    public interface IEmployeeExpenseCategoriesFunction
    {
        List<EmployeeExpenseCategoryModel> ListEmployeeExpenseCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<EmployeeExpenseCategoryModel>> ListEmployeeExpenseCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        EmployeeExpenseCategoryModel CreateEmployeeExpenseCategory(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory);
        Task<EmployeeExpenseCategoryModel> CreateEmployeeExpenseCategoryAsync(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory, CancellationToken cancellationToken = default);
        EmployeeExpenseCategoryModel GetEmployeeExpenseCategoryById(int businessId, int id);
        Task<EmployeeExpenseCategoryModel> GetEmployeeExpenseCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateEmployeeExpenseCategory(int businessId, int id, EmployeeExpenseCategoryModel employeeExpenseCategory);
        Task UpdateEmployeeExpenseCategoryAsync(int businessId, int id, EmployeeExpenseCategoryModel employeeExpenseCategory, CancellationToken cancellationToken = default);
        void DeleteEmployeeExpenseCategory(int businessId, int id);
        Task DeleteEmployeeExpenseCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<JournalServiceTaxCode> GetTaxCodes(int businessId);
        Task<List<JournalServiceTaxCode>> GetTaxCodesAsync(int businessId, CancellationToken cancellationToken = default);
    }
    public class EmployeeExpenseCategoriesFunction : BaseFunction, IEmployeeExpenseCategoriesFunction
    {
        public EmployeeExpenseCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all the employee expense categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<EmployeeExpenseCategoryModel> ListEmployeeExpenseCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EmployeeExpenseCategoryModel>>($"/business/{businessId}/employeeexpensecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all the employee expense categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<EmployeeExpenseCategoryModel>> ListEmployeeExpenseCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeExpenseCategoryModel>>($"/business/{businessId}/employeeexpensecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Creates an employee expense category for the business.
        /// </remarks>
        public EmployeeExpenseCategoryModel CreateEmployeeExpenseCategory(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory)
        {
            return ApiRequest<EmployeeExpenseCategoryModel,EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory", employeeExpenseCategory, Method.Post);
        }

        /// <summary>
        /// Create Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Creates an employee expense category for the business.
        /// </remarks>
        public Task<EmployeeExpenseCategoryModel> CreateEmployeeExpenseCategoryAsync(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeExpenseCategoryModel,EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory", employeeExpenseCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expense Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee expense category with the specified ID.
        /// </remarks>
        public EmployeeExpenseCategoryModel GetEmployeeExpenseCategoryById(int businessId, int id)
        {
            return ApiRequest<EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Expense Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee expense category with the specified ID.
        /// </remarks>
        public Task<EmployeeExpenseCategoryModel> GetEmployeeExpenseCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Updates the employee expense category with the specified ID.
        /// </remarks>
        public void UpdateEmployeeExpenseCategory(int businessId, int id, EmployeeExpenseCategoryModel employeeExpenseCategory)
        {
            ApiRequest($"/business/{businessId}/employeeexpensecategory/{id}", employeeExpenseCategory, Method.Put);
        }

        /// <summary>
        /// Update Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Updates the employee expense category with the specified ID.
        /// </remarks>
        public Task UpdateEmployeeExpenseCategoryAsync(int businessId, int id, EmployeeExpenseCategoryModel employeeExpenseCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeeexpensecategory/{id}", employeeExpenseCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense category with the specified ID.
        /// </remarks>
        public void DeleteEmployeeExpenseCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employeeexpensecategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense category with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeExpenseCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeeexpensecategory/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets a list of the business' tax codes.
        /// </remarks>
        public List<JournalServiceTaxCode> GetTaxCodes(int businessId)
        {
            return ApiRequest<List<JournalServiceTaxCode>>($"/business/{businessId}/employeeexpensecategory/taxcodes", Method.Get);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets a list of the business' tax codes.
        /// </remarks>
        public Task<List<JournalServiceTaxCode>> GetTaxCodesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<JournalServiceTaxCode>>($"/business/{businessId}/employeeexpensecategory/taxcodes", Method.Get, cancellationToken);
        }
    }
}
