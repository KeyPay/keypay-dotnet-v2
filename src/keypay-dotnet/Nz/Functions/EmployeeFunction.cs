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
using KeyPayV2.Nz.Models.Employee;

namespace KeyPayV2.Nz.Functions
{
    public interface IEmployeeFunction
    {
        void DeleteEmployee(int businessId, int employeeId);
        Task DeleteEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeDetailsModel GetEmployeeBasicDetailsById(int businessId, int employeeId);
        Task<EmployeeDetailsModel> GetEmployeeBasicDetailsByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void GetEmployeeProfileImage(int businessId, int employeeId);
        Task GetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId);
        Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void DeleteEmployeeProfileImage(int businessId, int employeeId);
        Task DeleteEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId);
        Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request);
        Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default);
        List<EmployeeNoteModel> GetEmployeeNotes(int businessId, int employeeId);
        Task<List<EmployeeNoteModel>> GetEmployeeNotesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetEmployeeNotes(int businessId, int employeeId, CreateEmployeeNoteModel model);
        Task SetEmployeeNotesAsync(int businessId, int employeeId, CreateEmployeeNoteModel model, CancellationToken cancellationToken = default);
        NzOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId);
        Task<NzOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetOpeningBalances(int businessId, int employeeId, NzOpeningBalancesModel model);
        Task SetOpeningBalancesAsync(int businessId, int employeeId, NzOpeningBalancesModel model, CancellationToken cancellationToken = default);
        List<EmployeePayRateModel> GetPayRates(int businessId, int employeeId);
        Task<List<EmployeePayRateModel>> GetPayRatesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<NzWorkTypeModel> GetEmployeeShiftConditions(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<NzWorkTypeModel>> GetEmployeeShiftConditionsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzStandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId);
        Task<NzStandardHoursModel> GetStandardHoursForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        StandardHoursModel SetStandardHoursForEmployee(int businessId, int employeeId, NzStandardHoursModel model);
        Task<StandardHoursModel> SetStandardHoursForEmployeeAsync(int businessId, int employeeId, NzStandardHoursModel model, CancellationToken cancellationToken = default);
        List<NzWorkTypeModel> GetEmployeeWorkTypes(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<NzWorkTypeModel>> GetEmployeeWorkTypesAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void ActivateEmployee(int businessId, int employeeId);
        Task ActivateEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<EmployeeDetailsModel> ListBasicDetailsForEmployees(int businessId, ODataQuery oDataQuery = null);
        Task<List<EmployeeDetailsModel>> ListBasicDetailsForEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void GrantKioskAccess(int businessId, int employeeId);
        Task GrantKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void RevokeKioskAccess(int businessId, int employeeId);
        Task RevokeKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<NzUnstructuredEmployeeModel> ListEmployees(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        List<NzUnstructuredEmployeeModel> ListEmployees(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null);
        Task<List<NzUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, NzUnstructuredEmployeeModel model);
        Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, NzUnstructuredEmployeeModel model, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, NzUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request);
        Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, NzUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request, CancellationToken cancellationToken = default);
        NzUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId);
        Task<NzUnstructuredEmployeeModel> GetEmployeeByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModel UpdateEmployee(int businessId, int employeeId, NzUnstructuredEmployeeModel model);
        Task<EmployeeUpdateResponseModel> UpdateEmployeeAsync(int businessId, int employeeId, NzUnstructuredEmployeeModel model, CancellationToken cancellationToken = default);
        NzUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId);
        Task<NzUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, string externalId, CancellationToken cancellationToken = default);
        NzUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source);
        Task<NzUnstructuredEmployeeModel> GetEmployeeByExternalReferenceIdAsync(int businessId, string externalReferenceId, ExternalService source, CancellationToken cancellationToken = default);
    }
    public class EmployeeFunction : BaseFunction, IEmployeeFunction
    {
        public EmployeeFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <remarks>
        /// Deletes the employee with the specified ID.
        /// </remarks>
        public void DeleteEmployee(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <remarks>
        /// Deletes the employee with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Employee basic details by ID
        /// </summary>
        /// <remarks>
        /// returns the basic employee details for the specified employee
        /// </remarks>
        public EmployeeDetailsModel GetEmployeeBasicDetailsById(int businessId, int employeeId)
        {
            return ApiRequest<EmployeeDetailsModel>($"/business/{businessId}/employee/{employeeId}/details", Method.Get);
        }

        /// <summary>
        /// Get Employee basic details by ID
        /// </summary>
        /// <remarks>
        /// returns the basic employee details for the specified employee
        /// </remarks>
        public Task<EmployeeDetailsModel> GetEmployeeBasicDetailsByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDetailsModel>($"/business/{businessId}/employee/{employeeId}/details", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image", Method.Get);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public Task GetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/image", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/business/{businessId}/employee/{employeeId}/image", Method.Post);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ProfileImageMetadata>($"/business/{businessId}/employee/{employeeId}/image", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public Task DeleteEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/image", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&amalgamateCalculatedAccruals={request.AmalgamateCalculatedAccruals}", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&amalgamateCalculatedAccruals={request.AmalgamateCalculatedAccruals}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Notes
        /// </summary>
        /// <remarks>
        /// Gets the notes for the specified employee.
        /// </remarks>
        public List<EmployeeNoteModel> GetEmployeeNotes(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeNoteModel>>($"/business/{businessId}/employee/{employeeId}/notes", Method.Get);
        }

        /// <summary>
        /// Get Employee Notes
        /// </summary>
        /// <remarks>
        /// Gets the notes for the specified employee.
        /// </remarks>
        public Task<List<EmployeeNoteModel>> GetEmployeeNotesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeNoteModel>>($"/business/{businessId}/employee/{employeeId}/notes", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Employee Notes
        /// </summary>
        /// <remarks>
        /// Sets the notes for the specified employee.
        /// </remarks>
        public void SetEmployeeNotes(int businessId, int employeeId, CreateEmployeeNoteModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/notes", model, Method.Post);
        }

        /// <summary>
        /// Set Employee Notes
        /// </summary>
        /// <remarks>
        /// Sets the notes for the specified employee.
        /// </remarks>
        public Task SetEmployeeNotesAsync(int businessId, int employeeId, CreateEmployeeNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/notes", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public NzOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId)
        {
            return ApiRequest<NzOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.Get);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public Task<NzOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public void SetOpeningBalances(int businessId, int employeeId, NzOpeningBalancesModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.Post);
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public Task SetOpeningBalancesAsync(int businessId, int employeeId, NzOpeningBalancesModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Rates
        /// </summary>
        /// <remarks>
        /// Gets the pay rates for this employee.
        /// </remarks>
        public List<EmployeePayRateModel> GetPayRates(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeePayRateModel>>($"/business/{businessId}/employee/{employeeId}/payrate", Method.Get);
        }

        /// <summary>
        /// Get Pay Rates
        /// </summary>
        /// <remarks>
        /// Gets the pay rates for this employee.
        /// </remarks>
        public Task<List<EmployeePayRateModel>> GetPayRatesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeePayRateModel>>($"/business/{businessId}/employee/{employeeId}/payrate", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Shift Conditions
        /// </summary>
        /// <remarks>
        /// Lists all the shift conditions for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<NzWorkTypeModel> GetEmployeeShiftConditions(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Employee Shift Conditions
        /// </summary>
        /// <remarks>
        /// Lists all the shift conditions for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<NzWorkTypeModel>> GetEmployeeShiftConditionsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public NzStandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<NzStandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", Method.Get);
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public Task<NzStandardHoursModel> GetStandardHoursForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzStandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel SetStandardHoursForEmployee(int businessId, int employeeId, NzStandardHoursModel model)
        {
            return ApiRequest<StandardHoursModel,NzStandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.Put);
        }

        /// <summary>
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public Task<StandardHoursModel> SetStandardHoursForEmployeeAsync(int businessId, int employeeId, NzStandardHoursModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<StandardHoursModel,NzStandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<NzWorkTypeModel> GetEmployeeWorkTypes(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Employee Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<NzWorkTypeModel>> GetEmployeeWorkTypesAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Activate Employee
        /// </summary>
        /// <remarks>
        /// Activates the employee with the specified ID.
        /// </remarks>
        public void ActivateEmployee(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/activate/{employeeId}", Method.Post);
        }

        /// <summary>
        /// Activate Employee
        /// </summary>
        /// <remarks>
        /// Activates the employee with the specified ID.
        /// </remarks>
        public Task ActivateEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/activate/{employeeId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// List basic details for employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of employees. The details are a subset of the 'unstructured' employee endpoint.
        /// This data can be filtered much more efficiently though so if you only need the basic employee details, this endpoint is preferred.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<EmployeeDetailsModel> ListBasicDetailsForEmployees(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/employee/details{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List basic details for employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of employees. The details are a subset of the 'unstructured' employee endpoint.
        /// This data can be filtered much more efficiently though so if you only need the basic employee details, this endpoint is preferred.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<EmployeeDetailsModel>> ListBasicDetailsForEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsModel>>($"/business/{businessId}/employee/details{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Grant Kiosk Access
        /// </summary>
        /// <remarks>
        /// Grants kiosk access to the specified employee.
        /// </remarks>
        public void GrantKioskAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/grantkioskaccess/{employeeId}", Method.Post);
        }

        /// <summary>
        /// Grant Kiosk Access
        /// </summary>
        /// <remarks>
        /// Grants kiosk access to the specified employee.
        /// </remarks>
        public Task GrantKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/grantkioskaccess/{employeeId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Revoke Kiosk Access
        /// </summary>
        /// <remarks>
        /// Revokes kiosk access from the specified employee.
        /// </remarks>
        public void RevokeKioskAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/revokekioskaccess/{employeeId}", Method.Post);
        }

        /// <summary>
        /// Revoke Kiosk Access
        /// </summary>
        /// <remarks>
        /// Revokes kiosk access from the specified employee.
        /// </remarks>
        public Task RevokeKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/revokekioskaccess/{employeeId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns the unstructured employee details for all matching employees.
        /// <p>
        /// See also: List basic details for employees (which is much more efficient if that is all the information that is required)
        /// </p>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzUnstructuredEmployeeModel> ListEmployees(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns the unstructured employee details for all matching employees.
        /// <p>
        /// See also: List basic details for employees (which is much more efficient if that is all the information that is required)
        /// </p>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns the unstructured employee details for all matching employees.
        /// <p>
        /// See also: List basic details for employees (which is much more efficient if that is all the information that is required)
        /// </p>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzUnstructuredEmployeeModel> ListEmployees(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.Get);
        }

        /// <summary>
        /// List Employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns the unstructured employee details for all matching employees.
        /// <p>
        /// See also: List basic details for employees (which is much more efficient if that is all the information that is required)
        /// </p>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create or Update Employee
        /// </summary>
        /// <remarks>
        /// <p>If an ID is passed or an existing employee is matched (according to the matchType parameter), it will
        ///             be updated. Otherwise a new employee will be created. 
        ///             </p>
        /// <p>
        ///             MatchType parameter values:
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the IRD number,
        ///                     then based on first name + surname + date of birth 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields; firstName, surname, startDate, employmentType,
        ///             taxCodeDeclaration_IrdNumber, taxCodeDeclaration_EsctRate, kiwiSaver_EnrollmentStatus.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>Tax Code Declaration (Tax Code and Employment Type)</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Kiwi Saver Contribution Plan</li></list></p>
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, NzUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.Post);
        }

        /// <summary>
        /// Create or Update Employee
        /// </summary>
        /// <remarks>
        /// <p>If an ID is passed or an existing employee is matched (according to the matchType parameter), it will
        ///             be updated. Otherwise a new employee will be created. 
        ///             </p>
        /// <p>
        ///             MatchType parameter values:
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the IRD number,
        ///                     then based on first name + surname + date of birth 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields; firstName, surname, startDate, employmentType,
        ///             taxCodeDeclaration_IrdNumber, taxCodeDeclaration_EsctRate, kiwiSaver_EnrollmentStatus.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>Tax Code Declaration (Tax Code and Employment Type)</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Kiwi Saver Contribution Plan</li></list></p>
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, NzUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create or Update Employee
        /// </summary>
        /// <remarks>
        /// <p>If an ID is passed or an existing employee is matched (according to the matchType parameter), it will
        ///             be updated. Otherwise a new employee will be created. 
        ///             </p>
        /// <p>
        ///             MatchType parameter values:
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the IRD number,
        ///                     then based on first name + surname + date of birth 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields; firstName, surname, startDate, employmentType,
        ///             taxCodeDeclaration_IrdNumber, taxCodeDeclaration_EsctRate, kiwiSaver_EnrollmentStatus.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>Tax Code Declaration (Tax Code and Employment Type)</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Kiwi Saver Contribution Plan</li></list></p>
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, NzUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request)
        {
            return ApiRequest<EmployeeUpdateResponseModel,NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.Post);
        }

        /// <summary>
        /// Create or Update Employee
        /// </summary>
        /// <remarks>
        /// <p>If an ID is passed or an existing employee is matched (according to the matchType parameter), it will
        ///             be updated. Otherwise a new employee will be created. 
        ///             </p>
        /// <p>
        ///             MatchType parameter values:
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the IRD number,
        ///                     then based on first name + surname + date of birth 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields; firstName, surname, startDate, employmentType,
        ///             taxCodeDeclaration_IrdNumber, taxCodeDeclaration_EsctRate, kiwiSaver_EnrollmentStatus.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>Tax Code Declaration (Tax Code and Employment Type)</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Kiwi Saver Contribution Plan</li></list></p>
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, NzUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public NzUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId)
        {
            return ApiRequest<NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public Task<NzUnstructuredEmployeeModel> GetEmployeeByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// Only fields to be updated need be specified. Fields left unspecified or null will not be changed.
        /// To update a field provide the new value, to specifically clear a value use the string "(clear)".
        /// </remarks>
        public EmployeeUpdateResponseModel UpdateEmployee(int businessId, int employeeId, NzUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// Only fields to be updated need be specified. Fields left unspecified or null will not be changed.
        /// To update a field provide the new value, to specifically clear a value use the string "(clear)".
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> UpdateEmployeeAsync(int businessId, int employeeId, NzUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public NzUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId)
        {
            return ApiRequest<NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}", Method.Get);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public Task<NzUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, string externalId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public NzUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source)
        {
            return ApiRequest<NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}", Method.Get);
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public Task<NzUnstructuredEmployeeModel> GetEmployeeByExternalReferenceIdAsync(int businessId, string externalReferenceId, ExternalService source, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}", Method.Get, cancellationToken);
        }
    }
}
