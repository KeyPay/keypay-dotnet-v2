using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.EmployeeRecurringTransactions;

namespace KeyPayV2.Au.Functions
{
    public interface IEmployeeRecurringTransactionsFunction
    {
        List<AdditionalEarningsModel> ListEmployeeAdditionalEarnings(int businessId, int employeeId);
        Task<List<AdditionalEarningsModel>> ListEmployeeAdditionalEarningsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        AdditionalEarningsModel CreateEmployeeAdditionalEarning(int businessId, int employeeId, AdditionalEarningsInputModel model);
        Task<AdditionalEarningsModel> CreateEmployeeAdditionalEarningAsync(int businessId, int employeeId, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default);
        AdditionalEarningsModel GetEmployeeAdditionalEarningById(int businessId, int employeeId, long id);
        Task<AdditionalEarningsModel> GetEmployeeAdditionalEarningByIdAsync(int businessId, int employeeId, long id, CancellationToken cancellationToken = default);
        AdditionalEarningsModel UpdateEmployeeAdditionalEarning(int businessId, int employeeId, long id, AdditionalEarningsInputModel model);
        Task<AdditionalEarningsModel> UpdateEmployeeAdditionalEarningAsync(int businessId, int employeeId, long id, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default);
        void DeleteEmployeeAdditionalEarning(int businessId, int employeeId, long id);
        Task DeleteEmployeeAdditionalEarningAsync(int businessId, int employeeId, long id, CancellationToken cancellationToken = default);
        List<AuEmployeeRecurringDeductionModel> ListEmployeeDeductions(int businessId, int employeeId);
        Task<List<AuEmployeeRecurringDeductionModel>> ListEmployeeDeductionsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        AuEmployeeRecurringDeductionModel CreateEmployeeDeduction(int businessId, int employeeId, AuEmployeeRecurringDeductionModel model);
        Task<AuEmployeeRecurringDeductionModel> CreateEmployeeDeductionAsync(int businessId, int employeeId, AuEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default);
        AuEmployeeRecurringDeductionModel GetEmployeeDeductionByExternalReferenceId(int businessId, int employeeId, string externalReferenceId);
        Task<AuEmployeeRecurringDeductionModel> GetEmployeeDeductionByExternalReferenceIdAsync(int businessId, int employeeId, string externalReferenceId, CancellationToken cancellationToken = default);
        AuEmployeeRecurringDeductionModel GetEmployeeDeductionById(int businessId, int employeeId, int id);
        Task<AuEmployeeRecurringDeductionModel> GetEmployeeDeductionByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        AuEmployeeRecurringDeductionModel UpdateEmployeeDeduction(int businessId, int employeeId, int id, AuEmployeeRecurringDeductionModel model);
        Task<AuEmployeeRecurringDeductionModel> UpdateEmployeeDeductionAsync(int businessId, int employeeId, int id, AuEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default);
        void DeleteEmployeeDeduction(int businessId, int employeeId, int id);
        Task DeleteEmployeeDeductionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployerRecurringLiabilityModel> ListEmployerLiabilities(int businessId, int employeeId);
        Task<List<EmployerRecurringLiabilityModel>> ListEmployerLiabilitiesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployerRecurringLiabilityModel CreateEmployerLiability(int businessId, int employeeId, EmployerRecurringLiabilityModel model);
        Task<EmployerRecurringLiabilityModel> CreateEmployerLiabilityAsync(int businessId, int employeeId, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default);
        EmployerRecurringLiabilityModel GetEmployerLiabilityById(int businessId, int employeeId, int id);
        Task<EmployerRecurringLiabilityModel> GetEmployerLiabilityByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployerRecurringLiabilityModel UpdateEmployerLiability(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model);
        Task<EmployerRecurringLiabilityModel> UpdateEmployerLiabilityAsync(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default);
        void DeleteEmployerLiability(int businessId, int employeeId, int id);
        Task DeleteEmployerLiabilityAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeRecurringExpenseModel> ListEmployeeExpenses(int businessId, int employeeId);
        Task<List<EmployeeRecurringExpenseModel>> ListEmployeeExpensesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeRecurringExpenseModel CreateEmployeeExpense(int businessId, int employeeId, EmployeeRecurringExpenseModel model);
        Task<EmployeeRecurringExpenseModel> CreateEmployeeExpenseAsync(int businessId, int employeeId, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default);
        EmployeeRecurringExpenseModel GetEmployeeExpenseById(int businessId, int employeeId, int id);
        Task<EmployeeRecurringExpenseModel> GetEmployeeExpenseByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeRecurringExpenseModel UpdateEmployeeExpense(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model);
        Task<EmployeeRecurringExpenseModel> UpdateEmployeeExpenseAsync(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default);
        void DeleteEmployeeExpense(int businessId, int employeeId, int id);
        Task DeleteEmployeeExpenseAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeRecurringSuperAdjustmentModel> ListEmployeeSuperAdjustments(int businessId, int employeeId);
        Task<List<EmployeeRecurringSuperAdjustmentModel>> ListEmployeeSuperAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeRecurringSuperAdjustmentModel CreateEmployeeSuperAdjustment(int businessId, int employeeId, EmployeeRecurringSuperAdjustmentModel model);
        Task<EmployeeRecurringSuperAdjustmentModel> CreateEmployeeSuperAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringSuperAdjustmentModel model, CancellationToken cancellationToken = default);
        EmployeeRecurringSuperAdjustmentModel GetEmployeeSuperAdjustmentById(int businessId, int employeeId, int id);
        Task<EmployeeRecurringSuperAdjustmentModel> GetEmployeeSuperAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeRecurringSuperAdjustmentModel UpdateEmployeeSuperAdjustment(int businessId, int employeeId, int id, EmployeeRecurringSuperAdjustmentModel model);
        Task<EmployeeRecurringSuperAdjustmentModel> UpdateEmployeeSuperAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringSuperAdjustmentModel model, CancellationToken cancellationToken = default);
        void DeleteEmployeeSuperAdjustment(int businessId, int employeeId, int id);
        Task DeleteEmployeeSuperAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeRecurringTaxAdjustmentModel> ListEmployeeTaxAdjustments(int businessId, int employeeId);
        Task<List<EmployeeRecurringTaxAdjustmentModel>> ListEmployeeTaxAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeRecurringTaxAdjustmentModel CreateEmployeeTaxAdjustment(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model);
        Task<EmployeeRecurringTaxAdjustmentModel> CreateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default);
        EmployeeRecurringTaxAdjustmentModel GetEmployeeTaxAdjustmentById(int businessId, int employeeId, int id);
        Task<EmployeeRecurringTaxAdjustmentModel> GetEmployeeTaxAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeRecurringTaxAdjustmentModel UpdateEmployeeTaxAdjustment(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model);
        Task<EmployeeRecurringTaxAdjustmentModel> UpdateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default);
        void DeleteEmployeeTaxAdjustment(int businessId, int employeeId, int id);
        Task DeleteEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<AuEmployeeRecurringDeductionModel> ListEmployeeDeductionsByExternalReferenceId(int businessId, IList<String> externalReferenceIds);
        Task<List<AuEmployeeRecurringDeductionModel>> ListEmployeeDeductionsByExternalReferenceIdAsync(int businessId, IList<String> externalReferenceIds, CancellationToken cancellationToken = default);
    }
    public class EmployeeRecurringTransactionsFunction : BaseFunction, IEmployeeRecurringTransactionsFunction
    {
        public EmployeeRecurringTransactionsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Additional Earnings
        /// </summary>
        /// <remarks>
        /// Lists all the additional earnings for the employee
        /// </remarks>
        public List<AdditionalEarningsModel> ListEmployeeAdditionalEarnings(int businessId, int employeeId)
        {
            return ApiRequest<List<AdditionalEarningsModel>>($"/business/{businessId}/employee/{employeeId}/additional-earnings", Method.Get);
        }

        /// <summary>
        /// List Employee Additional Earnings
        /// </summary>
        /// <remarks>
        /// Lists all the additional earnings for the employee
        /// </remarks>
        public Task<List<AdditionalEarningsModel>> ListEmployeeAdditionalEarningsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AdditionalEarningsModel>>($"/business/{businessId}/employee/{employeeId}/additional-earnings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Creates a new additional earning for the employee.
        /// </remarks>
        public AdditionalEarningsModel CreateEmployeeAdditionalEarning(int businessId, int employeeId, AdditionalEarningsInputModel model)
        {
            return ApiRequest<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Creates a new additional earning for the employee.
        /// </remarks>
        public Task<AdditionalEarningsModel> CreateEmployeeAdditionalEarningAsync(int businessId, int employeeId, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Additional Earning by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's additional earning with the specified ID.
        /// </remarks>
        public AdditionalEarningsModel GetEmployeeAdditionalEarningById(int businessId, int employeeId, long id)
        {
            return ApiRequest<AdditionalEarningsModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Additional Earning by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's additional earning with the specified ID.
        /// </remarks>
        public Task<AdditionalEarningsModel> GetEmployeeAdditionalEarningByIdAsync(int businessId, int employeeId, long id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Updates the employee's additional earning with the specified ID.
        /// </remarks>
        public AdditionalEarningsModel UpdateEmployeeAdditionalEarning(int businessId, int employeeId, long id, AdditionalEarningsInputModel model)
        {
            return ApiRequest<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Updates the employee's additional earning with the specified ID.
        /// </remarks>
        public Task<AdditionalEarningsModel> UpdateEmployeeAdditionalEarningAsync(int businessId, int employeeId, long id, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Deletes the employee's additional earning with the specified ID.
        /// </remarks>
        public void DeleteEmployeeAdditionalEarning(int businessId, int employeeId, long id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Deletes the employee's additional earning with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeAdditionalEarningAsync(int businessId, int employeeId, long id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public List<AuEmployeeRecurringDeductionModel> ListEmployeeDeductions(int businessId, int employeeId)
        {
            return ApiRequest<List<AuEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction", Method.Get);
        }

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public Task<List<AuEmployeeRecurringDeductionModel>> ListEmployeeDeductionsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public AuEmployeeRecurringDeductionModel CreateEmployeeDeduction(int businessId, int employeeId, AuEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<AuEmployeeRecurringDeductionModel,AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public Task<AuEmployeeRecurringDeductionModel> CreateEmployeeDeductionAsync(int businessId, int employeeId, AuEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployeeRecurringDeductionModel,AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public AuEmployeeRecurringDeductionModel GetEmployeeDeductionByExternalReferenceId(int businessId, int employeeId, string externalReferenceId)
        {
            return ApiRequest<AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}", Method.Get);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public Task<AuEmployeeRecurringDeductionModel> GetEmployeeDeductionByExternalReferenceIdAsync(int businessId, int employeeId, string externalReferenceId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public AuEmployeeRecurringDeductionModel GetEmployeeDeductionById(int businessId, int employeeId, int id)
        {
            return ApiRequest<AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public Task<AuEmployeeRecurringDeductionModel> GetEmployeeDeductionByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public AuEmployeeRecurringDeductionModel UpdateEmployeeDeduction(int businessId, int employeeId, int id, AuEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<AuEmployeeRecurringDeductionModel,AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public Task<AuEmployeeRecurringDeductionModel> UpdateEmployeeDeductionAsync(int businessId, int employeeId, int id, AuEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployeeRecurringDeductionModel,AuEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring deduction with the specified ID.
        /// </remarks>
        public void DeleteEmployeeDeduction(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring deduction with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeDeductionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public List<EmployerRecurringLiabilityModel> ListEmployerLiabilities(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability", Method.Get);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public Task<List<EmployerRecurringLiabilityModel>> ListEmployerLiabilitiesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employer liability
        /// </summary>
        /// <remarks>
        /// Creates a new recurring employer liability for the employee.
        /// </remarks>
        public EmployerRecurringLiabilityModel CreateEmployerLiability(int businessId, int employeeId, EmployerRecurringLiabilityModel model)
        {
            return ApiRequest<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability", model, Method.Post);
        }

        /// <summary>
        /// Create Employer liability
        /// </summary>
        /// <remarks>
        /// Creates a new recurring employer liability for the employee.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> CreateEmployerLiabilityAsync(int businessId, int employeeId, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel GetEmployerLiabilityById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> GetEmployerLiabilityByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employer liability
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring employer liability with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel UpdateEmployerLiability(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model)
        {
            return ApiRequest<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employer liability
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring employer liability with the specified ID.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> UpdateEmployerLiabilityAsync(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employer liability
        /// </summary>
        /// <remarks>
        /// Deletes the recurring employer liability with the specified ID.
        /// </remarks>
        public void DeleteEmployerLiability(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employer liability
        /// </summary>
        /// <remarks>
        /// Deletes the recurring employer liability with the specified ID.
        /// </remarks>
        public Task DeleteEmployerLiabilityAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public List<EmployeeRecurringExpenseModel> ListEmployeeExpenses(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense", Method.Get);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringExpenseModel>> ListEmployeeExpensesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Expense
        /// </summary>
        /// <remarks>
        /// Creates a new recurring expense for the employee.
        /// </remarks>
        public EmployeeRecurringExpenseModel CreateEmployeeExpense(int businessId, int employeeId, EmployeeRecurringExpenseModel model)
        {
            return ApiRequest<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Expense
        /// </summary>
        /// <remarks>
        /// Creates a new recurring expense for the employee.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> CreateEmployeeExpenseAsync(int businessId, int employeeId, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel GetEmployeeExpenseById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> GetEmployeeExpenseByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Expense
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel UpdateEmployeeExpense(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model)
        {
            return ApiRequest<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Expense
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring expense with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> UpdateEmployeeExpenseAsync(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring expense with the specified ID.
        /// </remarks>
        public void DeleteEmployeeExpense(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring expense with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeExpenseAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Super Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee super adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringSuperAdjustmentModel> ListEmployeeSuperAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringSuperAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/superadjustment", Method.Get);
        }

        /// <summary>
        /// List Employee Super Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee super adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringSuperAdjustmentModel>> ListEmployeeSuperAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringSuperAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/superadjustment", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Super Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring super adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringSuperAdjustmentModel CreateEmployeeSuperAdjustment(int businessId, int employeeId, EmployeeRecurringSuperAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringSuperAdjustmentModel,EmployeeRecurringSuperAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/superadjustment", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Super Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring super adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringSuperAdjustmentModel> CreateEmployeeSuperAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringSuperAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringSuperAdjustmentModel,EmployeeRecurringSuperAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/superadjustment", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Super Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring super adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringSuperAdjustmentModel GetEmployeeSuperAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringSuperAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/superadjustment/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Super Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring super adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringSuperAdjustmentModel> GetEmployeeSuperAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringSuperAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/superadjustment/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Super Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring super adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringSuperAdjustmentModel UpdateEmployeeSuperAdjustment(int businessId, int employeeId, int id, EmployeeRecurringSuperAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringSuperAdjustmentModel,EmployeeRecurringSuperAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/superadjustment/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Super Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring super adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringSuperAdjustmentModel> UpdateEmployeeSuperAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringSuperAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringSuperAdjustmentModel,EmployeeRecurringSuperAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/superadjustment/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Super Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring super adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeSuperAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/superadjustment/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Super Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring super adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeSuperAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/superadjustment/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringTaxAdjustmentModel> ListEmployeeTaxAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment", Method.Get);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringTaxAdjustmentModel>> ListEmployeeTaxAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel CreateEmployeeTaxAdjustment(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> CreateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel GetEmployeeTaxAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> GetEmployeeTaxAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel UpdateEmployeeTaxAdjustment(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> UpdateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeTaxAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public List<AuEmployeeRecurringDeductionModel> ListEmployeeDeductionsByExternalReferenceId(int businessId, IList<String> externalReferenceIds)
        {
            return ApiRequest<List<AuEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.Post);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public Task<List<AuEmployeeRecurringDeductionModel>> ListEmployeeDeductionsByExternalReferenceIdAsync(int businessId, IList<String> externalReferenceIds, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.Post, cancellationToken);
        }
    }
}
