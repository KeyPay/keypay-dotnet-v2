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
using KeyPayV2.Au.Models.PayConditionComparison;

namespace KeyPayV2.Au.Functions
{
    public interface IPayConditionComparisonFunction
    {
        List<PayConditionComparisonApiModel> GetEmployeePayConditionComparisons(int businessId, int employeeId);
        Task<List<PayConditionComparisonApiModel>> GetEmployeePayConditionComparisonsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        PayConditionComparisonApiModel CreatePayConditionComparison(int businessId, int employeeId, CreatePayConditionComparisonRequest request);
        Task<PayConditionComparisonApiModel> CreatePayConditionComparisonAsync(int businessId, int employeeId, CreatePayConditionComparisonRequest request, CancellationToken cancellationToken = default);
        InitialServiceDateResponse GetInitialServiceDate(int businessId, int employeeId);
        Task<InitialServiceDateResponse> GetInitialServiceDateAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void UpdateInitialServiceDate(int businessId, int employeeId, UpdateServiceStartDateRequest request);
        Task UpdateInitialServiceDateAsync(int businessId, int employeeId, UpdateServiceStartDateRequest request, CancellationToken cancellationToken = default);
        void DeletePayConditionComparison(int businessId, int employeeId, int id);
        Task DeletePayConditionComparisonAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
    }
    public class PayConditionComparisonFunction : BaseFunction, IPayConditionComparisonFunction
    {
        public PayConditionComparisonFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Employee Pay Condition Comparisons
        /// </summary>
        /// <remarks>
        /// Gets all non-deleted pay condition comparisons for the specified employee.
        /// </remarks>
        public List<PayConditionComparisonApiModel> GetEmployeePayConditionComparisons(int businessId, int employeeId)
        {
            return ApiRequest<List<PayConditionComparisonApiModel>>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", Method.Get);
        }

        /// <summary>
        /// Get Employee Pay Condition Comparisons
        /// </summary>
        /// <remarks>
        /// Gets all non-deleted pay condition comparisons for the specified employee.
        /// </remarks>
        public Task<List<PayConditionComparisonApiModel>> GetEmployeePayConditionComparisonsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayConditionComparisonApiModel>>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition comparison for the specified employee.
        /// </remarks>
        public PayConditionComparisonApiModel CreatePayConditionComparison(int businessId, int employeeId, CreatePayConditionComparisonRequest request)
        {
            return ApiRequest<PayConditionComparisonApiModel,CreatePayConditionComparisonRequest>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition comparison for the specified employee.
        /// </remarks>
        public Task<PayConditionComparisonApiModel> CreatePayConditionComparisonAsync(int businessId, int employeeId, CreatePayConditionComparisonRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayConditionComparisonApiModel,CreatePayConditionComparisonRequest>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Initial Service Date
        /// </summary>
        /// <remarks>
        /// Gets the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public InitialServiceDateResponse GetInitialServiceDate(int businessId, int employeeId)
        {
            return ApiRequest<InitialServiceDateResponse>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", Method.Get);
        }

        /// <summary>
        /// Get Initial Service Date
        /// </summary>
        /// <remarks>
        /// Gets the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public Task<InitialServiceDateResponse> GetInitialServiceDateAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InitialServiceDateResponse>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Initial Service Date
        /// </summary>
        /// <remarks>
        /// Updates the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public void UpdateInitialServiceDate(int businessId, int employeeId, UpdateServiceStartDateRequest request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", request, Method.Post);
        }

        /// <summary>
        /// Update Initial Service Date
        /// </summary>
        /// <remarks>
        /// Updates the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public Task UpdateInitialServiceDateAsync(int businessId, int employeeId, UpdateServiceStartDateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Deletes the pay condition comparison with the specified ID for the specified employee.
        /// </remarks>
        public void DeletePayConditionComparison(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Deletes the pay condition comparison with the specified ID for the specified employee.
        /// </remarks>
        public Task DeletePayConditionComparisonAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/{id}", Method.Delete, cancellationToken);
        }
    }
}
