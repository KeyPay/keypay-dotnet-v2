using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeeRecurringTransactions;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeRecurringTransactionsFunction : BaseFunction
    {
        public EmployeeRecurringTransactionsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public List<UkEmployeeRecurringDeductionModel> ListEmployeeDeductions(int businessId, int employeeId)
        {
            return ApiRequest<List<UkEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction");
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel CreateEmployeeDeduction(int businessId, int employeeId, UkEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel,UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.POST);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel GetEmployeeDeductionByExternalReferenceId(int businessId, int employeeId, string externalReferenceId)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}");
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel GetEmployeeDeductionById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}");
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel UpdateEmployeeDeduction(int businessId, int employeeId, int id, UkEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel,UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Employee Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring deduction with the specified ID.
        /// </remarks>
        public void DeleteEmployeeDeduction(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.DELETE);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public List<EmployerRecurringLiabilityModel> ListEmployerLiabilities(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability");
        }

        /// <summary>
        /// Create Employer liability
        /// </summary>
        /// <remarks>
        /// Creates a new recurring employer liability for the employee.
        /// </remarks>
        public EmployerRecurringLiabilityModel CreateEmployerLiability(int businessId, int employeeId, EmployerRecurringLiabilityModel model)
        {
            return ApiRequest<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability", model, Method.POST);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel GetEmployerLiabilityById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}");
        }

        /// <summary>
        /// Update Employer liability
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring employer liability with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel UpdateEmployerLiability(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model)
        {
            return ApiRequest<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Employer liability
        /// </summary>
        /// <remarks>
        /// Deletes the recurring employer liability with the specified ID.
        /// </remarks>
        public void DeleteEmployerLiability(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.DELETE);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public List<EmployeeRecurringExpenseModel> ListEmployeeExpenses(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense");
        }

        /// <summary>
        /// Create Employee Expense
        /// </summary>
        /// <remarks>
        /// Creates a new recurring expense for the employee.
        /// </remarks>
        public EmployeeRecurringExpenseModel CreateEmployeeExpense(int businessId, int employeeId, EmployeeRecurringExpenseModel model)
        {
            return ApiRequest<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense", model, Method.POST);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel GetEmployeeExpenseById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}");
        }

        /// <summary>
        /// Update Employee Expense
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel UpdateEmployeeExpense(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model)
        {
            return ApiRequest<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring expense with the specified ID.
        /// </remarks>
        public void DeleteEmployeeExpense(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.DELETE);
        }

        /// <summary>
        /// Create Or Update Employee HMRC Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a recurring HMRC adjustment for an employee
        /// </remarks>
        public EmployeeRecurringHmrcAdjustmentModel CreateOrUpdateEmployeeHmrcAdjustment(int businessId, int employeeId, EmployeeRecurringHmrcAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringHmrcAdjustmentModel,EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment", model, Method.POST);
        }

        /// <summary>
        /// Get Employee HMRC adjustment by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring HMRC adjustment with the specified external reference ID.
        /// </remarks>
        public EmployeeRecurringHmrcAdjustmentModel GetEmployeeHmrcAdjustmentByExternalReferenceId(int businessId, int employeeId, string externalReferenceId)
        {
            return ApiRequest<EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{externalReferenceId}");
        }

        /// <summary>
        /// Get Hmrc Adjustment By Id
        /// </summary>
        /// <remarks>
        /// Gets a HMRC adjustment by a specific ID
        /// </remarks>
        public EmployeeRecurringHmrcAdjustmentModel GetHmrcAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{id}");
        }

        /// <summary>
        /// Delete Employee Hmrc Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee HMRC adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeHmrcAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{id}", Method.DELETE);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringTaxAdjustmentModel> ListEmployeeTaxAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment");
        }

        /// <summary>
        /// Create Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel CreateEmployeeTaxAdjustment(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment", model, Method.POST);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel GetEmployeeTaxAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}");
        }

        /// <summary>
        /// Update Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel UpdateEmployeeTaxAdjustment(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeTaxAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.DELETE);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public List<UkEmployeeRecurringDeductionModel> ListEmployeeDeductionsByExternalReferenceId(int businessId, IList<String> externalReferenceIds)
        {
            return ApiRequest<List<UkEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.POST);
        }
    }
}
