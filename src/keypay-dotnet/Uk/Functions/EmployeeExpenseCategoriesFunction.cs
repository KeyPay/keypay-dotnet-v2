using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeeExpenseCategories;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeExpenseCategoriesFunction : BaseFunction
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
            return ApiRequest<List<EmployeeExpenseCategoryModel>>($"/business/{businessId}/employeeexpensecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
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
            return ApiRequestAsync<List<EmployeeExpenseCategoryModel>>($"/business/{businessId}/employeeexpensecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Creates an employee expense category for the business.
        /// </remarks>
        public EmployeeExpenseCategoryModel CreateEmployeeExpenseCategory(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory)
        {
            return ApiRequest<EmployeeExpenseCategoryModel,EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory", employeeExpenseCategory, Method.POST);
        }

        /// <summary>
        /// Create Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Creates an employee expense category for the business.
        /// </remarks>
        public Task<EmployeeExpenseCategoryModel> CreateEmployeeExpenseCategoryAsync(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeExpenseCategoryModel,EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory", employeeExpenseCategory, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expense Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee expense category with the specified ID.
        /// </remarks>
        public EmployeeExpenseCategoryModel GetEmployeeExpenseCategoryById(int businessId, int id)
        {
            return ApiRequest<EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Expense Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee expense category with the specified ID.
        /// </remarks>
        public Task<EmployeeExpenseCategoryModel> GetEmployeeExpenseCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Updates the employee expense category with the specified ID.
        /// </remarks>
        public void UpdateEmployeeExpenseCategory(int businessId, int id, EmployeeExpenseCategoryModel employeeExpenseCategory)
        {
            ApiRequest($"/business/{businessId}/employeeexpensecategory/{id}", employeeExpenseCategory, Method.PUT);
        }

        /// <summary>
        /// Update Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Updates the employee expense category with the specified ID.
        /// </remarks>
        public Task UpdateEmployeeExpenseCategoryAsync(int businessId, int id, EmployeeExpenseCategoryModel employeeExpenseCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeeexpensecategory/{id}", employeeExpenseCategory, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense category with the specified ID.
        /// </remarks>
        public void DeleteEmployeeExpenseCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employeeexpensecategory/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense category with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeExpenseCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeeexpensecategory/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets a list of the business' tax codes.
        /// </remarks>
        public List<JournalServiceTaxCode> GetTaxCodes(int businessId)
        {
            return ApiRequest<List<JournalServiceTaxCode>>($"/business/{businessId}/employeeexpensecategory/taxcodes", Method.GET);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets a list of the business' tax codes.
        /// </remarks>
        public Task<List<JournalServiceTaxCode>> GetTaxCodesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<JournalServiceTaxCode>>($"/business/{businessId}/employeeexpensecategory/taxcodes", Method.GET, cancellationToken);
        }
    }
}
