using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.PublicHoliday;

namespace KeyPayV2.Nz.Functions
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
            return ApiRequest<List<PublicHolidayModel>>($"/business/{businessId}/publicholiday?year={request.Year}");
        }

        /// <summary>
        /// Add a public holiday
        /// </summary>
        /// <remarks>
        /// Adds a new public holiday.
        /// </remarks>
        public void AddAPublicHoliday(int businessId, PublicHolidayModel publicHoliday)
        {
            ApiRequest($"/business/{businessId}/publicholiday", publicHoliday, Method.POST);
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
        /// Get Public Holiday Details
        /// </summary>
        /// <remarks>
        /// Gets the details for a public holiday with a specific ID
        /// </remarks>
        public PublicHolidayModel GetPublicHolidayDetails(int businessId, int id)
        {
            return ApiRequest<PublicHolidayModel>($"/business/{businessId}/publicholiday/{id}");
        }

        /// <summary>
        /// Update Public Holiday
        /// </summary>
        /// <remarks>
        /// Updates the public holiday with the specific ID.
        /// </remarks>
        public void UpdatePublicHoliday(int businessId, int id, PublicHolidayModel publicHoliday)
        {
            ApiRequest($"/business/{businessId}/publicholiday/{id}", publicHoliday, Method.PUT);
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
    }
}
