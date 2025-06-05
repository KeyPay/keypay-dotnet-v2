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
using KeyPayV2.Au.Models.TimeAndAttendance;

namespace KeyPayV2.Au.Functions
{
    public interface ITimeAndAttendanceFunction
    {
        List<TimeAndAttendanceKioskModel> ListKiosks(int businessId, ODataQuery oDataQuery = null);
        Task<List<TimeAndAttendanceKioskModel>> ListKiosksAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        TimeAndAttendanceKioskModel CreateKiosk(int businessId, TimeAndAttendanceKioskModel kiosk);
        Task<TimeAndAttendanceKioskModel> CreateKioskAsync(int businessId, TimeAndAttendanceKioskModel kiosk, CancellationToken cancellationToken = default);
        TimeAndAttendanceKioskModel GetKioskById(int businessId, int id);
        Task<TimeAndAttendanceKioskModel> GetKioskByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        TimeAndAttendanceKioskModel UpdateKiosk(int businessId, int id, TimeAndAttendanceKioskModel kiosk);
        Task<TimeAndAttendanceKioskModel> UpdateKioskAsync(int businessId, int id, TimeAndAttendanceKioskModel kiosk, CancellationToken cancellationToken = default);
        void DeleteKiosk(int businessId, int id);
        Task DeleteKioskAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class TimeAndAttendanceFunction : BaseFunction, ITimeAndAttendanceFunction
    {
        public TimeAndAttendanceFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Kiosks
        /// </summary>
        /// <remarks>
        /// Lists all kiosks for the specified business.
        /// This operation supports OData queries.
        /// </remarks>
        public List<TimeAndAttendanceKioskModel> ListKiosks(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/kiosk{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Kiosks
        /// </summary>
        /// <remarks>
        /// Lists all kiosks for the specified business.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<TimeAndAttendanceKioskModel>> ListKiosksAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/kiosk{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Kiosk
        /// </summary>
        /// <remarks>
        /// Creates a new kiosk for the business.
        /// </remarks>
        public TimeAndAttendanceKioskModel CreateKiosk(int businessId, TimeAndAttendanceKioskModel kiosk)
        {
            return ApiRequest<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk", kiosk, Method.Post);
        }

        /// <summary>
        /// Create Kiosk
        /// </summary>
        /// <remarks>
        /// Creates a new kiosk for the business.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> CreateKioskAsync(int businessId, TimeAndAttendanceKioskModel kiosk, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk", kiosk, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel GetKioskById(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", Method.Get);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> GetKioskByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Kiosk
        /// </summary>
        /// <remarks>
        /// Updates the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel UpdateKiosk(int businessId, int id, TimeAndAttendanceKioskModel kiosk)
        {
            return ApiRequest<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", kiosk, Method.Put);
        }

        /// <summary>
        /// Update Kiosk
        /// </summary>
        /// <remarks>
        /// Updates the kiosk with the specified ID.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> UpdateKioskAsync(int businessId, int id, TimeAndAttendanceKioskModel kiosk, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", kiosk, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Kiosk
        /// </summary>
        /// <remarks>
        /// Deletes the kiosk with the specified ID.
        /// </remarks>
        public void DeleteKiosk(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/kiosk/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Kiosk
        /// </summary>
        /// <remarks>
        /// Deletes the kiosk with the specified ID.
        /// </remarks>
        public Task DeleteKioskAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{id}", Method.Delete, cancellationToken);
        }
    }
}
