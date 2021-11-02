using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee?externalId={request.ExternalId}", Method.GET);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, GetEmployeeByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee?externalId={request.ExternalId}", Method.GET, cancellationToken);
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
        /// Delete Employee
        /// </summary>
        /// <remarks>
        /// Deletes the employee with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Employee basic details by ID
        /// </summary>
        /// <remarks>
        /// returns the basic employee details for the specified employee
        /// </remarks>
        public EmployeeDetailsModel GetEmployeeBasicDetailsById(int businessId, int employeeId)
        {
            return ApiRequest<EmployeeDetailsModel>($"/business/{businessId}/employee/{employeeId}/details", Method.GET);
        }

        /// <summary>
        /// Get Employee basic details by ID
        /// </summary>
        /// <remarks>
        /// returns the basic employee details for the specified employee
        /// </remarks>
        public Task<EmployeeDetailsModel> GetEmployeeBasicDetailsByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDetailsModel>($"/business/{businessId}/employee/{employeeId}/details", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Gets hmrc forms view model for employee
        /// </summary>
        public HmrcFormsViewModel GetsHmrcFormsViewModelForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<HmrcFormsViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms", Method.GET);
        }

        /// <summary>
        /// Gets hmrc forms view model for employee
        /// </summary>
        public Task<HmrcFormsViewModel> GetsHmrcFormsViewModelForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HmrcFormsViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create auto enrolment notice
        /// </summary>
        public AutoEnrolmentNoticeModel CreateAutoEnrolmentNotice(int businessId, int employeeId, AutoEnrolmentNoticeModel notice)
        {
            return ApiRequest<AutoEnrolmentNoticeModel,AutoEnrolmentNoticeModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/autoenrolmentnotice", notice, Method.POST);
        }

        /// <summary>
        /// Create auto enrolment notice
        /// </summary>
        public Task<AutoEnrolmentNoticeModel> CreateAutoEnrolmentNoticeAsync(int businessId, int employeeId, AutoEnrolmentNoticeModel notice, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AutoEnrolmentNoticeModel,AutoEnrolmentNoticeModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/autoenrolmentnotice", notice, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Send auto-enrolment notification to employee
        /// </summary>
        public AutoEnrolmentNoticeViewModel SendAutoEnrolmentNotificationToEmployee(int businessId, int employeeId, int noticeId)
        {
            return ApiRequest<AutoEnrolmentNoticeViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/emailautoenrolmentnotice/{noticeId}", Method.POST);
        }

        /// <summary>
        /// Send auto-enrolment notification to employee
        /// </summary>
        public Task<AutoEnrolmentNoticeViewModel> SendAutoEnrolmentNotificationToEmployeeAsync(int businessId, int employeeId, int noticeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AutoEnrolmentNoticeViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/emailautoenrolmentnotice/{noticeId}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Send P45-email to employee
        /// </summary>
        public P45ViewModel SendP45EmailToEmployee(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/mailp45", Method.POST);
        }

        /// <summary>
        /// Send P45-email to employee
        /// </summary>
        public Task<P45ViewModel> SendP45EmailToEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/mailp45", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get P45 model for employee
        /// </summary>
        public P45ViewModel GetP45ModelForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45", Method.GET);
        }

        /// <summary>
        /// Get P45 model for employee
        /// </summary>
        public Task<P45ViewModel> GetP45ModelForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45", Method.GET, cancellationToken);
        }

        public P45ViewModel UkHmrcForms_P45Download(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45download", Method.GET);
        }

        public Task<P45ViewModel> UkHmrcForms_P45DownloadAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45download", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get P60 model for employee
        /// </summary>
        public P60ViewModel GetP60ModelForEmployee(int businessId, int employeeId, int financialYearEnding)
        {
            return ApiRequest<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60/{financialYearEnding}", Method.GET);
        }

        /// <summary>
        /// Get P60 model for employee
        /// </summary>
        public Task<P60ViewModel> GetP60ModelForEmployeeAsync(int businessId, int employeeId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60/{financialYearEnding}", Method.GET, cancellationToken);
        }

        public P60ViewModel UkHmrcForms_P60DownloadController(int businessId, int employeeId, int financialYearEnding)
        {
            return ApiRequest<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60download/{financialYearEnding}", Method.GET);
        }

        public Task<P60ViewModel> UkHmrcForms_P60DownloadControllerAsync(int businessId, int employeeId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60download/{financialYearEnding}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Notify employee by email of P60
        /// </summary>
        public P60GridViewModel NotifyEmployeeByEmailOfP60(int businessId, int employeeId, int noticeId, int financialYearEnding)
        {
            return ApiRequest<P60GridViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60notify/{noticeId}/{financialYearEnding}", Method.POST);
        }

        /// <summary>
        /// Notify employee by email of P60
        /// </summary>
        public Task<P60GridViewModel> NotifyEmployeeByEmailOfP60Async(int businessId, int employeeId, int noticeId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P60GridViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60notify/{noticeId}/{financialYearEnding}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image", Method.GET);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public Task GetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/image", Method.GET, cancellationToken);
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
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ProfileImageMetadata>($"/business/{businessId}/employee/{employeeId}/image", Method.POST, cancellationToken);
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
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public Task DeleteEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/image", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Get the National Insurance Record and P45 for the Employee
        /// </remarks>
        public TaxNationalInsuranceEditModel GetNationalInsuranceRecordAndP45(int businessId, int employeeId)
        {
            return ApiRequest<TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", Method.GET);
        }

        /// <summary>
        /// Get National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Get the National Insurance Record and P45 for the Employee
        /// </remarks>
        public Task<TaxNationalInsuranceEditModel> GetNationalInsuranceRecordAndP45Async(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", Method.GET, cancellationToken);
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
        /// Update National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Update the National Insurance Record and P45 for the Employee
        /// </remarks>
        public Task<TaxNationalInsuranceEditModel> UpdateNationalInsuranceRecordAndP45Async(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.PUT, cancellationToken);
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
        /// Create National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Creates a new Create Tax National Insurance Record and P45 for the Employee.
        /// </remarks>
        public Task<TaxNationalInsuranceEditModel> CreateNationalInsuranceRecordAndP45Async(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Notes
        /// </summary>
        /// <remarks>
        /// Gets the notes for the specified employee.
        /// </remarks>
        public List<EmployeeNoteModel> GetEmployeeNotes(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeNoteModel>>($"/business/{businessId}/employee/{employeeId}/notes", Method.GET);
        }

        /// <summary>
        /// Get Employee Notes
        /// </summary>
        /// <remarks>
        /// Gets the notes for the specified employee.
        /// </remarks>
        public Task<List<EmployeeNoteModel>> GetEmployeeNotesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeNoteModel>>($"/business/{businessId}/employee/{employeeId}/notes", Method.GET, cancellationToken);
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
        /// Set Employee Notes
        /// </summary>
        /// <remarks>
        /// Sets the notes for the specified employee.
        /// </remarks>
        public Task SetEmployeeNotesAsync(int businessId, int employeeId, CreateEmployeeNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/notes", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public UkOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId)
        {
            return ApiRequest<UkOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.GET);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public Task<UkOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.GET, cancellationToken);
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
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public Task SetOpeningBalancesAsync(int businessId, int employeeId, UkOpeningBalancesModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Pay Rates
        /// </summary>
        /// <remarks>
        /// Gets the pay rates for this employee.
        /// </remarks>
        public List<EmployeePayRateModel> GetPayRates(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeePayRateModel>>($"/business/{businessId}/employee/{employeeId}/payrate", Method.GET);
        }

        /// <summary>
        /// Get Pay Rates
        /// </summary>
        /// <remarks>
        /// Gets the pay rates for this employee.
        /// </remarks>
        public Task<List<EmployeePayRateModel>> GetPayRatesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeePayRateModel>>($"/business/{businessId}/employee/{employeeId}/payrate", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get Pension Contribution Plan settings for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel GetPensionContributionPlan(int businessId, int employeeId)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", Method.GET);
        }

        /// <summary>
        /// Get Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get Pension Contribution Plan settings for Employee
        /// </remarks>
        public Task<EmployeePensionContributionPlanSettingsApiModel> GetPensionContributionPlanAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", Method.GET, cancellationToken);
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
        /// Update Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Update Pension Contribution Plan settings for Employee
        /// </remarks>
        public Task<EmployeePensionContributionPlanSettingsApiModel> UpdatePensionContributionPlanAsync(int businessId, int employeeId, EmployeePensionContributionPlanSettingsApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePensionContributionPlanSettingsApiModel,EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", model, Method.PUT, cancellationToken);
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
        /// Force Enrolment
        /// </summary>
        /// <remarks>
        /// Force Enrolment to Pension Contribution Plan for Employee
        /// </remarks>
        public Task<EmployeePensionContributionPlanSettingsApiModel> ForceEnrolmentAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension/force", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Shift Conditions
        /// </summary>
        /// <remarks>
        /// Lists all the shift conditions for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<UkWorkTypeModel> GetEmployeeShiftConditions(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// Get Employee Shift Conditions
        /// </summary>
        /// <remarks>
        /// Lists all the shift conditions for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<UkWorkTypeModel>> GetEmployeeShiftConditionsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", Method.GET);
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public Task<StandardHoursModel> GetStandardHoursForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", Method.GET, cancellationToken);
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
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public Task<StandardHoursModel> SetStandardHoursForEmployeeAsync(int businessId, int employeeId, StandardHoursModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<StandardHoursModel,StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.PUT, cancellationToken);
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
        /// Create Statutory Adoption Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Adoption Leave period for an employee
        /// </remarks>
        public Task<UkSapDataApiResponseModel> CreateStatutoryAdoptionLeavePeriodDataAsync(int businessId, int employeeId, UkSapDataApiModel sap, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSapDataApiResponseModel,UkSapDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap", sap, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Adoption Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Adoption Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSapCalcApiModel CalculateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSapCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sapcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Calculate Statutory Adoption Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Adoption Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSapCalcApiModel> CalculateStatutoryAdoptionLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSapCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sapcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public UkSmpDataApiModel GetStatutoryMaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSmpDataApiModel> GetStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
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
        /// Create Statutory Maternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Maternity Leave period for an employee
        /// </remarks>
        public Task<UkSmpDataApiResponseModel> CreateStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, UkSmpDataApiModel smp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiResponseModel,UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp", smp, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public UkSmpDataApiModel GetStatutoryMaternityLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSmpDataApiModel> GetStatutoryMaternityLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete Statutory Maternity Leave Data
        /// </summary>
        public void DeleteStatutoryMaternityLeaveData(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Statutory Maternity Leave Data
        /// </summary>
        public Task DeleteStatutoryMaternityLeaveDataAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSmpCalcApiModel CalculateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Calculate Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSmpCalcApiModel> CalculateStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public Task<UkSpbpDataApiModel> GetStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
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
        /// Create Statutory Parental Bereavement Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Parental Bereavement Leave period for an employee
        /// </remarks>
        public Task<UkSpbpDataApiResponseModel> CreateStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, UkSpbpDataApiModel spbp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpDataApiResponseModel,UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp", spbp, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data By ID
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data By ID
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public Task<UkSpbpDataApiModel> GetStatutoryParentalBereavementLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSpbpCalcApiModel CalculateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSpbpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Calculate Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSpbpCalcApiModel> CalculateStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public UkSppDataApiModel GetStatutoryPaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSppDataApiModel> GetStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
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
        /// Create Statutory Paternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Paternity Leave period for an employee
        /// </remarks>
        public Task<UkSppDataApiResponseModel> CreateStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, UkSppDataApiModel spp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppDataApiResponseModel,UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp", spp, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public UkSppDataApiModel GetStatutoryPaternityLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSppDataApiModel> GetStatutoryPaternityLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSppCalcApiModel CalculateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSppCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Calculate Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSppCalcApiModel> CalculateStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Employee
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay records for the employee between the specified dates
        /// </remarks>
        public List<UkSspApiModel> GetStatutorySickPayByEmployee(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request)
        {
            return ApiRequest<List<UkSspApiModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Employee
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay records for the employee between the specified dates
        /// </remarks>
        public Task<List<UkSspApiModel>> GetStatutorySickPayByEmployeeAsync(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkSspApiModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
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
        /// Create Statutory Sick Pay
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Sick Pay leave period for an employee
        /// </remarks>
        public Task<UkSspApiModel> CreateStatutorySickPayAsync(int businessId, int employeeId, UkSspApiModel ssp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSspApiModel,UkSspApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp", ssp, Method.POST, cancellationToken);
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
        /// Sync Employee to QBO
        /// </summary>
        /// <remarks>
        /// Syncs an employee record to QBO.
        /// </remarks>
        public Task SyncEmployeeToQboAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/synctoqbo", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<UkWorkTypeModel> GetEmployeeWorkTypes(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// Get Employee Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<UkWorkTypeModel>> GetEmployeeWorkTypesAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
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
        /// Activate Employee
        /// </summary>
        /// <remarks>
        /// Activates the employee with the specified ID.
        /// </remarks>
        public Task ActivateEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/activate/{employeeId}", Method.POST, cancellationToken);
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
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/employee/details{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
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
            return ApiRequestAsync<List<EmployeeDetailsModel>>($"/business/{businessId}/employee/details{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
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
        /// Grant Kiosk Access
        /// </summary>
        /// <remarks>
        /// Grants kiosk access to the specified employee.
        /// </remarks>
        public Task GrantKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/grantkioskaccess/{employeeId}", Method.POST, cancellationToken);
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
        /// Revoke Kiosk Access
        /// </summary>
        /// <remarks>
        /// Revokes kiosk access from the specified employee.
        /// </remarks>
        public Task RevokeKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/revokekioskaccess/{employeeId}", Method.POST, cancellationToken);
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
            return ApiRequest<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.GET);
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
        public Task<List<UkUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.GET, cancellationToken);
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
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the external ID,
        ///                     then on Payroll ID, then National Insurance number and finally on first name + surname + date of birth + gender 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields;
        ///             firstName, surname, startDate, employeeStatement, NationalInsuranceNumber, NationalInsuranceCategory, NationalInsuranceCalculationMethod,
        ///             TaxCode and TaxCalculationMethod.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>National Insurance Record</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Pension Details</li></list></p>
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.POST);
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
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the external ID,
        ///                     then on Payroll ID, then National Insurance number and finally on first name + surname + date of birth + gender 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields;
        ///             firstName, surname, startDate, employeeStatement, NationalInsuranceNumber, NationalInsuranceCategory, NationalInsuranceCalculationMethod,
        ///             TaxCode and TaxCalculationMethod.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>National Insurance Record</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Pension Details</li></list></p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.POST, cancellationToken);
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
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the external ID,
        ///                     then on Payroll ID, then National Insurance number and finally on first name + surname + date of birth + gender 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields;
        ///             firstName, surname, startDate, employeeStatement, NationalInsuranceNumber, NationalInsuranceCategory, NationalInsuranceCalculationMethod,
        ///             TaxCode and TaxCalculationMethod.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>National Insurance Record</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Pension Details</li></list></p>
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.POST);
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
        ///             <list><li>Standard (default): attempts to match an existing employee - first, based on the external ID,
        ///                     then on Payroll ID, then National Insurance number and finally on first name + surname + date of birth + gender 
        ///                 </li><li>None: do not attempt to match an existing employee (create a new one)
        ///                 </li></list></p>
        /// <p>
        ///             An employee may be created with a status of 'Incomplete' by specifying at least the minimum fields;
        ///             firstName, surname, startDate, employeeStatement, NationalInsuranceNumber, NationalInsuranceCategory, NationalInsuranceCalculationMethod,
        ///             TaxCode and TaxCalculationMethod.<br />
        ///             For an employee record to be considered 'Complete' the following groups of data are required:
        ///               <list><li>Basic Details (Name, Start Date, Date of Birth and Address Details)</li><li>National Insurance Record</li><li>Pay Run Defaults (Default Pay Category, Pay Cycle and Location)</li><li>Locations (at least one)</li><li>Bank Account/s (at least one)</li><li>Pension Details</li></list></p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, UkUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", Method.GET, cancellationToken);
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
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> UpdateEmployeeAsync(int businessId, int employeeId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}", Method.GET);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, string externalId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}", Method.GET);
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalReferenceIdAsync(int businessId, string externalReferenceId, ExternalService source, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}", Method.GET, cancellationToken);
        }
    }
}
