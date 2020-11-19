using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmploymentAgreement;

namespace KeyPayV2.Uk.Functions
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

        /// <summary>
        /// List Employment Agreements
        /// </summary>
        /// <remarks>
        /// Lists all of the employment agreements for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<BasicEmploymentAgreementModel> ListEmploymentAgreements(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<BasicEmploymentAgreementModel>>($"/business/{businessId}/employmentagreement{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Get Employment Agreement by ID
        /// </summary>
        /// <remarks>
        /// Gets the employment agreement with the specified ID.
        /// </remarks>
        public EmploymentAgreementModel GetEmploymentAgreementById(int businessId, int id)
        {
            return ApiRequest<EmploymentAgreementModel>($"/business/{businessId}/employmentagreement/{id}");
        }

        /// <summary>
        /// Evaluate Shift Costings
        /// </summary>
        /// <remarks>
        /// Evaluates shift costings for the employment agreement with the specified ID.
        /// </remarks>
        public ShiftCostingsResponseModel EvaluateShiftCostings(int businessId, int id, ShiftCostingsRequestModel model)
        {
            return ApiRequest<ShiftCostingsResponseModel,ShiftCostingsRequestModel>($"/business/{businessId}/employmentagreement/{id}/shiftcosting", model, Method.POST);
        }

        /// <summary>
        /// Bulk Evaluate Shift Costings
        /// </summary>
        /// <remarks>
        /// Bulk Evaluates shift costings for the employment agreement with the specified ID.
        /// Limited to 100 entries per request
        /// </remarks>
        public List<ShiftCostingsResponseModel> BulkEvaluateShiftCostings(int businessId, int id, List<ShiftCostingsRequestModel> requests)
        {
            return ApiRequest<List<ShiftCostingsResponseModel>,List<ShiftCostingsRequestModel>>($"/business/{businessId}/employmentagreement/{id}/shiftcosting/bulk", requests, Method.POST);
        }

        /// <summary>
        /// Get Shift Periods
        /// </summary>
        /// <remarks>
        /// Gets all the shift periods for the employment agreement with the specified ID.
        /// </remarks>
        public List<ShiftPeriodModel> GetShiftPeriods(int businessId, int id, GetShiftPeriodsModel model)
        {
            return ApiRequest<List<ShiftPeriodModel>,GetShiftPeriodsModel>($"/business/{businessId}/employmentagreement/{id}/shiftperiods", model, Method.POST);
        }
    }
}
