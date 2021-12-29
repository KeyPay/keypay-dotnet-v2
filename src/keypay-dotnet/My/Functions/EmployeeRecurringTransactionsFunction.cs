using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.EmployeeRecurringTransactions;

namespace KeyPayV2.My.Functions
{
    public class EmployeeRecurringTransactionsFunction : BaseFunction
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
            return ApiRequest<List<AdditionalEarningsModel>>($"/business/{businessId}/employee/{employeeId}/additional-earnings", Method.GET);
        }

        /// <summary>
        /// List Employee Additional Earnings
        /// </summary>
        /// <remarks>
        /// Lists all the additional earnings for the employee
        /// </remarks>
        public Task<List<AdditionalEarningsModel>> ListEmployeeAdditionalEarningsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AdditionalEarningsModel>>($"/business/{businessId}/employee/{employeeId}/additional-earnings", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Creates a new additional earning for the employee.
        /// </remarks>
        public AdditionalEarningsModel CreateEmployeeAdditionalEarning(int businessId, int employeeId, AdditionalEarningsInputModel model)
        {
            return ApiRequest<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings", model, Method.POST);
        }

        /// <summary>
        /// Create Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Creates a new additional earning for the employee.
        /// </remarks>
        public Task<AdditionalEarningsModel> CreateEmployeeAdditionalEarningAsync(int businessId, int employeeId, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Additional Earning by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's additional earning with the specified ID.
        /// </remarks>
        public AdditionalEarningsModel GetEmployeeAdditionalEarningById(int businessId, int employeeId, int id)
        {
            return ApiRequest<AdditionalEarningsModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Additional Earning by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's additional earning with the specified ID.
        /// </remarks>
        public Task<AdditionalEarningsModel> GetEmployeeAdditionalEarningByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Updates the employee's additional earning with the specified ID.
        /// </remarks>
        public AdditionalEarningsModel UpdateEmployeeAdditionalEarning(int businessId, int employeeId, int id, AdditionalEarningsInputModel model)
        {
            return ApiRequest<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Updates the employee's additional earning with the specified ID.
        /// </remarks>
        public Task<AdditionalEarningsModel> UpdateEmployeeAdditionalEarningAsync(int businessId, int employeeId, int id, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Deletes the employee's additional earning with the specified ID.
        /// </remarks>
        public void DeleteEmployeeAdditionalEarning(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Deletes the employee's additional earning with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeAdditionalEarningAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Benefits In Kind Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee benefits in kind adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringBenefitsInKindAdjustmentModel> ListEmployeeBenefitsInKindAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringBenefitsInKindAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment", Method.GET);
        }

        /// <summary>
        /// List Employee Benefits In Kind Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee benefits in kind adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringBenefitsInKindAdjustmentModel>> ListEmployeeBenefitsInKindAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringBenefitsInKindAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Benefits In Kind Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring benefits in kind adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringBenefitsInKindAdjustmentModel CreateEmployeeBenefitsInKindAdjustment(int businessId, int employeeId, EmployeeRecurringBenefitsInKindAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringBenefitsInKindAdjustmentModel,EmployeeRecurringBenefitsInKindAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment", model, Method.POST);
        }

        /// <summary>
        /// Create Employee Benefits In Kind Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring benefits in kind adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringBenefitsInKindAdjustmentModel> CreateEmployeeBenefitsInKindAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringBenefitsInKindAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringBenefitsInKindAdjustmentModel,EmployeeRecurringBenefitsInKindAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Benefits In Kind Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring benefits in kind adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringBenefitsInKindAdjustmentModel GetEmployeeBenefitsInKindAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringBenefitsInKindAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Benefits In Kind Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring benefits in kind adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringBenefitsInKindAdjustmentModel> GetEmployeeBenefitsInKindAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringBenefitsInKindAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Benefits In Kind Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring benefits in kind adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringBenefitsInKindAdjustmentModel UpdateEmployeeBenefitsInKindAdjustment(int businessId, int employeeId, int id, EmployeeRecurringBenefitsInKindAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringBenefitsInKindAdjustmentModel,EmployeeRecurringBenefitsInKindAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Employee Benefits In Kind Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring benefits in kind adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringBenefitsInKindAdjustmentModel> UpdateEmployeeBenefitsInKindAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringBenefitsInKindAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringBenefitsInKindAdjustmentModel,EmployeeRecurringBenefitsInKindAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment/{id}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Benefits In Kind Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee's recurring benefits in kind adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeBenefitsInKindAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Benefits In Kind Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee's recurring benefits in kind adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeBenefitsInKindAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/benefitsinkindadjustment/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public List<MyEmployeeRecurringDeductionModel> ListEmployeeDeductions(int businessId, int employeeId)
        {
            return ApiRequest<List<MyEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction", Method.GET);
        }

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public Task<List<MyEmployeeRecurringDeductionModel>> ListEmployeeDeductionsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public MyEmployeeRecurringDeductionModel CreateEmployeeDeduction(int businessId, int employeeId, MyEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<MyEmployeeRecurringDeductionModel,MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.POST);
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public Task<MyEmployeeRecurringDeductionModel> CreateEmployeeDeductionAsync(int businessId, int employeeId, MyEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeeRecurringDeductionModel,MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public MyEmployeeRecurringDeductionModel GetEmployeeDeductionByExternalReferenceId(int businessId, int employeeId, string externalReferenceId)
        {
            return ApiRequest<MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}", Method.GET);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public Task<MyEmployeeRecurringDeductionModel> GetEmployeeDeductionByExternalReferenceIdAsync(int businessId, int employeeId, string externalReferenceId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public MyEmployeeRecurringDeductionModel GetEmployeeDeductionById(int businessId, int employeeId, int id)
        {
            return ApiRequest<MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public Task<MyEmployeeRecurringDeductionModel> GetEmployeeDeductionByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public MyEmployeeRecurringDeductionModel UpdateEmployeeDeduction(int businessId, int employeeId, int id, MyEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<MyEmployeeRecurringDeductionModel,MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public Task<MyEmployeeRecurringDeductionModel> UpdateEmployeeDeductionAsync(int businessId, int employeeId, int id, MyEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeeRecurringDeductionModel,MyEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.PUT, cancellationToken);
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
        /// Delete Employee Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring deduction with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeDeductionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public List<EmployerRecurringLiabilityModel> ListEmployerLiabilities(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability", Method.GET);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public Task<List<EmployerRecurringLiabilityModel>> ListEmployerLiabilitiesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability", Method.GET, cancellationToken);
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
        /// Create Employer liability
        /// </summary>
        /// <remarks>
        /// Creates a new recurring employer liability for the employee.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> CreateEmployerLiabilityAsync(int businessId, int employeeId, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel GetEmployerLiabilityById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> GetEmployerLiabilityByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.GET, cancellationToken);
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
        /// Update Employer liability
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring employer liability with the specified ID.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> UpdateEmployerLiabilityAsync(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", model, Method.PUT, cancellationToken);
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
        /// Delete Employer liability
        /// </summary>
        /// <remarks>
        /// Deletes the recurring employer liability with the specified ID.
        /// </remarks>
        public Task DeleteEmployerLiabilityAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public List<EmployeeRecurringExpenseModel> ListEmployeeExpenses(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense", Method.GET);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringExpenseModel>> ListEmployeeExpensesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense", Method.GET, cancellationToken);
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
        /// Create Employee Expense
        /// </summary>
        /// <remarks>
        /// Creates a new recurring expense for the employee.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> CreateEmployeeExpenseAsync(int businessId, int employeeId, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel GetEmployeeExpenseById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> GetEmployeeExpenseByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.GET, cancellationToken);
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
        /// Update Employee Expense
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring expense with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> UpdateEmployeeExpenseAsync(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", model, Method.PUT, cancellationToken);
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
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring expense with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeExpenseAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Statutory Contribution Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee statutory contribution adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringStatutoryContributionAdjustmentModel> ListEmployeeStatutoryContributionAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringStatutoryContributionAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment", Method.GET);
        }

        /// <summary>
        /// List Employee Statutory Contribution Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee statutory contribution adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringStatutoryContributionAdjustmentModel>> ListEmployeeStatutoryContributionAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringStatutoryContributionAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Statutory Contribution Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring statutory contribution adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringStatutoryContributionAdjustmentModel CreateEmployeeStatutoryContributionAdjustment(int businessId, int employeeId, EmployeeRecurringStatutoryContributionAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringStatutoryContributionAdjustmentModel,EmployeeRecurringStatutoryContributionAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment", model, Method.POST);
        }

        /// <summary>
        /// Create Employee Statutory Contribution Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring statutory contribution adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringStatutoryContributionAdjustmentModel> CreateEmployeeStatutoryContributionAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringStatutoryContributionAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringStatutoryContributionAdjustmentModel,EmployeeRecurringStatutoryContributionAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Statutory Contribution Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring statutory contribution adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringStatutoryContributionAdjustmentModel GetEmployeeStatutoryContributionAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringStatutoryContributionAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Statutory Contribution Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring statutory contribution adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringStatutoryContributionAdjustmentModel> GetEmployeeStatutoryContributionAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringStatutoryContributionAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Statutory Contribution Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring statutory contribution adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringStatutoryContributionAdjustmentModel UpdateEmployeeStatutoryContributionAdjustment(int businessId, int employeeId, int id, EmployeeRecurringStatutoryContributionAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringStatutoryContributionAdjustmentModel,EmployeeRecurringStatutoryContributionAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Employee Statutory Contribution Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring statutory contribution adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringStatutoryContributionAdjustmentModel> UpdateEmployeeStatutoryContributionAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringStatutoryContributionAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringStatutoryContributionAdjustmentModel,EmployeeRecurringStatutoryContributionAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment/{id}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Statutory Contribution Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring statutory contribution adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeStatutoryContributionAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Statutory Contribution Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring statutory contribution adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeStatutoryContributionAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutorycontributionadjustment/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringTaxAdjustmentModel> ListEmployeeTaxAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment", Method.GET);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringTaxAdjustmentModel>> ListEmployeeTaxAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment", Method.GET, cancellationToken);
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
        /// Create Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> CreateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel GetEmployeeTaxAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> GetEmployeeTaxAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.GET, cancellationToken);
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
        /// Update Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> UpdateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", model, Method.PUT, cancellationToken);
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
        /// Delete Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Tax Relief Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax relief adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringTaxReliefAdjustmentModel> ListEmployeeTaxReliefAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringTaxReliefAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment", Method.GET);
        }

        /// <summary>
        /// List Employee Tax Relief Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax relief adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringTaxReliefAdjustmentModel>> ListEmployeeTaxReliefAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringTaxReliefAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Tax Relief Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax relief adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringTaxReliefAdjustmentModel CreateEmployeeTaxReliefAdjustment(int businessId, int employeeId, EmployeeRecurringTaxReliefAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxReliefAdjustmentModel,EmployeeRecurringTaxReliefAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment", model, Method.POST);
        }

        /// <summary>
        /// Create Employee Tax Relief Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax relief adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringTaxReliefAdjustmentModel> CreateEmployeeTaxReliefAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringTaxReliefAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxReliefAdjustmentModel,EmployeeRecurringTaxReliefAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Tax Relief Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax relief adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxReliefAdjustmentModel GetEmployeeTaxReliefAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringTaxReliefAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Tax Relief Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax relief adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxReliefAdjustmentModel> GetEmployeeTaxReliefAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxReliefAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Tax Relief Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax relief adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxReliefAdjustmentModel UpdateEmployeeTaxReliefAdjustment(int businessId, int employeeId, int id, EmployeeRecurringTaxReliefAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxReliefAdjustmentModel,EmployeeRecurringTaxReliefAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Employee Tax Relief Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax relief adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxReliefAdjustmentModel> UpdateEmployeeTaxReliefAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringTaxReliefAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxReliefAdjustmentModel,EmployeeRecurringTaxReliefAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment/{id}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Tax Relief Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax relief adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeTaxReliefAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Tax Relief Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax relief adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeTaxReliefAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/taxreliefadjustment/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public List<MyEmployeeRecurringDeductionModel> ListEmployeeDeductionsByExternalReferenceId(int businessId, IList<String> externalReferenceIds)
        {
            return ApiRequest<List<MyEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.POST);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public Task<List<MyEmployeeRecurringDeductionModel>> ListEmployeeDeductionsByExternalReferenceIdAsync(int businessId, IList<String> externalReferenceIds, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.POST, cancellationToken);
        }
    }
}
