using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Employee;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeFunction : BaseFunction
    {
        public EmployeeFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, GetEmployeeByExternalIdQueryModel request)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee?externalId={request.ExternalId}");
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <remarks>
        /// Deletes the employee with the specified ID.
        /// </remarks>
        public void DeleteEmployee(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}", Method.DELETE);
        }

        /// <summary>
        /// Get Employee basic details by ID
        /// </summary>
        /// <remarks>
        /// returns the basic employee details for the specified employee
        /// </remarks>
        public EmployeeDetailsModel GetEmployeeBasicDetailsById(int businessId, int employeeId)
        {
            return ApiRequest<EmployeeDetailsModel>($"/business/{businessId}/employee/{employeeId}/details");
        }

        /// <summary>
        /// Gets hmrc forms view model for employee
        /// </summary>
        public HmrcFormsViewModel GetsHmrcFormsViewModelForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<HmrcFormsViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms");
        }

        /// <summary>
        /// Create auto enrolment notice
        /// </summary>
        public AutoEnrolmentNoticeModel CreateAutoEnrolmentNotice(int businessId, int employeeId, AutoEnrolmentNoticeModel notice)
        {
            return ApiRequest<AutoEnrolmentNoticeModel,AutoEnrolmentNoticeModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/autoenrolmentnotice", notice, Method.POST);
        }

        /// <summary>
        /// Send auto-enrolment notification to employee
        /// </summary>
        public AutoEnrolmentNoticeViewModel SendAutoEnrolmentNotificationToEmployee(int businessId, int employeeId, int noticeId)
        {
            return ApiRequest<AutoEnrolmentNoticeViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/emailautoenrolmentnotice/{noticeId}", Method.POST);
        }

        /// <summary>
        /// Send P45-email to employee
        /// </summary>
        public P45ViewModel SendP45EmailToEmployee(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/mailp45", Method.POST);
        }

        /// <summary>
        /// Get P45 model for employee
        /// </summary>
        public P45ViewModel GetP45ModelForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45");
        }

        public P45ViewModel UkHmrcForms_P45Download(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45download");
        }

        /// <summary>
        /// Get P60 model for employee
        /// </summary>
        public P60ViewModel GetP60ModelForEmployee(int businessId, int employeeId, int financialYearEnding)
        {
            return ApiRequest<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60/{financialYearEnding}");
        }

        public P60ViewModel UkHmrcForms_P60DownloadController(int businessId, int employeeId, int financialYearEnding)
        {
            return ApiRequest<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60download/{financialYearEnding}");
        }

        /// <summary>
        /// Notify employee by email of P60
        /// </summary>
        public P60GridViewModel NotifyEmployeeByEmailOfP60(int businessId, int employeeId, int noticeId, int financialYearEnding)
        {
            return ApiRequest<P60GridViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60notify/{noticeId}/{financialYearEnding}", Method.POST);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image");
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/business/{businessId}/employee/{employeeId}/image", Method.POST);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image", Method.DELETE);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Get National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Get the National Insurance Record and P45 for the Employee
        /// </remarks>
        public TaxNationalInsuranceEditModel GetNationalInsuranceRecordAndP45(int businessId, int employeeId)
        {
            return ApiRequest<TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord");
        }

        /// <summary>
        /// Update National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Update the National Insurance Record and P45 for the Employee
        /// </remarks>
        public TaxNationalInsuranceEditModel UpdateNationalInsuranceRecordAndP45(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel)
        {
            return ApiRequest<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.PUT);
        }

        /// <summary>
        /// Create National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Creates a new Create Tax National Insurance Record and P45 for the Employee.
        /// </remarks>
        public TaxNationalInsuranceEditModel CreateNationalInsuranceRecordAndP45(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel)
        {
            return ApiRequest<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.POST);
        }

        /// <summary>
        /// Get Employee Notes
        /// </summary>
        /// <remarks>
        /// Gets the notes for the specified employee.
        /// </remarks>
        public List<EmployeeNoteModel> GetEmployeeNotes(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeNoteModel>>($"/business/{businessId}/employee/{employeeId}/notes");
        }

        /// <summary>
        /// Set Employee Notes
        /// </summary>
        /// <remarks>
        /// Sets the notes for the specified employee.
        /// </remarks>
        public void SetEmployeeNotes(int businessId, int employeeId, CreateEmployeeNoteModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public UkOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId)
        {
            return ApiRequest<UkOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances");
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public void SetOpeningBalances(int businessId, int employeeId, UkOpeningBalancesModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.POST);
        }

        /// <summary>
        /// Get Pay Rates
        /// </summary>
        /// <remarks>
        /// Gets the pay rates for this employee.
        /// </remarks>
        public List<EmployeePayRateModel> GetPayRates(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeePayRateModel>>($"/business/{businessId}/employee/{employeeId}/payrate");
        }

        /// <summary>
        /// Get Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get Pension Contribution Plan settings for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel GetPensionContributionPlan(int businessId, int employeeId)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension");
        }

        /// <summary>
        /// Update Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Update Pension Contribution Plan settings for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel UpdatePensionContributionPlan(int businessId, int employeeId, EmployeePensionContributionPlanSettingsApiModel model)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel,EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", model, Method.PUT);
        }

        /// <summary>
        /// Force Enrolment
        /// </summary>
        /// <remarks>
        /// Force Enrolment to Pension Contribution Plan for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel ForceEnrolment(int businessId, int employeeId)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension/force", Method.POST);
        }

        /// <summary>
        /// Get Employee Shift Conditions
        /// </summary>
        /// <remarks>
        /// Lists all the shift conditions for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<WorkTypeModel> GetEmployeeShiftConditions(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<WorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours");
        }

        /// <summary>
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel SetStandardHoursForEmployee(int businessId, int employeeId, StandardHoursModel model)
        {
            return ApiRequest<StandardHoursModel,StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.PUT);
        }

        /// <summary>
        /// Create Statutory Adoption Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Adoption Leave period for an employee
        /// </remarks>
        public UkSapDataApiResponseModel CreateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, UkSapDataApiModel sap)
        {
            return ApiRequest<UkSapDataApiResponseModel,UkSapDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap", sap, Method.POST);
        }

        /// <summary>
        /// Calculate Statutory Adoption Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Adoption Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSapCalcApiModel CalculateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSapCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sapcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public UkSmpDataApiModel GetStatutoryMaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Create Statutory Maternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Maternity Leave period for an employee
        /// </remarks>
        public UkSmpDataApiResponseModel CreateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, UkSmpDataApiModel smp)
        {
            return ApiRequest<UkSmpDataApiResponseModel,UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp", smp, Method.POST);
        }

        /// <summary>
        /// Delete Statutory Maternity Leave Data
        /// </summary>
        public void DeleteStatutoryMaternityLeaveData(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.DELETE);
        }

        /// <summary>
        /// Calculate Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSmpCalcApiModel CalculateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Create Statutory Parental Bereavement Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Parental Bereavement Leave period for an employee
        /// </remarks>
        public UkSpbpDataApiResponseModel CreateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, UkSpbpDataApiModel spbp)
        {
            return ApiRequest<UkSpbpDataApiResponseModel,UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp", spbp, Method.POST);
        }

        /// <summary>
        /// Calculate Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSpbpCalcApiModel CalculateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSpbpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public UkSppDataApiModel GetStatutoryPaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Create Statutory Paternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Paternity Leave period for an employee
        /// </remarks>
        public UkSppDataApiResponseModel CreateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, UkSppDataApiModel spp)
        {
            return ApiRequest<UkSppDataApiResponseModel,UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp", spp, Method.POST);
        }

        /// <summary>
        /// Calculate Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSppCalcApiModel CalculateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSppCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Statutory Sick Pay By Employee
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay records for the employee between the specified dates
        /// </remarks>
        public List<UkSspApiModel> GetStatutorySickPayByEmployee(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request)
        {
            return ApiRequest<List<UkSspApiModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Create Statutory Sick Pay
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Sick Pay leave period for an employee
        /// </remarks>
        public UkSspApiModel CreateStatutorySickPay(int businessId, int employeeId, UkSspApiModel ssp)
        {
            return ApiRequest<UkSspApiModel,UkSspApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp", ssp, Method.POST);
        }

        /// <summary>
        /// Sync Employee to QBO
        /// </summary>
        /// <remarks>
        /// Syncs an employee record to QBO.
        /// </remarks>
        public void SyncEmployeeToQbo(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/synctoqbo", Method.POST);
        }

        /// <summary>
        /// Get Employee Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<WorkTypeModel> GetEmployeeWorkTypes(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<WorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Activate Employee
        /// </summary>
        /// <remarks>
        /// Activates the employee with the specified ID.
        /// </remarks>
        public void ActivateEmployee(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/activate/{employeeId}", Method.POST);
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
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/employee/details{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Grant Kiosk Access
        /// </summary>
        /// <remarks>
        /// Grants kiosk access to the specified employee.
        /// </remarks>
        public void GrantKioskAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/grantkioskaccess/{employeeId}", Method.POST);
        }

        /// <summary>
        /// Revoke Kiosk Access
        /// </summary>
        /// <remarks>
        /// Revokes kiosk access from the specified employee.
        /// </remarks>
        public void RevokeKioskAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/revokekioskaccess/{employeeId}", Method.POST);
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
        public List<UkUnstructuredEmployeeModel> ListEmployees(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}");
        }

        /// <summary>
        /// Create or Update Employee
        /// </summary>
        /// <remarks>
        /// If the employee with the specified ID already exists, update it. Otherwise, create a new employee.
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.POST);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}");
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// </remarks>
        public EmployeeUpdateResponseModel UpdateEmployee(int businessId, int employeeId, UkUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.PUT);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}");
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}");
        }
    }
}
