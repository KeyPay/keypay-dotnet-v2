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
using KeyPayV2.Au.Models.EmploymentAgreement;

namespace KeyPayV2.Au.Functions
{
    public interface IEmploymentAgreementFunction
    {
        ShiftCostingsResponseModel GetShiftCostingsForEmployee(int businessId, int employeeId, ShiftCostingsRequestModel model);
        Task<ShiftCostingsResponseModel> GetShiftCostingsForEmployeeAsync(int businessId, int employeeId, ShiftCostingsRequestModel model, CancellationToken cancellationToken = default);
        List<ShiftPeriodModel> GetShiftPeriodsForEmployee(int businessId, int employeeId, GetShiftPeriodsModel model);
        Task<List<ShiftPeriodModel>> GetShiftPeriodsForEmployeeAsync(int businessId, int employeeId, GetShiftPeriodsModel model, CancellationToken cancellationToken = default);
        List<BasicEmploymentAgreementModel> ListEmploymentAgreements(int businessId, ODataQuery oDataQuery = null);
        Task<List<BasicEmploymentAgreementModel>> ListEmploymentAgreementsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        EmploymentAgreementModel GetEmploymentAgreementById(int businessId, int id);
        Task<EmploymentAgreementModel> GetEmploymentAgreementByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        ShiftCostingsResponseModel EvaluateShiftCostings(int businessId, int id, ShiftCostingsRequestModel model);
        Task<ShiftCostingsResponseModel> EvaluateShiftCostingsAsync(int businessId, int id, ShiftCostingsRequestModel model, CancellationToken cancellationToken = default);
        List<ShiftCostingsResponseModel> BulkEvaluateShiftCostings(int businessId, int id, List<ShiftCostingsRequestModel> requests);
        Task<List<ShiftCostingsResponseModel>> BulkEvaluateShiftCostingsAsync(int businessId, int id, List<ShiftCostingsRequestModel> requests, CancellationToken cancellationToken = default);
        List<ShiftPeriodModel> GetShiftPeriods(int businessId, int id, GetShiftPeriodsModel model);
        Task<List<ShiftPeriodModel>> GetShiftPeriodsAsync(int businessId, int id, GetShiftPeriodsModel model, CancellationToken cancellationToken = default);
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

        /// <summary>
        /// List Employment Agreements
        /// </summary>
        /// <remarks>
        /// Lists all of the employment agreements for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<BasicEmploymentAgreementModel> ListEmploymentAgreements(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<BasicEmploymentAgreementModel>>($"/business/{businessId}/employmentagreement{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employment Agreements
        /// </summary>
        /// <remarks>
        /// Lists all of the employment agreements for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<BasicEmploymentAgreementModel>> ListEmploymentAgreementsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BasicEmploymentAgreementModel>>($"/business/{businessId}/employmentagreement{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employment Agreement by ID
        /// </summary>
        /// <remarks>
        /// Gets the employment agreement with the specified ID.
        /// </remarks>
        public EmploymentAgreementModel GetEmploymentAgreementById(int businessId, int id)
        {
            return ApiRequest<EmploymentAgreementModel>($"/business/{businessId}/employmentagreement/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employment Agreement by ID
        /// </summary>
        /// <remarks>
        /// Gets the employment agreement with the specified ID.
        /// </remarks>
        public Task<EmploymentAgreementModel> GetEmploymentAgreementByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmploymentAgreementModel>($"/business/{businessId}/employmentagreement/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Evaluate Shift Costings
        /// </summary>
        /// <remarks>
        /// Evaluates shift costings for the employment agreement with the specified ID.
        /// </remarks>
        public ShiftCostingsResponseModel EvaluateShiftCostings(int businessId, int id, ShiftCostingsRequestModel model)
        {
            return ApiRequest<ShiftCostingsResponseModel,ShiftCostingsRequestModel>($"/business/{businessId}/employmentagreement/{id}/shiftcosting", model, Method.Post);
        }

        /// <summary>
        /// Evaluate Shift Costings
        /// </summary>
        /// <remarks>
        /// Evaluates shift costings for the employment agreement with the specified ID.
        /// </remarks>
        public Task<ShiftCostingsResponseModel> EvaluateShiftCostingsAsync(int businessId, int id, ShiftCostingsRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ShiftCostingsResponseModel,ShiftCostingsRequestModel>($"/business/{businessId}/employmentagreement/{id}/shiftcosting", model, Method.Post, cancellationToken);
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
            return ApiRequest<List<ShiftCostingsResponseModel>,List<ShiftCostingsRequestModel>>($"/business/{businessId}/employmentagreement/{id}/shiftcosting/bulk", requests, Method.Post);
        }

        /// <summary>
        /// Bulk Evaluate Shift Costings
        /// </summary>
        /// <remarks>
        /// Bulk Evaluates shift costings for the employment agreement with the specified ID.
        /// Limited to 100 entries per request
        /// </remarks>
        public Task<List<ShiftCostingsResponseModel>> BulkEvaluateShiftCostingsAsync(int businessId, int id, List<ShiftCostingsRequestModel> requests, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftCostingsResponseModel>,List<ShiftCostingsRequestModel>>($"/business/{businessId}/employmentagreement/{id}/shiftcosting/bulk", requests, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Shift Periods
        /// </summary>
        /// <remarks>
        /// Gets all the shift periods for the employment agreement with the specified ID.
        /// </remarks>
        public List<ShiftPeriodModel> GetShiftPeriods(int businessId, int id, GetShiftPeriodsModel model)
        {
            return ApiRequest<List<ShiftPeriodModel>,GetShiftPeriodsModel>($"/business/{businessId}/employmentagreement/{id}/shiftperiods", model, Method.Post);
        }

        /// <summary>
        /// Get Shift Periods
        /// </summary>
        /// <remarks>
        /// Gets all the shift periods for the employment agreement with the specified ID.
        /// </remarks>
        public Task<List<ShiftPeriodModel>> GetShiftPeriodsAsync(int businessId, int id, GetShiftPeriodsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftPeriodModel>,GetShiftPeriodsModel>($"/business/{businessId}/employmentagreement/{id}/shiftperiods", model, Method.Post, cancellationToken);
        }
    }
}
