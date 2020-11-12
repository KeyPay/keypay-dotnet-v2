using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeSuperFundFunction : BaseFunction
    {
        public EmployeeSuperFundFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Super Funds
        /// </summary>
        /// <remarks>
        /// Lists all of the super funds for this employee.
        /// </remarks>
        public List<SuperFundModel> ListSuperFunds(int businessId, int employeeId)
        {
            return ApiRequest<List<SuperFundModel>>($"/business/{businessId}/employee/{employeeId}/superfund");
        }

        /// <summary>
        /// Create Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new super fund for the employee.
        /// </remarks>
        public SaveSuperFundResponseModel CreateSuperFund(int businessId, int employeeId, SaveSuperFundModel model)
        {
            return ApiRequest<SaveSuperFundResponseModel,SaveSuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund", model, Method.POST);
        }

        /// <summary>
        /// Update Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the employee's super fund with the specified ID.
        /// </remarks>
        public SaveSuperFundResponseModel UpdateSuperFund(int businessId, int employeeId, int id, SaveSuperFundModel model)
        {
            return ApiRequest<SaveSuperFundResponseModel,SaveSuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Super Fund
        /// </summary>
        /// <remarks>
        /// Deletes the employee's super fund with the specified ID.
        /// </remarks>
        public SaveSuperFundResponseModel DeleteSuperFund(int businessId, int employeeId, int superfundId)
        {
            return ApiRequest<SaveSuperFundResponseModel>($"/business/{businessId}/employee/{employeeId}/superfund/{superfundId}", Method.DELETE);
        }

        /// <summary>
        /// Get Super Fund by ID
        /// </summary>
        /// <remarks>
        /// Gets the super fund for this employee with the specified ID.
        /// </remarks>
        public SuperFundModel GetSuperFundById(int businessId, int employeeId, int superFundId)
        {
            return ApiRequest<SuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund/{superFundId}");
        }
    }
}
