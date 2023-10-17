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
using KeyPayV2.Uk.Models.EmploymentAgreement;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmploymentAgreementFunction
    {
        ShiftCostingsResponseModel GetShiftCostingsForEmployee(int businessId, int employeeId, ShiftCostingsRequestModel model);
        Task<ShiftCostingsResponseModel> GetShiftCostingsForEmployeeAsync(int businessId, int employeeId, ShiftCostingsRequestModel model, CancellationToken cancellationToken = default);
        List<ShiftPeriodModel> GetShiftPeriodsForEmployee(int businessId, int employeeId, GetShiftPeriodsModel model);
        Task<List<ShiftPeriodModel>> GetShiftPeriodsForEmployeeAsync(int businessId, int employeeId, GetShiftPeriodsModel model, CancellationToken cancellationToken = default);
    }
    public class EmploymentAgreementFunction : BaseFunction, IEmploymentAgreementFunction
    {
        public EmploymentAgreementFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Shift Costings for Employee
        /// </summary>
        /// <remarks>
        /// Gets the shift costings for the specified employee.
        /// </remarks>
        public ShiftCostingsResponseModel GetShiftCostingsForEmployee(int businessId, int employeeId, ShiftCostingsRequestModel model)
        {
            return ApiRequest<ShiftCostingsResponseModel,ShiftCostingsRequestModel>($"/business/{businessId}/employee/{employeeId}/timesheet/shiftcosting", model, Method.Post);
        }

        /// <summary>
        /// Get Shift Costings for Employee
        /// </summary>
        /// <remarks>
        /// Gets the shift costings for the specified employee.
        /// </remarks>
        public Task<ShiftCostingsResponseModel> GetShiftCostingsForEmployeeAsync(int businessId, int employeeId, ShiftCostingsRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ShiftCostingsResponseModel,ShiftCostingsRequestModel>($"/business/{businessId}/employee/{employeeId}/timesheet/shiftcosting", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Shift Periods for Employee
        /// </summary>
        /// <remarks>
        /// Gets the shift periods for the specified employee.
        /// </remarks>
        public List<ShiftPeriodModel> GetShiftPeriodsForEmployee(int businessId, int employeeId, GetShiftPeriodsModel model)
        {
            return ApiRequest<List<ShiftPeriodModel>,GetShiftPeriodsModel>($"/business/{businessId}/employee/{employeeId}/timesheet/shiftperiods", model, Method.Post);
        }

        /// <summary>
        /// Get Shift Periods for Employee
        /// </summary>
        /// <remarks>
        /// Gets the shift periods for the specified employee.
        /// </remarks>
        public Task<List<ShiftPeriodModel>> GetShiftPeriodsForEmployeeAsync(int businessId, int employeeId, GetShiftPeriodsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftPeriodModel>,GetShiftPeriodsModel>($"/business/{businessId}/employee/{employeeId}/timesheet/shiftperiods", model, Method.Post, cancellationToken);
        }
    }
}
