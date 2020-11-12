using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.EmployeeExpenseCategories;

namespace KeyPayV2.Au.Functions
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
            return ApiRequest<List<EmployeeExpenseCategoryModel>>($"/business/{businessId}/employeeexpensecategory{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Employee Expense Category
        /// </summary>
        /// <remarks>
        /// Creates an employee expense category for the business.
        /// </remarks>
        public void CreateEmployeeExpenseCategory(int businessId, EmployeeExpenseCategoryModel employeeExpenseCategory)
        {
            ApiRequest($"/business/{businessId}/employeeexpensecategory", employeeExpenseCategory, Method.POST);
        }

        /// <summary>
        /// Get Employee Expense Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee expense category with the specified ID.
        /// </remarks>
        public EmployeeExpenseCategoryModel GetEmployeeExpenseCategoryById(int businessId, int id)
        {
            return ApiRequest<EmployeeExpenseCategoryModel>($"/business/{businessId}/employeeexpensecategory/{id}");
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
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets a list of the business' tax codes.
        /// </remarks>
        public List<JournalServiceTaxCode> GetTaxCodes(int businessId)
        {
            return ApiRequest<List<JournalServiceTaxCode>>($"/business/{businessId}/employeeexpensecategory/taxcodes");
        }
    }
}
