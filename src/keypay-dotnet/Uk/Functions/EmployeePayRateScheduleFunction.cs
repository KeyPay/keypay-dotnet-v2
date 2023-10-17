using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeePayRateSchedule;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeePayRateScheduleFunction
    {
        List<PayRateScheduleModel> ListPayRateAdjustmentSchedule(int businessId, int employeeId);
        Task<List<PayRateScheduleModel>> ListPayRateAdjustmentScheduleAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        PayRateScheduleModel CreatePayRateAdjustmentScheduleRecord(int businessId, int employeeId, PayRateScheduleModel model);
        Task<PayRateScheduleModel> CreatePayRateAdjustmentScheduleRecordAsync(int businessId, int employeeId, PayRateScheduleModel model, CancellationToken cancellationToken = default);
        PayRateScheduleModel UpdatePayRateAdjustmentScheduleRecord(int businessId, int employeeId, int id, PayRateScheduleModel model);
        Task<PayRateScheduleModel> UpdatePayRateAdjustmentScheduleRecordAsync(int businessId, int employeeId, int id, PayRateScheduleModel model, CancellationToken cancellationToken = default);
        void DeletePayRateAdjustmentScheduleRecord(int businessId, int employeeId, int id);
        Task DeletePayRateAdjustmentScheduleRecordAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        PayRateScheduleModel GetPayRateAdjustmentScheduleRecordById(int businessId, int employeeId, int recordId);
        Task<PayRateScheduleModel> GetPayRateAdjustmentScheduleRecordByIdAsync(int businessId, int employeeId, int recordId, CancellationToken cancellationToken = default);
    }
    public class EmployeePayRateScheduleFunction : BaseFunction, IEmployeePayRateScheduleFunction
    {
        public EmployeePayRateScheduleFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List pay rate adjustment schedule
        /// </summary>
        /// <remarks>
        /// Lists pay rate adjustment schedule for this employee.
        /// </remarks>
        public List<PayRateScheduleModel> ListPayRateAdjustmentSchedule(int businessId, int employeeId)
        {
            return ApiRequest<List<PayRateScheduleModel>>($"/business/{businessId}/employee/{employeeId}/payrateschedule", Method.Get);
        }

        /// <summary>
        /// List pay rate adjustment schedule
        /// </summary>
        /// <remarks>
        /// Lists pay rate adjustment schedule for this employee.
        /// </remarks>
        public Task<List<PayRateScheduleModel>> ListPayRateAdjustmentScheduleAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRateScheduleModel>>($"/business/{businessId}/employee/{employeeId}/payrateschedule", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Creates a new pay rate adjustment schedule record for the employee.
        /// </remarks>
        public PayRateScheduleModel CreatePayRateAdjustmentScheduleRecord(int businessId, int employeeId, PayRateScheduleModel model)
        {
            return ApiRequest<PayRateScheduleModel,PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule", model, Method.Post);
        }

        /// <summary>
        /// Create pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Creates a new pay rate adjustment schedule record for the employee.
        /// </remarks>
        public Task<PayRateScheduleModel> CreatePayRateAdjustmentScheduleRecordAsync(int businessId, int employeeId, PayRateScheduleModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRateScheduleModel,PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Updates the employee's pay rate adjustment schedule record with the specified ID.
        /// </remarks>
        public PayRateScheduleModel UpdatePayRateAdjustmentScheduleRecord(int businessId, int employeeId, int id, PayRateScheduleModel model)
        {
            return ApiRequest<PayRateScheduleModel,PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Updates the employee's pay rate adjustment schedule record with the specified ID.
        /// </remarks>
        public Task<PayRateScheduleModel> UpdatePayRateAdjustmentScheduleRecordAsync(int businessId, int employeeId, int id, PayRateScheduleModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRateScheduleModel,PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Deletes the employee's pay rate adjustment schedule record with the specified ID.
        /// </remarks>
        public void DeletePayRateAdjustmentScheduleRecord(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/payrateschedule/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Deletes the employee's pay rate adjustment schedule record with the specified ID.
        /// </remarks>
        public Task DeletePayRateAdjustmentScheduleRecordAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/payrateschedule/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get pay rate adjustment schedule record by ID
        /// </summary>
        /// <remarks>
        /// Gets pay rate adjustment schedule record for this employee with the specified ID.
        /// </remarks>
        public PayRateScheduleModel GetPayRateAdjustmentScheduleRecordById(int businessId, int employeeId, int recordId)
        {
            return ApiRequest<PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule/{recordId}", Method.Get);
        }

        /// <summary>
        /// Get pay rate adjustment schedule record by ID
        /// </summary>
        /// <remarks>
        /// Gets pay rate adjustment schedule record for this employee with the specified ID.
        /// </remarks>
        public Task<PayRateScheduleModel> GetPayRateAdjustmentScheduleRecordByIdAsync(int businessId, int employeeId, int recordId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule/{recordId}", Method.Get, cancellationToken);
        }
    }
}
