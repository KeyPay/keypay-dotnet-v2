using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PaySchedule;

namespace KeyPayV2.Uk.Functions
{
    public class PayScheduleFunction : BaseFunction
    {
        public PayScheduleFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Schedules
        /// </summary>
        /// <remarks>
        /// Lists all the pay schedules for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkPayScheduleModel> ListPaySchedules(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkPayScheduleModel>>($"/business/{businessId}/payschedule{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Pay Schedule
        /// </summary>
        /// <remarks>
        /// Creates a new pay schedule for the business.
        /// </remarks>
        public UkPayScheduleModel CreatePaySchedule(int businessId, UkPayScheduleModel paySchedule)
        {
            return ApiRequest<UkPayScheduleModel,UkPayScheduleModel>($"/business/{businessId}/payschedule", paySchedule, Method.POST);
        }

        /// <summary>
        /// Get Pay Schedule by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay schedule with the specified ID.
        /// </remarks>
        public UkPayScheduleModel GetPayScheduleById(int businessId, int id)
        {
            return ApiRequest<UkPayScheduleModel>($"/business/{businessId}/payschedule/{id}");
        }

        /// <summary>
        /// Update Pay Schedule
        /// </summary>
        /// <remarks>
        /// Updates the pay schedule with the specified ID.
        /// </remarks>
        public UkPayScheduleModel UpdatePaySchedule(int businessId, int id, UkPayScheduleModel paySchedule)
        {
            return ApiRequest<UkPayScheduleModel,UkPayScheduleModel>($"/business/{businessId}/payschedule/{id}", paySchedule, Method.PUT);
        }

        /// <summary>
        /// Delete Pay Schedule
        /// </summary>
        /// <remarks>
        /// Deletes the pay schedule with the specified ID.
        /// </remarks>
        public void DeletePaySchedule(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/payschedule/{id}", Method.DELETE);
        }

        /// <summary>
        /// Get Pay Schedule Metadata
        /// </summary>
        /// <remarks>
        /// Gets the list of all applicable reference data for Pay Schedules for this business.
        /// </remarks>
        public PayScheduleMetaDataModel GetPayScheduleMetadata(int businessId)
        {
            return ApiRequest<PayScheduleMetaDataModel>($"/business/{businessId}/payschedule/metadata");
        }
    }
}
