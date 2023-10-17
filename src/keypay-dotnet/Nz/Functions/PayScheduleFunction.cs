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
using KeyPayV2.Nz.Models.PaySchedule;

namespace KeyPayV2.Nz.Functions
{
    public interface IPayScheduleFunction
    {
        List<NzPayScheduleModel> ListPaySchedules(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzPayScheduleModel>> ListPaySchedulesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzPayScheduleModel CreatePaySchedule(int businessId, NzPayScheduleModel paySchedule);
        Task<NzPayScheduleModel> CreatePayScheduleAsync(int businessId, NzPayScheduleModel paySchedule, CancellationToken cancellationToken = default);
        NzPayScheduleModel GetPayScheduleById(int businessId, int id);
        Task<NzPayScheduleModel> GetPayScheduleByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        NzPayScheduleModel UpdatePaySchedule(int businessId, int id, NzPayScheduleModel paySchedule);
        Task<NzPayScheduleModel> UpdatePayScheduleAsync(int businessId, int id, NzPayScheduleModel paySchedule, CancellationToken cancellationToken = default);
        void DeletePaySchedule(int businessId, int id);
        Task DeletePayScheduleAsync(int businessId, int id, CancellationToken cancellationToken = default);
        PayScheduleDateForecastResultApiModel GetNextPayDate(int businessId, int payScheduleId);
        Task<PayScheduleDateForecastResultApiModel> GetNextPayDateAsync(int businessId, int payScheduleId, CancellationToken cancellationToken = default);
        PayScheduleMetaDataModel GetPayScheduleMetadata(int businessId);
        Task<PayScheduleMetaDataModel> GetPayScheduleMetadataAsync(int businessId, CancellationToken cancellationToken = default);
        List<PayScheduleDateForecastResultApiModel> ListNextPayDates(int businessId);
        Task<List<PayScheduleDateForecastResultApiModel>> ListNextPayDatesAsync(int businessId, CancellationToken cancellationToken = default);
    }
    public class PayScheduleFunction : BaseFunction, IPayScheduleFunction
    {
        public PayScheduleFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Schedules
        /// </summary>
        /// <remarks>
        /// Lists all the pay schedules for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzPayScheduleModel> ListPaySchedules(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzPayScheduleModel>>($"/business/{businessId}/payschedule{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Schedules
        /// </summary>
        /// <remarks>
        /// Lists all the pay schedules for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzPayScheduleModel>> ListPaySchedulesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPayScheduleModel>>($"/business/{businessId}/payschedule{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Schedule
        /// </summary>
        /// <remarks>
        /// Creates a new pay schedule for the business.
        /// </remarks>
        public NzPayScheduleModel CreatePaySchedule(int businessId, NzPayScheduleModel paySchedule)
        {
            return ApiRequest<NzPayScheduleModel,NzPayScheduleModel>($"/business/{businessId}/payschedule", paySchedule, Method.Post);
        }

        /// <summary>
        /// Create Pay Schedule
        /// </summary>
        /// <remarks>
        /// Creates a new pay schedule for the business.
        /// </remarks>
        public Task<NzPayScheduleModel> CreatePayScheduleAsync(int businessId, NzPayScheduleModel paySchedule, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayScheduleModel,NzPayScheduleModel>($"/business/{businessId}/payschedule", paySchedule, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Schedule by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay schedule with the specified ID.
        /// </remarks>
        public NzPayScheduleModel GetPayScheduleById(int businessId, int id)
        {
            return ApiRequest<NzPayScheduleModel>($"/business/{businessId}/payschedule/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Schedule by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay schedule with the specified ID.
        /// </remarks>
        public Task<NzPayScheduleModel> GetPayScheduleByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayScheduleModel>($"/business/{businessId}/payschedule/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Schedule
        /// </summary>
        /// <remarks>
        /// Updates the pay schedule with the specified ID.
        /// </remarks>
        public NzPayScheduleModel UpdatePaySchedule(int businessId, int id, NzPayScheduleModel paySchedule)
        {
            return ApiRequest<NzPayScheduleModel,NzPayScheduleModel>($"/business/{businessId}/payschedule/{id}", paySchedule, Method.Put);
        }

        /// <summary>
        /// Update Pay Schedule
        /// </summary>
        /// <remarks>
        /// Updates the pay schedule with the specified ID.
        /// </remarks>
        public Task<NzPayScheduleModel> UpdatePayScheduleAsync(int businessId, int id, NzPayScheduleModel paySchedule, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayScheduleModel,NzPayScheduleModel>($"/business/{businessId}/payschedule/{id}", paySchedule, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Schedule
        /// </summary>
        /// <remarks>
        /// Deletes the pay schedule with the specified ID.
        /// </remarks>
        public void DeletePaySchedule(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/payschedule/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Schedule
        /// </summary>
        /// <remarks>
        /// Deletes the pay schedule with the specified ID.
        /// </remarks>
        public Task DeletePayScheduleAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payschedule/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Next Pay Date
        /// </summary>
        /// <remarks>
        /// Gets the next pay dates for the pay schedule with the specified ID.
        /// </remarks>
        public PayScheduleDateForecastResultApiModel GetNextPayDate(int businessId, int payScheduleId)
        {
            return ApiRequest<PayScheduleDateForecastResultApiModel>($"/business/{businessId}/payschedule/{payScheduleId}/nextpaydate", Method.Get);
        }

        /// <summary>
        /// Get Next Pay Date
        /// </summary>
        /// <remarks>
        /// Gets the next pay dates for the pay schedule with the specified ID.
        /// </remarks>
        public Task<PayScheduleDateForecastResultApiModel> GetNextPayDateAsync(int businessId, int payScheduleId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayScheduleDateForecastResultApiModel>($"/business/{businessId}/payschedule/{payScheduleId}/nextpaydate", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Schedule Metadata
        /// </summary>
        /// <remarks>
        /// Gets the list of all applicable reference data for Pay Schedules for this business.
        /// </remarks>
        public PayScheduleMetaDataModel GetPayScheduleMetadata(int businessId)
        {
            return ApiRequest<PayScheduleMetaDataModel>($"/business/{businessId}/payschedule/metadata", Method.Get);
        }

        /// <summary>
        /// Get Pay Schedule Metadata
        /// </summary>
        /// <remarks>
        /// Gets the list of all applicable reference data for Pay Schedules for this business.
        /// </remarks>
        public Task<PayScheduleMetaDataModel> GetPayScheduleMetadataAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayScheduleMetaDataModel>($"/business/{businessId}/payschedule/metadata", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Next Pay Dates
        /// </summary>
        /// <remarks>
        /// Gets the list of all next pay dates for each pay schedule.
        /// </remarks>
        public List<PayScheduleDateForecastResultApiModel> ListNextPayDates(int businessId)
        {
            return ApiRequest<List<PayScheduleDateForecastResultApiModel>>($"/business/{businessId}/payschedule/nextpaydates", Method.Get);
        }

        /// <summary>
        /// List Next Pay Dates
        /// </summary>
        /// <remarks>
        /// Gets the list of all next pay dates for each pay schedule.
        /// </remarks>
        public Task<List<PayScheduleDateForecastResultApiModel>> ListNextPayDatesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayScheduleDateForecastResultApiModel>>($"/business/{businessId}/payschedule/nextpaydates", Method.Get, cancellationToken);
        }
    }
}
