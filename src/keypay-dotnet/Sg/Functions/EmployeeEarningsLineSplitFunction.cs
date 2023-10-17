using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeEarningsLineSplit;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeEarningsLineSplitFunction
    {
        List<EarningsLineSplitApiModel> GetEmployeeLocationEarningsLineSplits(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<EarningsLineSplitApiModel>> GetEmployeeLocationEarningsLineSplitsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel earningsLineSplit);
        Task CreateEarningsLineSplitAsync(int businessId, int employeeId, EarningsLineSplitEditModel earningsLineSplit, CancellationToken cancellationToken = default);
        EarningsLineSplitApiModel GetEarningsLineSplitByLocationId(int businessId, int employeeId, int locationId);
        Task<EarningsLineSplitApiModel> GetEarningsLineSplitByLocationIdAsync(int businessId, int employeeId, int locationId, CancellationToken cancellationToken = default);
        void UpdateEarningsLineSplit(int businessId, int employeeId, int locationId, EarningsLineSplitEditModel earningsLineSplit);
        Task UpdateEarningsLineSplitAsync(int businessId, int employeeId, int locationId, EarningsLineSplitEditModel earningsLineSplit, CancellationToken cancellationToken = default);
        void DeleteEarningsLineSplit(int businessId, int employeeId, int locationId);
        Task DeleteEarningsLineSplitAsync(int businessId, int employeeId, int locationId, CancellationToken cancellationToken = default);
    }
    public class EmployeeEarningsLineSplitFunction : BaseFunction, IEmployeeEarningsLineSplitFunction
    {
        public EmployeeEarningsLineSplitFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Employee location earnings line splits
        /// </summary>
        /// <remarks>
        /// Lists all the location earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<EarningsLineSplitApiModel> GetEmployeeLocationEarningsLineSplits(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EarningsLineSplitApiModel>>($"/business/{businessId}/employee/{employeeId}/earningslinesplit{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Employee location earnings line splits
        /// </summary>
        /// <remarks>
        /// Lists all the location earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<EarningsLineSplitApiModel>> GetEmployeeLocationEarningsLineSplitsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EarningsLineSplitApiModel>>($"/business/{businessId}/employee/{employeeId}/earningslinesplit{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Earnings line split
        /// </summary>
        /// <remarks>
        /// Creates a new earnings line split for the employee.
        /// </remarks>
        public void CreateEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel earningsLineSplit)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit", earningsLineSplit, Method.Post);
        }

        /// <summary>
        /// Create Earnings line split
        /// </summary>
        /// <remarks>
        /// Creates a new earnings line split for the employee.
        /// </remarks>
        public Task CreateEarningsLineSplitAsync(int businessId, int employeeId, EarningsLineSplitEditModel earningsLineSplit, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit", earningsLineSplit, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Earnings line split by location ID
        /// </summary>
        /// <remarks>
        /// Gets the earnings line split for this employee with the specified location ID.
        /// </remarks>
        public EarningsLineSplitApiModel GetEarningsLineSplitByLocationId(int businessId, int employeeId, int locationId)
        {
            return ApiRequest<EarningsLineSplitApiModel>($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", Method.Get);
        }

        /// <summary>
        /// Get Earnings line split by location ID
        /// </summary>
        /// <remarks>
        /// Gets the earnings line split for this employee with the specified location ID.
        /// </remarks>
        public Task<EarningsLineSplitApiModel> GetEarningsLineSplitByLocationIdAsync(int businessId, int employeeId, int locationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EarningsLineSplitApiModel>($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Earnings line split
        /// </summary>
        /// <remarks>
        /// Updates the employee's earnings line split for the specified location ID.
        /// </remarks>
        public void UpdateEarningsLineSplit(int businessId, int employeeId, int locationId, EarningsLineSplitEditModel earningsLineSplit)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", earningsLineSplit, Method.Put);
        }

        /// <summary>
        /// Update Earnings line split
        /// </summary>
        /// <remarks>
        /// Updates the employee's earnings line split for the specified location ID.
        /// </remarks>
        public Task UpdateEarningsLineSplitAsync(int businessId, int employeeId, int locationId, EarningsLineSplitEditModel earningsLineSplit, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", earningsLineSplit, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Earnings line split
        /// </summary>
        /// <remarks>
        /// Deletes the employee's earnings line split with the specified location ID.
        /// </remarks>
        public void DeleteEarningsLineSplit(int businessId, int employeeId, int locationId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", Method.Delete);
        }

        /// <summary>
        /// Delete Earnings line split
        /// </summary>
        /// <remarks>
        /// Deletes the employee's earnings line split with the specified location ID.
        /// </remarks>
        public Task DeleteEarningsLineSplitAsync(int businessId, int employeeId, int locationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", Method.Delete, cancellationToken);
        }
    }
}
