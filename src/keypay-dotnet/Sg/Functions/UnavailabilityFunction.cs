using System;
using System.Collections.Generic;
using System.Linq;
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
    public class UnavailabilityFunction : BaseFunction
    {
        public UnavailabilityFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public List<UnavailabilityModel> ListUnavailabilities(int businessId, ListUnavailabilitiesQueryModel request)
        {
            return ApiRequest<List<UnavailabilityModel>>($"/business/{businessId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&defaultLocationId={request.DefaultLocationId}", Method.GET);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this business, with optional filters.
        /// </remarks>
        public Task<List<UnavailabilityModel>> ListUnavailabilitiesAsync(int businessId, ListUnavailabilitiesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnavailabilityModel>>($"/business/{businessId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&defaultLocationId={request.DefaultLocationId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public UnavailabilityModel CreateUnavailability(int businessId, UnavailabilitySaveModel unavailabilitySaveModel)
        {
            return ApiRequest<UnavailabilityModel,UnavailabilitySaveModel>($"/business/{businessId}/unavailability", unavailabilitySaveModel, Method.POST);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public Task<UnavailabilityModel> CreateUnavailabilityAsync(int businessId, UnavailabilitySaveModel unavailabilitySaveModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnavailabilityModel,UnavailabilitySaveModel>($"/business/{businessId}/unavailability", unavailabilitySaveModel, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID.
        /// </remarks>
        public UnavailabilityModel GetUnavailabilityById(int businessId, int id)
        {
            return ApiRequest<UnavailabilityModel>($"/business/{businessId}/unavailability/{id}", Method.GET);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID.
        /// </remarks>
        public Task<UnavailabilityModel> GetUnavailabilityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnavailabilityModel>($"/business/{businessId}/unavailability/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public void UpdateUnavailability(int businessId, int id, UnavailabilitySaveModel unavailabilitySaveModel)
        {
            ApiRequest($"/business/{businessId}/unavailability/{id}", unavailabilitySaveModel, Method.PUT);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public Task UpdateUnavailabilityAsync(int businessId, int id, UnavailabilitySaveModel unavailabilitySaveModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/unavailability/{id}", unavailabilitySaveModel, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/unavailability/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public Task DeleteUnavailabilityAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/unavailability/{id}", Method.DELETE, cancellationToken);
        }
    }
}
