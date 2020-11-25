using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.EmployeePayRateSchedule;

namespace KeyPayV2.Nz.Functions
{
    public class EmployeePayRateScheduleFunction : BaseFunction
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
            return ApiRequest<List<PayRateScheduleModel>>($"/business/{businessId}/employee/{employeeId}/payrateschedule");
        }

        /// <summary>
        /// Create pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Creates a new pay rate adjustment schedule record for the employee.
        /// </remarks>
        public PayRateScheduleModel CreatePayRateAdjustmentScheduleRecord(int businessId, int employeeId, PayRateScheduleModel model)
        {
            return ApiRequest<PayRateScheduleModel,PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule", model, Method.POST);
        }

        /// <summary>
        /// Update pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Updates the employee's pay rate adjustment schedule record with the specified ID.
        /// </remarks>
        public PayRateScheduleModel UpdatePayRateAdjustmentScheduleRecord(int businessId, int employeeId, int id, PayRateScheduleModel model)
        {
            return ApiRequest<PayRateScheduleModel,PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete pay rate adjustment schedule record
        /// </summary>
        /// <remarks>
        /// Deletes the employee's pay rate adjustment schedule record with the specified ID.
        /// </remarks>
        public void DeletePayRateAdjustmentScheduleRecord(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/payrateschedule/{id}", Method.DELETE);
        }

        /// <summary>
        /// Get pay rate adjustment schedule record by ID
        /// </summary>
        /// <remarks>
        /// Gets pay rate adjustment schedule record for this employee with the specified ID.
        /// </remarks>
        public PayRateScheduleModel GetPayRateAdjustmentScheduleRecordById(int businessId, int employeeId, int recordId)
        {
            return ApiRequest<PayRateScheduleModel>($"/business/{businessId}/employee/{employeeId}/payrateschedule/{recordId}");
        }
    }
}
