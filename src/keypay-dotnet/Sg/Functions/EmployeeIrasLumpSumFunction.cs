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
using KeyPayV2.Sg.Models.EmployeeIrasLumpSum;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeIrasLumpSumFunction
    {
        SgIrasLumpSumModel GetIrasLumpSumDetailsForEmployee(int businessId, int employeeId, int id);
        Task<SgIrasLumpSumModel> GetIrasLumpSumDetailsForEmployeeAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        SgIrasLumpSumModel UpdateALumpSum(int businessId, int employeeId, int id, SgIrasLumpSumModel request);
        Task<SgIrasLumpSumModel> UpdateALumpSumAsync(int businessId, int employeeId, int id, SgIrasLumpSumModel request, CancellationToken cancellationToken = default);
        void DeleteLumpSum(int businessId, int employeeId, int id);
        Task DeleteLumpSumAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<SgIrasLumpSumModel> GetLumpSum(int businessId, int employeeId);
        Task<List<SgIrasLumpSumModel>> GetLumpSumAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        SgIrasLumpSumModel CreateIrasLumpSumDetails(int businessId, int employeeId, SgIrasLumpSumModel model);
        Task<SgIrasLumpSumModel> CreateIrasLumpSumDetailsAsync(int businessId, int employeeId, SgIrasLumpSumModel model, CancellationToken cancellationToken = default);
    }
    public class EmployeeIrasLumpSumFunction : BaseFunction, IEmployeeIrasLumpSumFunction
    {
        public EmployeeIrasLumpSumFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get IRAS lump sum details for employee
        /// </summary>
        /// <remarks>
        /// Gets specific IRAS lump sum details for the specified employee
        /// </remarks>
        public SgIrasLumpSumModel GetIrasLumpSumDetailsForEmployee(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgIrasLumpSumModel>($"/business/{businessId}/employee/{employeeId}/lumpsum/{id}", Method.Get);
        }

        /// <summary>
        /// Get IRAS lump sum details for employee
        /// </summary>
        /// <remarks>
        /// Gets specific IRAS lump sum details for the specified employee
        /// </remarks>
        public Task<SgIrasLumpSumModel> GetIrasLumpSumDetailsForEmployeeAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIrasLumpSumModel>($"/business/{businessId}/employee/{employeeId}/lumpsum/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update a lump sum
        /// </summary>
        /// <remarks>
        /// Update an existing lump sum.
        /// </remarks>
        public SgIrasLumpSumModel UpdateALumpSum(int businessId, int employeeId, int id, SgIrasLumpSumModel request)
        {
            return ApiRequest<SgIrasLumpSumModel,SgIrasLumpSumModel>($"/business/{businessId}/employee/{employeeId}/lumpsum/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update a lump sum
        /// </summary>
        /// <remarks>
        /// Update an existing lump sum.
        /// </remarks>
        public Task<SgIrasLumpSumModel> UpdateALumpSumAsync(int businessId, int employeeId, int id, SgIrasLumpSumModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIrasLumpSumModel,SgIrasLumpSumModel>($"/business/{businessId}/employee/{employeeId}/lumpsum/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete lump sum
        /// </summary>
        /// <remarks>
        /// Deletes the IRAS lump sum details with the specified ID.
        /// </remarks>
        public void DeleteLumpSum(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/lumpsum/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete lump sum
        /// </summary>
        /// <remarks>
        /// Deletes the IRAS lump sum details with the specified ID.
        /// </remarks>
        public Task DeleteLumpSumAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/lumpsum/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get lump sum
        /// </summary>
        /// <remarks>
        /// Gets the lump sum for the specified employee
        /// </remarks>
        public List<SgIrasLumpSumModel> GetLumpSum(int businessId, int employeeId)
        {
            return ApiRequest<List<SgIrasLumpSumModel>>($"/business/{businessId}/employee/{employeeId}/lumpsum", Method.Get);
        }

        /// <summary>
        /// Get lump sum
        /// </summary>
        /// <remarks>
        /// Gets the lump sum for the specified employee
        /// </remarks>
        public Task<List<SgIrasLumpSumModel>> GetLumpSumAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgIrasLumpSumModel>>($"/business/{businessId}/employee/{employeeId}/lumpsum", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create IRAS lump sum details
        /// </summary>
        /// <remarks>
        /// Creates new IRAS lump sum details for the employee.
        /// </remarks>
        public SgIrasLumpSumModel CreateIrasLumpSumDetails(int businessId, int employeeId, SgIrasLumpSumModel model)
        {
            return ApiRequest<SgIrasLumpSumModel,SgIrasLumpSumModel>($"/business/{businessId}/employee/{employeeId}/lumpsum", model, Method.Post);
        }

        /// <summary>
        /// Create IRAS lump sum details
        /// </summary>
        /// <remarks>
        /// Creates new IRAS lump sum details for the employee.
        /// </remarks>
        public Task<SgIrasLumpSumModel> CreateIrasLumpSumDetailsAsync(int businessId, int employeeId, SgIrasLumpSumModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIrasLumpSumModel,SgIrasLumpSumModel>($"/business/{businessId}/employee/{employeeId}/lumpsum", model, Method.Post, cancellationToken);
        }
    }
}
