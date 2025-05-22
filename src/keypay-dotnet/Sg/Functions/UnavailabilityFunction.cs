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
using KeyPayV2.Sg.Models.Unavailability;

namespace KeyPayV2.Sg.Functions
{
    public interface IUnavailabilityFunction
    {
        List<UnavailabilityModel> ListUnavailabilities(int businessId);
        Task<List<UnavailabilityModel>> ListUnavailabilitiesAsync(int businessId, CancellationToken cancellationToken = default);
        List<UnavailabilityModel> ListUnavailabilities(int businessId, ListUnavailabilitiesQueryModel request);
        Task<List<UnavailabilityModel>> ListUnavailabilitiesAsync(int businessId, ListUnavailabilitiesQueryModel request, CancellationToken cancellationToken = default);
        UnavailabilityModel CreateUnavailability(int businessId, UnavailabilitySaveModel unavailabilitySaveModel);
        Task<UnavailabilityModel> CreateUnavailabilityAsync(int businessId, UnavailabilitySaveModel unavailabilitySaveModel, CancellationToken cancellationToken = default);
        UnavailabilityModel GetUnavailabilityById(int businessId, int id);
        Task<UnavailabilityModel> GetUnavailabilityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateUnavailability(int businessId, int id, UnavailabilitySaveModel unavailabilitySaveModel);
        Task UpdateUnavailabilityAsync(int businessId, int id, UnavailabilitySaveModel unavailabilitySaveModel, CancellationToken cancellationToken = default);
        void DeleteUnavailability(int businessId, int id);
        Task DeleteUnavailabilityAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class UnavailabilityFunction : BaseFunction, IUnavailabilityFunction
    {
        public UnavailabilityFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public List<UnavailabilityModel> ListUnavailabilities(int businessId)
        {
            return ApiRequest<List<UnavailabilityModel>>($"/business/{businessId}/unavailability", Method.Get);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public Task<List<UnavailabilityModel>> ListUnavailabilitiesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnavailabilityModel>>($"/business/{businessId}/unavailability", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public List<UnavailabilityModel> ListUnavailabilities(int businessId, ListUnavailabilitiesQueryModel request)
        {
            return ApiRequest<List<UnavailabilityModel>>($"/business/{businessId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&defaultLocationId={request.DefaultLocationId}", Method.Get);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public Task<List<UnavailabilityModel>> ListUnavailabilitiesAsync(int businessId, ListUnavailabilitiesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnavailabilityModel>>($"/business/{businessId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&defaultLocationId={request.DefaultLocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public UnavailabilityModel CreateUnavailability(int businessId, UnavailabilitySaveModel unavailabilitySaveModel)
        {
            return ApiRequest<UnavailabilityModel,UnavailabilitySaveModel>($"/business/{businessId}/unavailability", unavailabilitySaveModel, Method.Post);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public Task<UnavailabilityModel> CreateUnavailabilityAsync(int businessId, UnavailabilitySaveModel unavailabilitySaveModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnavailabilityModel,UnavailabilitySaveModel>($"/business/{businessId}/unavailability", unavailabilitySaveModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID.
        /// </remarks>
        public UnavailabilityModel GetUnavailabilityById(int businessId, int id)
        {
            return ApiRequest<UnavailabilityModel>($"/business/{businessId}/unavailability/{id}", Method.Get);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID.
        /// </remarks>
        public Task<UnavailabilityModel> GetUnavailabilityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnavailabilityModel>($"/business/{businessId}/unavailability/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public void UpdateUnavailability(int businessId, int id, UnavailabilitySaveModel unavailabilitySaveModel)
        {
            ApiRequest($"/business/{businessId}/unavailability/{id}", unavailabilitySaveModel, Method.Put);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public Task UpdateUnavailabilityAsync(int businessId, int id, UnavailabilitySaveModel unavailabilitySaveModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/unavailability/{id}", unavailabilitySaveModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/unavailability/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public Task DeleteUnavailabilityAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/unavailability/{id}", Method.Delete, cancellationToken);
        }
    }
}
