using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.PublicHoliday;

namespace KeyPayV2.My.Functions
{
    public class PublicHolidayFunction : BaseFunction
    {
        public PublicHolidayFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Public Holidays for Year
        /// </summary>
        /// <remarks>
        /// Retrieves all the public holidays for a specific year.
        /// </remarks>
        public List<PublicHolidayModel> GetPublicHolidaysForYear(int businessId, GetPublicHolidaysForYearQueryModel request)
        {
            return ApiRequest<List<PublicHolidayModel>>($"/business/{businessId}/publicholiday?year={request.Year}", Method.GET);
        }

        /// <summary>
        /// Get Public Holidays for Year
        /// </summary>
        /// <remarks>
        /// Retrieves all the public holidays for a specific year.
        /// </remarks>
        public Task<List<PublicHolidayModel>> GetPublicHolidaysForYearAsync(int businessId, GetPublicHolidaysForYearQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PublicHolidayModel>>($"/business/{businessId}/publicholiday?year={request.Year}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add a public holiday
        /// </summary>
        /// <remarks>
        /// Adds a new public holiday.
        /// </remarks>
        public PublicHolidayModel AddAPublicHoliday(int businessId, PublicHolidayModel publicHoliday)
        {
            return ApiRequest<PublicHolidayModel,PublicHolidayModel>($"/business/{businessId}/publicholiday", publicHoliday, Method.POST);
        }

        /// <summary>
        /// Add a public holiday
        /// </summary>
        /// <remarks>
        /// Adds a new public holiday.
        /// </remarks>
        public Task<PublicHolidayModel> AddAPublicHolidayAsync(int businessId, PublicHolidayModel publicHoliday, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PublicHolidayModel,PublicHolidayModel>($"/business/{businessId}/publicholiday", publicHoliday, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Public Holiday by Date
        /// </summary>
        /// <remarks>
        /// Deletes all the public holidays on a specific date.
        /// </remarks>
        public void DeletePublicHolidayByDate(int businessId, DeletePublicHolidayByDateQueryModel request)
        {
            ApiRequest($"/business/{businessId}/publicholiday?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.DELETE);
        }

        /// <summary>
        /// Delete Public Holiday by Date
        /// </summary>
        /// <remarks>
        /// Deletes all the public holidays on a specific date.
        /// </remarks>
        public Task DeletePublicHolidayByDateAsync(int businessId, DeletePublicHolidayByDateQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/publicholiday?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Public Holiday Details
        /// </summary>
        /// <remarks>
        /// Gets the details for a public holiday with a specific ID
        /// </remarks>
        public PublicHolidayModel GetPublicHolidayDetails(int businessId, int id)
        {
            return ApiRequest<PublicHolidayModel>($"/business/{businessId}/publicholiday/{id}", Method.GET);
        }

        /// <summary>
        /// Get Public Holiday Details
        /// </summary>
        /// <remarks>
        /// Gets the details for a public holiday with a specific ID
        /// </remarks>
        public Task<PublicHolidayModel> GetPublicHolidayDetailsAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PublicHolidayModel>($"/business/{businessId}/publicholiday/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Public Holiday
        /// </summary>
        /// <remarks>
        /// Updates the public holiday with the specific ID.
        /// </remarks>
        public PublicHolidayModel UpdatePublicHoliday(int businessId, int id, PublicHolidayModel publicHoliday)
        {
            return ApiRequest<PublicHolidayModel,PublicHolidayModel>($"/business/{businessId}/publicholiday/{id}", publicHoliday, Method.PUT);
        }

        /// <summary>
        /// Update Public Holiday
        /// </summary>
        /// <remarks>
        /// Updates the public holiday with the specific ID.
        /// </remarks>
        public Task<PublicHolidayModel> UpdatePublicHolidayAsync(int businessId, int id, PublicHolidayModel publicHoliday, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PublicHolidayModel,PublicHolidayModel>($"/business/{businessId}/publicholiday/{id}", publicHoliday, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Public Holiday
        /// </summary>
        /// <remarks>
        /// Deletes the public holiday with the specified ID.
        /// </remarks>
        public void DeletePublicHoliday(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/publicholiday/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Public Holiday
        /// </summary>
        /// <remarks>
        /// Deletes the public holiday with the specified ID.
        /// </remarks>
        public Task DeletePublicHolidayAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/publicholiday/{id}", Method.DELETE, cancellationToken);
        }
    }
}
