using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmploymentAgreement;

namespace KeyPayV2.Sg.Functions
{
    public class EmploymentAgreementFunction : BaseFunction
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
            return ApiRequest<ShiftCostingsResponseModel,ShiftCostingsRequestModel>($"/business/{businessId}/employee/{employeeId}/timesheet/shiftcosting", model, Method.POST);
        }

        /// <summary>
        /// Get Shift Periods for Employee
        /// </summary>
        /// <remarks>
        /// Gets the shift periods for the specified employee.
        /// </remarks>
        public List<ShiftPeriodModel> GetShiftPeriodsForEmployee(int businessId, int employeeId, GetShiftPeriodsModel model)
        {
            return ApiRequest<List<ShiftPeriodModel>,GetShiftPeriodsModel>($"/business/{businessId}/employee/{employeeId}/timesheet/shiftperiods", model, Method.POST);
        }
    }
}
