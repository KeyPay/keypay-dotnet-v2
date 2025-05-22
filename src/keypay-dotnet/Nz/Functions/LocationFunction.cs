using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.Location;

namespace KeyPayV2.Nz.Functions
{
    public interface ILocationFunction
    {
        List<NzLocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<NzLocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        List<NzLocationModel> ListBusinessLocations(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzLocationModel>> ListBusinessLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzLocationModel CreateLocation(int businessId, NzLocationModel location);
        Task<NzLocationModel> CreateLocationAsync(int businessId, NzLocationModel location, CancellationToken cancellationToken = default);
        NzSingleLocationModel GetLocationById(int businessId, int id);
        Task<NzSingleLocationModel> GetLocationByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateLocation(int businessId, int id, NzLocationModel location);
        Task UpdateLocationAsync(int businessId, int id, NzLocationModel location, CancellationToken cancellationToken = default);
        void DeleteLocation(int businessId, int id);
        Task DeleteLocationAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class LocationFunction : BaseFunction, ILocationFunction
    {
        public LocationFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzLocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzLocationModel>>($"/business/{businessId}/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzLocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLocationModel>>($"/business/{businessId}/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Business Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for a business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzLocationModel> ListBusinessLocations(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzLocationModel>>($"/business/{businessId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Business Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for a business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzLocationModel>> ListBusinessLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLocationModel>>($"/business/{businessId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Location
        /// </summary>
        /// <remarks>
        /// Creates a business location.
        /// </remarks>
        public NzLocationModel CreateLocation(int businessId, NzLocationModel location)
        {
            return ApiRequest<NzLocationModel,NzLocationModel>($"/business/{businessId}/location", location, Method.Post);
        }

        /// <summary>
        /// Create Location
        /// </summary>
        /// <remarks>
        /// Creates a business location.
        /// </remarks>
        public Task<NzLocationModel> CreateLocationAsync(int businessId, NzLocationModel location, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLocationModel,NzLocationModel>($"/business/{businessId}/location", location, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Location By Id
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the location with the specified ID.
        /// </remarks>
        public NzSingleLocationModel GetLocationById(int businessId, int id)
        {
            return ApiRequest<NzSingleLocationModel>($"/business/{businessId}/location/{id}", Method.Get);
        }

        /// <summary>
        /// Get Location By Id
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the location with the specified ID.
        /// </remarks>
        public Task<NzSingleLocationModel> GetLocationByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzSingleLocationModel>($"/business/{businessId}/location/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates the business location with the specified ID.
        /// </remarks>
        public void UpdateLocation(int businessId, int id, NzLocationModel location)
        {
            ApiRequest($"/business/{businessId}/location/{id}", location, Method.Put);
        }

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates the business location with the specified ID.
        /// </remarks>
        public Task UpdateLocationAsync(int businessId, int id, NzLocationModel location, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/location/{id}", location, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Deletes the location with the specified ID.
        /// </remarks>
        public void DeleteLocation(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/location/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Deletes the location with the specified ID.
        /// </remarks>
        public Task DeleteLocationAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/location/{id}", Method.Delete, cancellationToken);
        }
    }
}
