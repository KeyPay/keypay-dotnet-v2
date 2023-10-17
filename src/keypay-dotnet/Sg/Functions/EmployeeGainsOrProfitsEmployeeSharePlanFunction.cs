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
using KeyPayV2.Sg.Models.EmployeeGainsOrProfitsEmployeeSharePlan;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeGainsOrProfitsEmployeeSharePlanFunction
    {
        List<SgGainsOrProfitsEmployeeSharePlanModel> GetGainsOrProfitsEmployeeSharePlans(int businessId, int employeeId);
        Task<List<SgGainsOrProfitsEmployeeSharePlanModel>> GetGainsOrProfitsEmployeeSharePlansAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void CreateGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, SgGainsOrProfitsEmployeeSharePlanModel model);
        Task CreateGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, SgGainsOrProfitsEmployeeSharePlanModel model, CancellationToken cancellationToken = default);
        SgGainsOrProfitsEmployeeSharePlanModel GetGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id);
        Task<SgGainsOrProfitsEmployeeSharePlanModel> GetGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void UpdateAnExistingGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id, SgGainsOrProfitsEmployeeSharePlanModel request);
        Task UpdateAnExistingGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, int id, SgGainsOrProfitsEmployeeSharePlanModel request, CancellationToken cancellationToken = default);
        void DeleteGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id);
        Task DeleteGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployeeGainsOrProfitsEmployeeSharePlanFunction : BaseFunction, IEmployeeGainsOrProfitsEmployeeSharePlanFunction
    {
        public EmployeeGainsOrProfitsEmployeeSharePlanFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Gains or profits employee share plans
        /// </summary>
        /// <remarks>
        /// Gets the gains or profits employee share plans for the specified employee
        /// </remarks>
        public List<SgGainsOrProfitsEmployeeSharePlanModel> GetGainsOrProfitsEmployeeSharePlans(int businessId, int employeeId)
        {
            return ApiRequest<List<SgGainsOrProfitsEmployeeSharePlanModel>>($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan", Method.Get);
        }

        /// <summary>
        /// Get Gains or profits employee share plans
        /// </summary>
        /// <remarks>
        /// Gets the gains or profits employee share plans for the specified employee
        /// </remarks>
        public Task<List<SgGainsOrProfitsEmployeeSharePlanModel>> GetGainsOrProfitsEmployeeSharePlansAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgGainsOrProfitsEmployeeSharePlanModel>>($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Creates a new gains or profits employee share plan
        /// </remarks>
        public void CreateGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, SgGainsOrProfitsEmployeeSharePlanModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan", model, Method.Post);
        }

        /// <summary>
        /// Create Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Creates a new gains or profits employee share plan
        /// </remarks>
        public Task CreateGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, SgGainsOrProfitsEmployeeSharePlanModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Gets a specific gains or profits employee share plan for the specified employee
        /// </remarks>
        public SgGainsOrProfitsEmployeeSharePlanModel GetGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgGainsOrProfitsEmployeeSharePlanModel>($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", Method.Get);
        }

        /// <summary>
        /// Get Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Gets a specific gains or profits employee share plan for the specified employee
        /// </remarks>
        public Task<SgGainsOrProfitsEmployeeSharePlanModel> GetGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgGainsOrProfitsEmployeeSharePlanModel>($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update an existing Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Update an existing gains or profits employee share plan.
        /// </remarks>
        public void UpdateAnExistingGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id, SgGainsOrProfitsEmployeeSharePlanModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update an existing Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Update an existing gains or profits employee share plan.
        /// </remarks>
        public Task UpdateAnExistingGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, int id, SgGainsOrProfitsEmployeeSharePlanModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Deletes the Gains or profits employee share plan with the specified ID.
        /// </remarks>
        public void DeleteGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Deletes the Gains or profits employee share plan with the specified ID.
        /// </remarks>
        public Task DeleteGainsOrProfitsEmployeeSharePlanAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", Method.Delete, cancellationToken);
        }
    }
}
