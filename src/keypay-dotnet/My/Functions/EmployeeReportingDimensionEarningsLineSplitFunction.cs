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
using KeyPayV2.My.Models.EmployeeReportingDimensionEarningsLineSplit;

namespace KeyPayV2.My.Functions
{
    public interface IEmployeeReportingDimensionEarningsLineSplitFunction
    {
        List<DimensionEarningsLineSplitApiModel> GetEmployeeDimensionEarningsLineSplits(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<DimensionEarningsLineSplitApiModel>> GetEmployeeDimensionEarningsLineSplitsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void UpdateDimensionEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel model);
        Task UpdateDimensionEarningsLineSplitAsync(int businessId, int employeeId, EarningsLineSplitEditModel model, CancellationToken cancellationToken = default);
        void CreateDimensionEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel model);
        Task CreateDimensionEarningsLineSplitAsync(int businessId, int employeeId, EarningsLineSplitEditModel model, CancellationToken cancellationToken = default);
        void GetEmployeeDimensionEarningsLineSplitById(int businessId, int employeeId, int dimensionId, int dimensionValueId, ODataQuery oDataQuery = null);
        Task GetEmployeeDimensionEarningsLineSplitByIdAsync(int businessId, int employeeId, int dimensionId, int dimensionValueId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void DeleteDimensionEarningsLineSplit(int businessId, int employeeId, int dimensionId, int dimensionValueId);
        Task DeleteDimensionEarningsLineSplitAsync(int businessId, int employeeId, int dimensionId, int dimensionValueId, CancellationToken cancellationToken = default);
    }
    public class EmployeeReportingDimensionEarningsLineSplitFunction : BaseFunction, IEmployeeReportingDimensionEarningsLineSplitFunction
    {
        public EmployeeReportingDimensionEarningsLineSplitFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Employee Dimension Earnings Line Splits
        /// </summary>
        /// <remarks>
        /// Lists all the dimension earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<DimensionEarningsLineSplitApiModel> GetEmployeeDimensionEarningsLineSplits(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<DimensionEarningsLineSplitApiModel>>($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Employee Dimension Earnings Line Splits
        /// </summary>
        /// <remarks>
        /// Lists all the dimension earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<DimensionEarningsLineSplitApiModel>> GetEmployeeDimensionEarningsLineSplitsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DimensionEarningsLineSplitApiModel>>($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Dimension Earnings Line Split
        /// </summary>
        /// <remarks>
        /// Updates a dimension earnings line split by matching against existing reporting dimension values
        /// </remarks>
        public void UpdateDimensionEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension", model, Method.Put);
        }

        /// <summary>
        /// Update Dimension Earnings Line Split
        /// </summary>
        /// <remarks>
        /// Updates a dimension earnings line split by matching against existing reporting dimension values
        /// </remarks>
        public Task UpdateDimensionEarningsLineSplitAsync(int businessId, int employeeId, EarningsLineSplitEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create Dimension Earnings Line Split
        /// </summary>
        /// <remarks>
        /// Creates a dimension earnings line split for a specific employee
        /// </remarks>
        public void CreateDimensionEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension", model, Method.Post);
        }

        /// <summary>
        /// Create Dimension Earnings Line Split
        /// </summary>
        /// <remarks>
        /// Creates a dimension earnings line split for a specific employee
        /// </remarks>
        public Task CreateDimensionEarningsLineSplitAsync(int businessId, int employeeId, EarningsLineSplitEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Dimension Earnings Line Split By Id
        /// </summary>
        /// <remarks>
        /// Lists all the dimension earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public void GetEmployeeDimensionEarningsLineSplitById(int businessId, int employeeId, int dimensionId, int dimensionValueId, ODataQuery oDataQuery = null)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension/{dimensionId}/value/{dimensionValueId}", Method.Get);
        }

        /// <summary>
        /// Get Employee Dimension Earnings Line Split By Id
        /// </summary>
        /// <remarks>
        /// Lists all the dimension earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task GetEmployeeDimensionEarningsLineSplitByIdAsync(int businessId, int employeeId, int dimensionId, int dimensionValueId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension/{dimensionId}/value/{dimensionValueId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Dimension Earnings Line Split
        /// </summary>
        /// <remarks>
        /// Deletes the employee's earnings line split with the specified reporting dimension ID
        /// </remarks>
        public void DeleteDimensionEarningsLineSplit(int businessId, int employeeId, int dimensionId, int dimensionValueId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension/{dimensionId}/value/{dimensionValueId}", Method.Delete);
        }

        /// <summary>
        /// Delete Dimension Earnings Line Split
        /// </summary>
        /// <remarks>
        /// Deletes the employee's earnings line split with the specified reporting dimension ID
        /// </remarks>
        public Task DeleteDimensionEarningsLineSplitAsync(int businessId, int employeeId, int dimensionId, int dimensionValueId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit/dimension/{dimensionId}/value/{dimensionValueId}", Method.Delete, cancellationToken);
        }
    }
}
