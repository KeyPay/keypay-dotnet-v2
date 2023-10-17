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
using KeyPayV2.Sg.Models.EmployeeIncomeTaxBorneByEmployer;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeIncomeTaxBorneByEmployerFunction
    {
        List<SgIncomeTaxBorneByEmployerModel> GetIncomeTaxBorneByEmployer(int businessId, int employeeId);
        Task<List<SgIncomeTaxBorneByEmployerModel>> GetIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void CreateIncomeTaxBorneByEmployer(int businessId, int employeeId, SgIncomeTaxBorneByEmployerModel model);
        Task CreateIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, SgIncomeTaxBorneByEmployerModel model, CancellationToken cancellationToken = default);
        SgIncomeTaxBorneByEmployerModel GetIncomeTaxBorneByEmployer(int businessId, int employeeId, int id);
        Task<SgIncomeTaxBorneByEmployerModel> GetIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void UpdateAnExistingIncomeTaxBorneByEmployer(int businessId, int employeeId, int id, SgIncomeTaxBorneByEmployerModel request);
        Task UpdateAnExistingIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, int id, SgIncomeTaxBorneByEmployerModel request, CancellationToken cancellationToken = default);
        void DeleteIncomeTaxBorneByEmployer(int businessId, int employeeId, int id);
        Task DeleteIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployeeIncomeTaxBorneByEmployerFunction : BaseFunction, IEmployeeIncomeTaxBorneByEmployerFunction
    {
        public EmployeeIncomeTaxBorneByEmployerFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Gets the income tax borne by employer for the specified employee
        /// </remarks>
        public List<SgIncomeTaxBorneByEmployerModel> GetIncomeTaxBorneByEmployer(int businessId, int employeeId)
        {
            return ApiRequest<List<SgIncomeTaxBorneByEmployerModel>>($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer", Method.Get);
        }

        /// <summary>
        /// Get income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Gets the income tax borne by employer for the specified employee
        /// </remarks>
        public Task<List<SgIncomeTaxBorneByEmployerModel>> GetIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgIncomeTaxBorneByEmployerModel>>($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Creates a new income tax borne by employer
        /// </remarks>
        public void CreateIncomeTaxBorneByEmployer(int businessId, int employeeId, SgIncomeTaxBorneByEmployerModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer", model, Method.Post);
        }

        /// <summary>
        /// Create income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Creates a new income tax borne by employer
        /// </remarks>
        public Task CreateIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, SgIncomeTaxBorneByEmployerModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Gets a specific income tax borne by employer for the specified employee
        /// </remarks>
        public SgIncomeTaxBorneByEmployerModel GetIncomeTaxBorneByEmployer(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgIncomeTaxBorneByEmployerModel>($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", Method.Get);
        }

        /// <summary>
        /// Get income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Gets a specific income tax borne by employer for the specified employee
        /// </remarks>
        public Task<SgIncomeTaxBorneByEmployerModel> GetIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIncomeTaxBorneByEmployerModel>($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update an existing income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Update an existing income tax borne by employer
        /// </remarks>
        public void UpdateAnExistingIncomeTaxBorneByEmployer(int businessId, int employeeId, int id, SgIncomeTaxBorneByEmployerModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update an existing income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Update an existing income tax borne by employer
        /// </remarks>
        public Task UpdateAnExistingIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, int id, SgIncomeTaxBorneByEmployerModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Deletes the income tax borne by employer with the specified ID.
        /// </remarks>
        public void DeleteIncomeTaxBorneByEmployer(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Deletes the income tax borne by employer with the specified ID.
        /// </remarks>
        public Task DeleteIncomeTaxBorneByEmployerAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", Method.Delete, cancellationToken);
        }
    }
}
