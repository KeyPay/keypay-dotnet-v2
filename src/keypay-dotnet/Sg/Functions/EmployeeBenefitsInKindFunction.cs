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
using KeyPayV2.Sg.Models.EmployeeBenefitsInKind;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeBenefitsInKindFunction
    {
        List<SgBenefitsInKind> GetBenefitsInKinds(int businessId, int employeeId);
        Task<List<SgBenefitsInKind>> GetBenefitsInKindsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void CreateBenefitInKind(int businessId, int employeeId, SgBenefitsInKind model);
        Task CreateBenefitInKindAsync(int businessId, int employeeId, SgBenefitsInKind model, CancellationToken cancellationToken = default);
        SgBenefitsInKind GetBenefitsInKind(int businessId, int employeeId, int id);
        Task<SgBenefitsInKind> GetBenefitsInKindAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void UpdateAnBenefitInKind(int businessId, int employeeId, int id, SgBenefitsInKind request);
        Task UpdateAnBenefitInKindAsync(int businessId, int employeeId, int id, SgBenefitsInKind request, CancellationToken cancellationToken = default);
        void DeleteBenefitInKind(int businessId, int employeeId, int id);
        Task DeleteBenefitInKindAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployeeBenefitsInKindFunction : BaseFunction, IEmployeeBenefitsInKindFunction
    {
        public EmployeeBenefitsInKindFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get benefits in kinds
        /// </summary>
        /// <remarks>
        /// Gets the benefits in kind for the specified employee
        /// </remarks>
        public List<SgBenefitsInKind> GetBenefitsInKinds(int businessId, int employeeId)
        {
            return ApiRequest<List<SgBenefitsInKind>>($"/business/{businessId}/employee/{employeeId}/benefitsinkind", Method.Get);
        }

        /// <summary>
        /// Get benefits in kinds
        /// </summary>
        /// <remarks>
        /// Gets the benefits in kind for the specified employee
        /// </remarks>
        public Task<List<SgBenefitsInKind>> GetBenefitsInKindsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgBenefitsInKind>>($"/business/{businessId}/employee/{employeeId}/benefitsinkind", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create benefit in kind
        /// </summary>
        /// <remarks>
        /// Creates a new benefit in kind for the employee.
        /// </remarks>
        public void CreateBenefitInKind(int businessId, int employeeId, SgBenefitsInKind model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkind", model, Method.Post);
        }

        /// <summary>
        /// Create benefit in kind
        /// </summary>
        /// <remarks>
        /// Creates a new benefit in kind for the employee.
        /// </remarks>
        public Task CreateBenefitInKindAsync(int businessId, int employeeId, SgBenefitsInKind model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/benefitsinkind", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get benefits in kind
        /// </summary>
        /// <remarks>
        /// Gets a specific gains or profits employee share plan for the specified employee
        /// </remarks>
        public SgBenefitsInKind GetBenefitsInKind(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgBenefitsInKind>($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", Method.Get);
        }

        /// <summary>
        /// Get benefits in kind
        /// </summary>
        /// <remarks>
        /// Gets a specific gains or profits employee share plan for the specified employee
        /// </remarks>
        public Task<SgBenefitsInKind> GetBenefitsInKindAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgBenefitsInKind>($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update an benefit in kind
        /// </summary>
        /// <remarks>
        /// Update an existing benefit in kind.
        /// </remarks>
        public void UpdateAnBenefitInKind(int businessId, int employeeId, int id, SgBenefitsInKind request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update an benefit in kind
        /// </summary>
        /// <remarks>
        /// Update an existing benefit in kind.
        /// </remarks>
        public Task UpdateAnBenefitInKindAsync(int businessId, int employeeId, int id, SgBenefitsInKind request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete benefit in kind
        /// </summary>
        /// <remarks>
        /// Deletes the benefit in kind with the specified ID.
        /// </remarks>
        public void DeleteBenefitInKind(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete benefit in kind
        /// </summary>
        /// <remarks>
        /// Deletes the benefit in kind with the specified ID.
        /// </remarks>
        public Task DeleteBenefitInKindAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", Method.Delete, cancellationToken);
        }
    }
}
