using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeEarningsLineSplit;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeEarningsLineSplitFunction : BaseFunction
    {
        public EmployeeEarningsLineSplitFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Employee earnings line splits
        /// </summary>
        /// <remarks>
        /// Lists all the earnings line splits for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<EarningsLineSplitApiModel> GetEmployeeEarningsLineSplits(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EarningsLineSplitApiModel>>($"/business/{businessId}/employee/{employeeId}/earningslinesplit{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Earnings line split
        /// </summary>
        /// <remarks>
        /// Creates a new earnings line split for the employee.
        /// </remarks>
        public void CreateEarningsLineSplit(int businessId, int employeeId, EarningsLineSplitEditModel earningsLineSplit)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit", earningsLineSplit, Method.POST);
        }

        /// <summary>
        /// Get Earnings line split by location ID
        /// </summary>
        /// <remarks>
        /// Gets the earnings line split for this employee with the specified location ID.
        /// </remarks>
        public EarningsLineSplitApiModel GetEarningsLineSplitByLocationId(int businessId, int employeeId, int locationId)
        {
            return ApiRequest<EarningsLineSplitApiModel>($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}");
        }

        /// <summary>
        /// Update Earnings line split
        /// </summary>
        /// <remarks>
        /// Updates the employee's earnings line split for the specified location ID.
        /// </remarks>
        public void UpdateEarningsLineSplit(int businessId, int employeeId, int locationId, EarningsLineSplitEditModel earningsLineSplit)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", earningsLineSplit, Method.PUT);
        }

        /// <summary>
        /// Delete Earnings line split
        /// </summary>
        /// <remarks>
        /// Deletes the employee's earnings line split with the specified location ID.
        /// </remarks>
        public void DeleteEarningsLineSplit(int businessId, int employeeId, int locationId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/earningslinesplit/{locationId}", Method.DELETE);
        }
    }
}
