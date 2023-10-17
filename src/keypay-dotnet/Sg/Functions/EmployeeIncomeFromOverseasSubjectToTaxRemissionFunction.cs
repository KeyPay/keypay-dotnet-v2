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
using KeyPayV2.Sg.Models.EmployeeIncomeFromOverseasSubjectToTaxRemission;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeIncomeFromOverseasSubjectToTaxRemissionFunction
    {
        List<SgIncomeFromOverseasSubjectToTaxRemissionModel> GetIncomeFromOverseasSubjectToTaxRemissions(int businessId, int employeeId);
        Task<List<SgIncomeFromOverseasSubjectToTaxRemissionModel>> GetIncomeFromOverseasSubjectToTaxRemissionsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void CreateIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, SgIncomeFromOverseasSubjectToTaxRemissionModel model);
        Task CreateIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, SgIncomeFromOverseasSubjectToTaxRemissionModel model, CancellationToken cancellationToken = default);
        SgIncomeFromOverseasSubjectToTaxRemissionModel GetIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id);
        Task<SgIncomeFromOverseasSubjectToTaxRemissionModel> GetIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void UpdateAnExistingIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id, SgIncomeFromOverseasSubjectToTaxRemissionModel request);
        Task UpdateAnExistingIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, int id, SgIncomeFromOverseasSubjectToTaxRemissionModel request, CancellationToken cancellationToken = default);
        void DeleteIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id);
        Task DeleteIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployeeIncomeFromOverseasSubjectToTaxRemissionFunction : BaseFunction, IEmployeeIncomeFromOverseasSubjectToTaxRemissionFunction
    {
        public EmployeeIncomeFromOverseasSubjectToTaxRemissionFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Income from overseas subject to tax remissions
        /// </summary>
        /// <remarks>
        /// Gets the income from overseas subject to tax remissions for the specified employee
        /// </remarks>
        public List<SgIncomeFromOverseasSubjectToTaxRemissionModel> GetIncomeFromOverseasSubjectToTaxRemissions(int businessId, int employeeId)
        {
            return ApiRequest<List<SgIncomeFromOverseasSubjectToTaxRemissionModel>>($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission", Method.Get);
        }

        /// <summary>
        /// Get Income from overseas subject to tax remissions
        /// </summary>
        /// <remarks>
        /// Gets the income from overseas subject to tax remissions for the specified employee
        /// </remarks>
        public Task<List<SgIncomeFromOverseasSubjectToTaxRemissionModel>> GetIncomeFromOverseasSubjectToTaxRemissionsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgIncomeFromOverseasSubjectToTaxRemissionModel>>($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Creates a new income from overseas subject to tax remissions
        /// </remarks>
        public void CreateIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, SgIncomeFromOverseasSubjectToTaxRemissionModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission", model, Method.Post);
        }

        /// <summary>
        /// Create Income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Creates a new income from overseas subject to tax remissions
        /// </remarks>
        public Task CreateIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, SgIncomeFromOverseasSubjectToTaxRemissionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Gets a specific income from overseas subject to tax remission for the specified employee
        /// </remarks>
        public SgIncomeFromOverseasSubjectToTaxRemissionModel GetIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgIncomeFromOverseasSubjectToTaxRemissionModel>($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", Method.Get);
        }

        /// <summary>
        /// Get Income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Gets a specific income from overseas subject to tax remission for the specified employee
        /// </remarks>
        public Task<SgIncomeFromOverseasSubjectToTaxRemissionModel> GetIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIncomeFromOverseasSubjectToTaxRemissionModel>($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update an existing income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Update an existing income from overseas subject to tax remission
        /// </remarks>
        public void UpdateAnExistingIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id, SgIncomeFromOverseasSubjectToTaxRemissionModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update an existing income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Update an existing income from overseas subject to tax remission
        /// </remarks>
        public Task UpdateAnExistingIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, int id, SgIncomeFromOverseasSubjectToTaxRemissionModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Deletes the income from overseas subject to tax remission with the specified ID.
        /// </remarks>
        public void DeleteIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Deletes the income from overseas subject to tax remission with the specified ID.
        /// </remarks>
        public Task DeleteIncomeFromOverseasSubjectToTaxRemissionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", Method.Delete, cancellationToken);
        }
    }
}
