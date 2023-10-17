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

namespace KeyPayV2.Au.Functions
{
    public interface IEmployeeSuperFundFunction
    {
        List<SuperFundModel> ListSuperFunds(int businessId, int employeeId);
        Task<List<SuperFundModel>> ListSuperFundsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        SaveSuperFundResponseModel CreateSuperFund(int businessId, int employeeId, SaveSuperFundModel model);
        Task<SaveSuperFundResponseModel> CreateSuperFundAsync(int businessId, int employeeId, SaveSuperFundModel model, CancellationToken cancellationToken = default);
        SaveSuperFundResponseModel UpdateSuperFund(int businessId, int employeeId, int id, SaveSuperFundModel model);
        Task<SaveSuperFundResponseModel> UpdateSuperFundAsync(int businessId, int employeeId, int id, SaveSuperFundModel model, CancellationToken cancellationToken = default);
        SaveSuperFundResponseModel DeleteSuperFund(int businessId, int employeeId, int superfundId);
        Task<SaveSuperFundResponseModel> DeleteSuperFundAsync(int businessId, int employeeId, int superfundId, CancellationToken cancellationToken = default);
        SuperFundModel GetSuperFundById(int businessId, int employeeId, int superFundId);
        Task<SuperFundModel> GetSuperFundByIdAsync(int businessId, int employeeId, int superFundId, CancellationToken cancellationToken = default);
    }
    public class EmployeeSuperFundFunction : BaseFunction, IEmployeeSuperFundFunction
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
            return ApiRequest<List<SuperFundModel>>($"/business/{businessId}/employee/{employeeId}/superfund", Method.Get);
        }

        /// <summary>
        /// List Super Funds
        /// </summary>
        /// <remarks>
        /// Lists all of the super funds for this employee.
        /// </remarks>
        public Task<List<SuperFundModel>> ListSuperFundsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SuperFundModel>>($"/business/{businessId}/employee/{employeeId}/superfund", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new super fund for the employee.
        /// </remarks>
        public SaveSuperFundResponseModel CreateSuperFund(int businessId, int employeeId, SaveSuperFundModel model)
        {
            return ApiRequest<SaveSuperFundResponseModel,SaveSuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund", model, Method.Post);
        }

        /// <summary>
        /// Create Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new super fund for the employee.
        /// </remarks>
        public Task<SaveSuperFundResponseModel> CreateSuperFundAsync(int businessId, int employeeId, SaveSuperFundModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SaveSuperFundResponseModel,SaveSuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the employee's super fund with the specified ID.
        /// </remarks>
        public SaveSuperFundResponseModel UpdateSuperFund(int businessId, int employeeId, int id, SaveSuperFundModel model)
        {
            return ApiRequest<SaveSuperFundResponseModel,SaveSuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the employee's super fund with the specified ID.
        /// </remarks>
        public Task<SaveSuperFundResponseModel> UpdateSuperFundAsync(int businessId, int employeeId, int id, SaveSuperFundModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SaveSuperFundResponseModel,SaveSuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Super Fund
        /// </summary>
        /// <remarks>
        /// Deletes the employee's super fund with the specified ID.
        /// </remarks>
        public SaveSuperFundResponseModel DeleteSuperFund(int businessId, int employeeId, int superfundId)
        {
            return ApiRequest<SaveSuperFundResponseModel>($"/business/{businessId}/employee/{employeeId}/superfund/{superfundId}", Method.Delete);
        }

        /// <summary>
        /// Delete Super Fund
        /// </summary>
        /// <remarks>
        /// Deletes the employee's super fund with the specified ID.
        /// </remarks>
        public Task<SaveSuperFundResponseModel> DeleteSuperFundAsync(int businessId, int employeeId, int superfundId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SaveSuperFundResponseModel>($"/business/{businessId}/employee/{employeeId}/superfund/{superfundId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Super Fund by ID
        /// </summary>
        /// <remarks>
        /// Gets the super fund for this employee with the specified ID.
        /// </remarks>
        public SuperFundModel GetSuperFundById(int businessId, int employeeId, int superFundId)
        {
            return ApiRequest<SuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund/{superFundId}", Method.Get);
        }

        /// <summary>
        /// Get Super Fund by ID
        /// </summary>
        /// <remarks>
        /// Gets the super fund for this employee with the specified ID.
        /// </remarks>
        public Task<SuperFundModel> GetSuperFundByIdAsync(int businessId, int employeeId, int superFundId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SuperFundModel>($"/business/{businessId}/employee/{employeeId}/superfund/{superFundId}", Method.Get, cancellationToken);
        }
    }
}
