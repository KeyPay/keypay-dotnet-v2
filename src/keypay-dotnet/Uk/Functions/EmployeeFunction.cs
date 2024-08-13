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
using KeyPayV2.Uk.Models.Employee;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeeFunction
    {
        UkUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, GetEmployeeByExternalIdQueryModel request);
        Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, GetEmployeeByExternalIdQueryModel request, CancellationToken cancellationToken = default);
        void DeleteEmployee(int businessId, int employeeId);
        Task DeleteEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeDetailsModel GetEmployeeBasicDetailsById(int businessId, int employeeId);
        Task<EmployeeDetailsModel> GetEmployeeBasicDetailsByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        HmrcFormsViewModel GetsHmrcFormsViewModelForEmployee(int businessId, int employeeId);
        Task<HmrcFormsViewModel> GetsHmrcFormsViewModelForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        AutoEnrolmentNoticeModel CreateAutoEnrolmentNotice(int businessId, int employeeId, AutoEnrolmentNoticeModel notice);
        Task<AutoEnrolmentNoticeModel> CreateAutoEnrolmentNoticeAsync(int businessId, int employeeId, AutoEnrolmentNoticeModel notice, CancellationToken cancellationToken = default);
        byte[] UkHmrcForms_DownloadAutoEnrolmentNotice(int businessId, int employeeId, UkHmrcForms_DownloadAutoEnrolmentNoticeQueryModel request);
        Task<byte[]> UkHmrcForms_DownloadAutoEnrolmentNoticeAsync(int businessId, int employeeId, UkHmrcForms_DownloadAutoEnrolmentNoticeQueryModel request, CancellationToken cancellationToken = default);
        AutoEnrolmentNoticeViewModel SendAutoEnrolmentNotificationToEmployee(int businessId, int employeeId, int noticeId);
        Task<AutoEnrolmentNoticeViewModel> SendAutoEnrolmentNotificationToEmployeeAsync(int businessId, int employeeId, int noticeId, CancellationToken cancellationToken = default);
        P45ViewModel SendP45EmailToEmployee(int businessId, int employeeId);
        Task<P45ViewModel> SendP45EmailToEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        byte[] DownloadEmployeeP11dForm(int businessId, int employeeId, int taxYear);
        Task<byte[]> DownloadEmployeeP11dFormAsync(int businessId, int employeeId, int taxYear, CancellationToken cancellationToken = default);
        P45ViewModel GetP45ModelForEmployee(int businessId, int employeeId);
        Task<P45ViewModel> GetP45ModelForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        P45DataResponse UkHmrcForms_P45Data(int businessId, int employeeId);
        Task<P45DataResponse> UkHmrcForms_P45DataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        byte[] UkHmrcForms_P45Download(int businessId, int employeeId);
        Task<byte[]> UkHmrcForms_P45DownloadAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        P60ViewModel GetP60ModelForEmployee(int businessId, int employeeId, int financialYearEnding);
        Task<P60ViewModel> GetP60ModelForEmployeeAsync(int businessId, int employeeId, int financialYearEnding, CancellationToken cancellationToken = default);
        P60ViewModel UkHmrcForms_P60DownloadController(int businessId, int employeeId, int financialYearEnding);
        Task<P60ViewModel> UkHmrcForms_P60DownloadControllerAsync(int businessId, int employeeId, int financialYearEnding, CancellationToken cancellationToken = default);
        P60GridViewModel NotifyEmployeeByEmailOfP60(int businessId, int employeeId, int noticeId, int financialYearEnding);
        Task<P60GridViewModel> NotifyEmployeeByEmailOfP60Async(int businessId, int employeeId, int noticeId, int financialYearEnding, CancellationToken cancellationToken = default);
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
        UkNationalInsuranceBackCalculationModel GetNationalInsuranceBackCalculationOfEmployee(int businessId, int employeeId);
        Task<UkNationalInsuranceBackCalculationModel> GetNationalInsuranceBackCalculationOfEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkNationalInsuranceBackCalculationModel GetNationalInsuranceBackCalculationOfEmployee(int businessId, int employeeId, GetNationalInsuranceBackCalculationOfEmployeeQueryModel request);
        Task<UkNationalInsuranceBackCalculationModel> GetNationalInsuranceBackCalculationOfEmployeeAsync(int businessId, int employeeId, GetNationalInsuranceBackCalculationOfEmployeeQueryModel request, CancellationToken cancellationToken = default);
        void ApplyNationalInsuranceBackCalculation(int businessId, int employeeId, UkApplyNationalInsuranceBackCalculationRequestModel request);
        Task ApplyNationalInsuranceBackCalculationAsync(int businessId, int employeeId, UkApplyNationalInsuranceBackCalculationRequestModel request, CancellationToken cancellationToken = default);
        void DeleteNationalInsuranceBackCalculation(int businessId, int employeeId);
        Task DeleteNationalInsuranceBackCalculationAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkNationalInsuranceBackCalculationModel BackCalculateNationalInsurance(int businessId, int employeeId);
        Task<UkNationalInsuranceBackCalculationModel> BackCalculateNationalInsuranceAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkNationalInsuranceBackCalculationModel BackCalculateNationalInsurance(int businessId, int employeeId, BackCalculateNationalInsuranceQueryModel request);
        Task<UkNationalInsuranceBackCalculationModel> BackCalculateNationalInsuranceAsync(int businessId, int employeeId, BackCalculateNationalInsuranceQueryModel request, CancellationToken cancellationToken = default);
        TaxNationalInsuranceEditModel GetNationalInsuranceRecordAndP45(int businessId, int employeeId);
        Task<TaxNationalInsuranceEditModel> GetNationalInsuranceRecordAndP45Async(int businessId, int employeeId, CancellationToken cancellationToken = default);
        TaxNationalInsuranceEditModel UpdateNationalInsuranceRecordAndP45(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel);
        Task<TaxNationalInsuranceEditModel> UpdateNationalInsuranceRecordAndP45Async(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel, CancellationToken cancellationToken = default);
        TaxNationalInsuranceEditModel CreateNationalInsuranceRecordAndP45(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel);
        Task<TaxNationalInsuranceEditModel> CreateNationalInsuranceRecordAndP45Async(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel, CancellationToken cancellationToken = default);
        List<EmployeeNoteModel> GetEmployeeNotes(int businessId, int employeeId);
        Task<List<EmployeeNoteModel>> GetEmployeeNotesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetEmployeeNotes(int businessId, int employeeId, CreateEmployeeNoteModel model);
        Task SetEmployeeNotesAsync(int businessId, int employeeId, CreateEmployeeNoteModel model, CancellationToken cancellationToken = default);
        List<PeriodOfLeaveModel> GetOccupationalAbsence(int businessId, int employeeId, GetOccupationalAbsenceQueryModel request);
        Task<List<PeriodOfLeaveModel>> GetOccupationalAbsenceAsync(int businessId, int employeeId, GetOccupationalAbsenceQueryModel request, CancellationToken cancellationToken = default);
        PeriodOfLeaveModel CreateOccupationalAbsence(int businessId, int employeeId, PeriodOfLeaveModel periodOfLeaveModel);
        Task<PeriodOfLeaveModel> CreateOccupationalAbsenceAsync(int businessId, int employeeId, PeriodOfLeaveModel periodOfLeaveModel, CancellationToken cancellationToken = default);
        UkOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId);
        Task<UkOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetOpeningBalances(int businessId, int employeeId, UkOpeningBalancesModel model);
        Task SetOpeningBalancesAsync(int businessId, int employeeId, UkOpeningBalancesModel model, CancellationToken cancellationToken = default);
        List<EmployeePayRateModel> GetPayRates(int businessId, int employeeId);
        Task<List<EmployeePayRateModel>> GetPayRatesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeePensionContributionPlanSettingsApiModel GetPensionContributionPlan(int businessId, int employeeId);
        Task<EmployeePensionContributionPlanSettingsApiModel> GetPensionContributionPlanAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeePensionContributionPlanSettingsApiModel UpdatePensionContributionPlan(int businessId, int employeeId, EmployeePensionContributionPlanSettingsApiModel model);
        Task<EmployeePensionContributionPlanSettingsApiModel> UpdatePensionContributionPlanAsync(int businessId, int employeeId, EmployeePensionContributionPlanSettingsApiModel model, CancellationToken cancellationToken = default);
        EmployeePensionContributionPlanSettingsApiModel ForceEnrolment(int businessId, int employeeId);
        Task<EmployeePensionContributionPlanSettingsApiModel> ForceEnrolmentAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<UkWorkTypeModel> GetEmployeeShiftConditions(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<UkWorkTypeModel>> GetEmployeeShiftConditionsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        StandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId);
        Task<StandardHoursModel> GetStandardHoursForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        StandardHoursModel SetStandardHoursForEmployee(int businessId, int employeeId, StandardHoursModel model);
        Task<StandardHoursModel> SetStandardHoursForEmployeeAsync(int businessId, int employeeId, StandardHoursModel model, CancellationToken cancellationToken = default);
        UkSapDataApiResponseModel CreateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, UkSapDataApiModel sap);
        Task<UkSapDataApiResponseModel> CreateStatutoryAdoptionLeavePeriodDataAsync(int businessId, int employeeId, UkSapDataApiModel sap, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> GetStatutoryAdoptionLeaveAttachments(int businessId, int employeeId, int id);
        Task<List<EmployeeDocumentModel>> GetStatutoryAdoptionLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeDocumentModel AttachEmployeeDocumentToStatutoryAdoptionLeave(int businessId, int employeeId, int id, int documentId);
        Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryAdoptionLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnattachEmployeeDocumentFromStatutoryAdoptionLeave(int businessId, int employeeId, int id, int documentId);
        Task UnattachEmployeeDocumentFromStatutoryAdoptionLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        UkSapCalcApiModel CalculateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request);
        Task<UkSapCalcApiModel> CalculateStatutoryAdoptionLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkShppDataApiModel GetStatutorySharedParentalLeavePeriodData(int businessId, int employeeId, GetStatutorySharedParentalLeavePeriodDataQueryModel request);
        Task<UkShppDataApiModel> GetStatutorySharedParentalLeavePeriodDataAsync(int businessId, int employeeId, GetStatutorySharedParentalLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSmpDataApiResponseModel CreateStatutorySharedParentalLeavePeriodData(int businessId, int employeeId, UkShppDataApiModel shpp);
        Task<UkSmpDataApiResponseModel> CreateStatutorySharedParentalLeavePeriodDataAsync(int businessId, int employeeId, UkShppDataApiModel shpp, CancellationToken cancellationToken = default);
        UkShppDataApiModel GetStatutorySharedParentalLeavePeriodDataById(int businessId, int employeeId, int id);
        Task<UkShppDataApiModel> GetStatutorySharedParentalLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> GetStatutorySharedParentalLeaveAttachments(int businessId, int employeeId, int id);
        Task<List<EmployeeDocumentModel>> GetStatutorySharedParentalLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeDocumentModel AttachEmployeeDocumentToStatutorySharedParentalLeave(int businessId, int employeeId, int id, int documentId);
        Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutorySharedParentalLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnattachEmployeeDocumentFromStatutorySharedParentalLeave(int businessId, int employeeId, int id, int documentId);
        Task UnattachEmployeeDocumentFromStatutorySharedParentalLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        UkSmpCalcApiModel CalculateStatutorySharedParentalLeavePeriodData(int businessId, int employeeId, CalculateStatutorySharedParentalLeavePeriodDataQueryModel request);
        Task<UkSmpCalcApiModel> CalculateStatutorySharedParentalLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutorySharedParentalLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSmpDataApiModel GetStatutoryMaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request);
        Task<UkSmpDataApiModel> GetStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSmpDataApiResponseModel CreateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, UkSmpDataApiModel smp);
        Task<UkSmpDataApiResponseModel> CreateStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, UkSmpDataApiModel smp, CancellationToken cancellationToken = default);
        UkSmpDataApiModel GetStatutoryMaternityLeavePeriodDataById(int businessId, int employeeId, int id);
        Task<UkSmpDataApiModel> GetStatutoryMaternityLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void DeleteStatutoryMaternityLeaveData(int businessId, int employeeId, int id);
        Task DeleteStatutoryMaternityLeaveDataAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> GetStatutoryMaternityLeaveAttachments(int businessId, int employeeId, int id);
        Task<List<EmployeeDocumentModel>> GetStatutoryMaternityLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeDocumentModel AttachEmployeeDocumentToStatutoryMaternityLeave(int businessId, int employeeId, int id, int documentId);
        Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryMaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnattachEmployeeDocumentFromStatutoryMaternityLeave(int businessId, int employeeId, int id, int documentId);
        Task UnattachEmployeeDocumentFromStatutoryMaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        UkSmpCalcApiModel CalculateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request);
        Task<UkSmpCalcApiModel> CalculateStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request);
        Task<UkSpbpDataApiModel> GetStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSpbpDataApiResponseModel CreateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, UkSpbpDataApiModel spbp);
        Task<UkSpbpDataApiResponseModel> CreateStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, UkSpbpDataApiModel spbp, CancellationToken cancellationToken = default);
        UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodDataById(int businessId, int employeeId, int id);
        Task<UkSpbpDataApiModel> GetStatutoryParentalBereavementLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> GetStatutoryParentalBereavementLeaveAttachments(int businessId, int employeeId, int id);
        Task<List<EmployeeDocumentModel>> GetStatutoryParentalBereavementLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeDocumentModel AttachEmployeeDocumentToStatutoryParentalBereavementLeave(int businessId, int employeeId, int id, int documentId);
        Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryParentalBereavementLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnattachEmployeeDocumentFromStatutoryParentalBereavementLeave(int businessId, int employeeId, int id, int documentId);
        Task UnattachEmployeeDocumentFromStatutoryParentalBereavementLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        UkSpbpCalcApiModel CalculateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request);
        Task<UkSpbpCalcApiModel> CalculateStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSppDataApiModel GetStatutoryPaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request);
        Task<UkSppDataApiModel> GetStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        UkSppDataApiResponseModel CreateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, UkSppDataApiModel spp);
        Task<UkSppDataApiResponseModel> CreateStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, UkSppDataApiModel spp, CancellationToken cancellationToken = default);
        UkSppDataApiModel GetStatutoryPaternityLeavePeriodDataById(int businessId, int employeeId, int id);
        Task<UkSppDataApiModel> GetStatutoryPaternityLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> GetStatutoryPaternityLeaveAttachments(int businessId, int employeeId, int id);
        Task<List<EmployeeDocumentModel>> GetStatutoryPaternityLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        EmployeeDocumentModel AttachEmployeeDocumentToStatutoryPaternityLeave(int businessId, int employeeId, int id, int documentId);
        Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryPaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnattachEmployeeDocumentFromStatutoryPaternityLeave(int businessId, int employeeId, int id, int documentId);
        Task UnattachEmployeeDocumentFromStatutoryPaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        UkSppCalcApiModel CalculateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request);
        Task<UkSppCalcApiModel> CalculateStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default);
        List<UkSspApiModel> GetStatutorySickPayByEmployee(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request);
        Task<List<UkSspApiModel>> GetStatutorySickPayByEmployeeAsync(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request, CancellationToken cancellationToken = default);
        UkSspApiModel CreateStatutorySickPay(int businessId, int employeeId, UkSspApiModel ssp);
        Task<UkSspApiModel> CreateStatutorySickPayAsync(int businessId, int employeeId, UkSspApiModel ssp, CancellationToken cancellationToken = default);
        UkSspApiModel GetStatutorySickPayById(int businessId, int employeeId, int periodOfLeaveId);
        Task<UkSspApiModel> GetStatutorySickPayByIdAsync(int businessId, int employeeId, int periodOfLeaveId, CancellationToken cancellationToken = default);
        PeriodOfLeaveModel UpdateStatutorySickPay(int businessId, int employeeId, int periodOfLeaveId, UkSspUpdateModel model);
        Task<PeriodOfLeaveModel> UpdateStatutorySickPayAsync(int businessId, int employeeId, int periodOfLeaveId, UkSspUpdateModel model, CancellationToken cancellationToken = default);
        void DeletePeriodOfLeave(int businessId, int employeeId, int periodOfLeaveId);
        Task DeletePeriodOfLeaveAsync(int businessId, int employeeId, int periodOfLeaveId, CancellationToken cancellationToken = default);
        void SyncEmployeeToQbo(int businessId, int employeeId);
        Task SyncEmployeeToQboAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<UkWorkTypeModel> GetEmployeeWorkTypes(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<UkWorkTypeModel>> GetEmployeeWorkTypesAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        YearToDateModel GetYearToDate(int businessId, int employeeId, GetYearToDateQueryModel request);
        Task<YearToDateModel> GetYearToDateAsync(int businessId, int employeeId, GetYearToDateQueryModel request, CancellationToken cancellationToken = default);
        void ActivateEmployee(int businessId, int employeeId);
        Task ActivateEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<EmployeeDetailsModel> ListBasicDetailsForEmployees(int businessId, ODataQuery oDataQuery = null);
        Task<List<EmployeeDetailsModel>> ListBasicDetailsForEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void GrantKioskAccess(int businessId, int employeeId);
        Task GrantKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void RevokeKioskAccess(int businessId, int employeeId);
        Task RevokeKioskAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<UkUnstructuredEmployeeModel> ListEmployees(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        List<UkUnstructuredEmployeeModel> ListEmployees(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null);
        Task<List<UkUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model);
        Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request);
        Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, UkUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request, CancellationToken cancellationToken = default);
        UkUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId);
        Task<UkUnstructuredEmployeeModel> GetEmployeeByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModel UpdateEmployee(int businessId, int employeeId, UkUnstructuredEmployeeModel model);
        Task<EmployeeUpdateResponseModel> UpdateEmployeeAsync(int businessId, int employeeId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default);
        UkUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId);
        Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, string externalId, CancellationToken cancellationToken = default);
        UkUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source);
        Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalReferenceIdAsync(int businessId, string externalReferenceId, ExternalService source, CancellationToken cancellationToken = default);
    }
    public class EmployeeFunction : BaseFunction, IEmployeeFunction
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
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee?externalId={request.ExternalId}", Method.Get);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, GetEmployeeByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee?externalId={request.ExternalId}", Method.Get, cancellationToken);
        }

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
        /// Gets hmrc forms view model for employee
        /// </summary>
        public HmrcFormsViewModel GetsHmrcFormsViewModelForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<HmrcFormsViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms", Method.Get);
        }

        /// <summary>
        /// Gets hmrc forms view model for employee
        /// </summary>
        public Task<HmrcFormsViewModel> GetsHmrcFormsViewModelForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HmrcFormsViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create auto enrolment notice
        /// </summary>
        public AutoEnrolmentNoticeModel CreateAutoEnrolmentNotice(int businessId, int employeeId, AutoEnrolmentNoticeModel notice)
        {
            return ApiRequest<AutoEnrolmentNoticeModel,AutoEnrolmentNoticeModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/autoenrolmentnotice", notice, Method.Post);
        }

        /// <summary>
        /// Create auto enrolment notice
        /// </summary>
        public Task<AutoEnrolmentNoticeModel> CreateAutoEnrolmentNoticeAsync(int businessId, int employeeId, AutoEnrolmentNoticeModel notice, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AutoEnrolmentNoticeModel,AutoEnrolmentNoticeModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/autoenrolmentnotice", notice, Method.Post, cancellationToken);
        }

        public byte[] UkHmrcForms_DownloadAutoEnrolmentNotice(int businessId, int employeeId, UkHmrcForms_DownloadAutoEnrolmentNoticeQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/employee/{employeeId}/hmrcforms/downloadautoenrolmentnotice?id={request.Id}", Method.Get);
        }

        public Task<byte[]> UkHmrcForms_DownloadAutoEnrolmentNoticeAsync(int businessId, int employeeId, UkHmrcForms_DownloadAutoEnrolmentNoticeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/employee/{employeeId}/hmrcforms/downloadautoenrolmentnotice?id={request.Id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Send auto-enrolment notification to employee
        /// </summary>
        public AutoEnrolmentNoticeViewModel SendAutoEnrolmentNotificationToEmployee(int businessId, int employeeId, int noticeId)
        {
            return ApiRequest<AutoEnrolmentNoticeViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/emailautoenrolmentnotice/{noticeId}", Method.Post);
        }

        /// <summary>
        /// Send auto-enrolment notification to employee
        /// </summary>
        public Task<AutoEnrolmentNoticeViewModel> SendAutoEnrolmentNotificationToEmployeeAsync(int businessId, int employeeId, int noticeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AutoEnrolmentNoticeViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/emailautoenrolmentnotice/{noticeId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Send P45-email to employee
        /// </summary>
        public P45ViewModel SendP45EmailToEmployee(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/mailp45", Method.Post);
        }

        /// <summary>
        /// Send P45-email to employee
        /// </summary>
        public Task<P45ViewModel> SendP45EmailToEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/mailp45", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Download Employee P11D form
        /// </summary>
        public byte[] DownloadEmployeeP11dForm(int businessId, int employeeId, int taxYear)
        {
            return ApiByteArrayRequest($"/business/{businessId}/employee/{employeeId}/hmrcforms/p11ddownload/{taxYear}", Method.Get);
        }

        /// <summary>
        /// Download Employee P11D form
        /// </summary>
        public Task<byte[]> DownloadEmployeeP11dFormAsync(int businessId, int employeeId, int taxYear, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/employee/{employeeId}/hmrcforms/p11ddownload/{taxYear}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get P45 model for employee
        /// </summary>
        public P45ViewModel GetP45ModelForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45", Method.Get);
        }

        /// <summary>
        /// Get P45 model for employee
        /// </summary>
        public Task<P45ViewModel> GetP45ModelForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P45ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45", Method.Get, cancellationToken);
        }

        public P45DataResponse UkHmrcForms_P45Data(int businessId, int employeeId)
        {
            return ApiRequest<P45DataResponse>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45data", Method.Get);
        }

        public Task<P45DataResponse> UkHmrcForms_P45DataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P45DataResponse>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45data", Method.Get, cancellationToken);
        }

        public byte[] UkHmrcForms_P45Download(int businessId, int employeeId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45download", Method.Get);
        }

        public Task<byte[]> UkHmrcForms_P45DownloadAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/employee/{employeeId}/hmrcforms/p45download", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get P60 model for employee
        /// </summary>
        public P60ViewModel GetP60ModelForEmployee(int businessId, int employeeId, int financialYearEnding)
        {
            return ApiRequest<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60/{financialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Get P60 model for employee
        /// </summary>
        public Task<P60ViewModel> GetP60ModelForEmployeeAsync(int businessId, int employeeId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60/{financialYearEnding}", Method.Get, cancellationToken);
        }

        public P60ViewModel UkHmrcForms_P60DownloadController(int businessId, int employeeId, int financialYearEnding)
        {
            return ApiRequest<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60download/{financialYearEnding}", Method.Get);
        }

        public Task<P60ViewModel> UkHmrcForms_P60DownloadControllerAsync(int businessId, int employeeId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P60ViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60download/{financialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Notify employee by email of P60
        /// </summary>
        public P60GridViewModel NotifyEmployeeByEmailOfP60(int businessId, int employeeId, int noticeId, int financialYearEnding)
        {
            return ApiRequest<P60GridViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60notify/{noticeId}/{financialYearEnding}", Method.Post);
        }

        /// <summary>
        /// Notify employee by email of P60
        /// </summary>
        public Task<P60GridViewModel> NotifyEmployeeByEmailOfP60Async(int businessId, int employeeId, int noticeId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P60GridViewModel>($"/business/{businessId}/employee/{employeeId}/hmrcforms/p60notify/{noticeId}/{financialYearEnding}", Method.Post, cancellationToken);
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
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get National Insurance Back Calculation of employee
        /// </summary>
        public UkNationalInsuranceBackCalculationModel GetNationalInsuranceBackCalculationOfEmployee(int businessId, int employeeId)
        {
            return ApiRequest<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation", Method.Get);
        }

        /// <summary>
        /// Get National Insurance Back Calculation of employee
        /// </summary>
        public Task<UkNationalInsuranceBackCalculationModel> GetNationalInsuranceBackCalculationOfEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get National Insurance Back Calculation of employee
        /// </summary>
        public UkNationalInsuranceBackCalculationModel GetNationalInsuranceBackCalculationOfEmployee(int businessId, int employeeId, GetNationalInsuranceBackCalculationOfEmployeeQueryModel request)
        {
            return ApiRequest<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation?includeComplete={request.IncludeComplete}", Method.Get);
        }

        /// <summary>
        /// Get National Insurance Back Calculation of employee
        /// </summary>
        public Task<UkNationalInsuranceBackCalculationModel> GetNationalInsuranceBackCalculationOfEmployeeAsync(int businessId, int employeeId, GetNationalInsuranceBackCalculationOfEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation?includeComplete={request.IncludeComplete}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Apply National Insurance Back Calculation
        /// </summary>
        public void ApplyNationalInsuranceBackCalculation(int businessId, int employeeId, UkApplyNationalInsuranceBackCalculationRequestModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation", request, Method.Post);
        }

        /// <summary>
        /// Apply National Insurance Back Calculation
        /// </summary>
        public Task ApplyNationalInsuranceBackCalculationAsync(int businessId, int employeeId, UkApplyNationalInsuranceBackCalculationRequestModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete National Insurance Back Calculation
        /// </summary>
        public void DeleteNationalInsuranceBackCalculation(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation", Method.Delete);
        }

        /// <summary>
        /// Delete National Insurance Back Calculation
        /// </summary>
        public Task DeleteNationalInsuranceBackCalculationAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Back calculate National Insurance
        /// </summary>
        public UkNationalInsuranceBackCalculationModel BackCalculateNationalInsurance(int businessId, int employeeId)
        {
            return ApiRequest<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation/calculation", Method.Get);
        }

        /// <summary>
        /// Back calculate National Insurance
        /// </summary>
        public Task<UkNationalInsuranceBackCalculationModel> BackCalculateNationalInsuranceAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation/calculation", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Back calculate National Insurance
        /// </summary>
        public UkNationalInsuranceBackCalculationModel BackCalculateNationalInsurance(int businessId, int employeeId, BackCalculateNationalInsuranceQueryModel request)
        {
            return ApiRequest<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation/calculation?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&newCategory={request.NewCategory}", Method.Get);
        }

        /// <summary>
        /// Back calculate National Insurance
        /// </summary>
        public Task<UkNationalInsuranceBackCalculationModel> BackCalculateNationalInsuranceAsync(int businessId, int employeeId, BackCalculateNationalInsuranceQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNationalInsuranceBackCalculationModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancebackcalculation/calculation?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&newCategory={request.NewCategory}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Get the National Insurance Record and P45 for the Employee
        /// </remarks>
        public TaxNationalInsuranceEditModel GetNationalInsuranceRecordAndP45(int businessId, int employeeId)
        {
            return ApiRequest<TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", Method.Get);
        }

        /// <summary>
        /// Get National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Get the National Insurance Record and P45 for the Employee
        /// </remarks>
        public Task<TaxNationalInsuranceEditModel> GetNationalInsuranceRecordAndP45Async(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Update the National Insurance Record and P45 for the Employee
        /// </remarks>
        public TaxNationalInsuranceEditModel UpdateNationalInsuranceRecordAndP45(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel)
        {
            return ApiRequest<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.Put);
        }

        /// <summary>
        /// Update National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Update the National Insurance Record and P45 for the Employee
        /// </remarks>
        public Task<TaxNationalInsuranceEditModel> UpdateNationalInsuranceRecordAndP45Async(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Creates a new Create Tax National Insurance Record and P45 for the Employee.
        /// </remarks>
        public TaxNationalInsuranceEditModel CreateNationalInsuranceRecordAndP45(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel)
        {
            return ApiRequest<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.Post);
        }

        /// <summary>
        /// Create National Insurance Record and P45
        /// </summary>
        /// <remarks>
        /// Creates a new Create Tax National Insurance Record and P45 for the Employee.
        /// </remarks>
        public Task<TaxNationalInsuranceEditModel> CreateNationalInsuranceRecordAndP45Async(int businessId, int employeeId, TaxNationalInsuranceEditModel taxNationalInsuranceEditModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TaxNationalInsuranceEditModel,TaxNationalInsuranceEditModel>($"/business/{businessId}/employee/{employeeId}/nationalinsurancerecord", taxNationalInsuranceEditModel, Method.Post, cancellationToken);
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
        /// Get Occupational Absence
        /// </summary>
        public List<PeriodOfLeaveModel> GetOccupationalAbsence(int businessId, int employeeId, GetOccupationalAbsenceQueryModel request)
        {
            return ApiRequest<List<PeriodOfLeaveModel>>($"/business/{businessId}/employee/{employeeId}/occupationalabsence?earliestStartDate={request.EarliestStartDate.ToString("yyyy-MM-ddTHH:mm:ss")}&latestStartDate={request.LatestStartDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Occupational Absence
        /// </summary>
        public Task<List<PeriodOfLeaveModel>> GetOccupationalAbsenceAsync(int businessId, int employeeId, GetOccupationalAbsenceQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PeriodOfLeaveModel>>($"/business/{businessId}/employee/{employeeId}/occupationalabsence?earliestStartDate={request.EarliestStartDate.ToString("yyyy-MM-ddTHH:mm:ss")}&latestStartDate={request.LatestStartDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Occupational Absence
        /// </summary>
        public PeriodOfLeaveModel CreateOccupationalAbsence(int businessId, int employeeId, PeriodOfLeaveModel periodOfLeaveModel)
        {
            return ApiRequest<PeriodOfLeaveModel,PeriodOfLeaveModel>($"/business/{businessId}/employee/{employeeId}/occupationalabsence", periodOfLeaveModel, Method.Post);
        }

        /// <summary>
        /// Create Occupational Absence
        /// </summary>
        public Task<PeriodOfLeaveModel> CreateOccupationalAbsenceAsync(int businessId, int employeeId, PeriodOfLeaveModel periodOfLeaveModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PeriodOfLeaveModel,PeriodOfLeaveModel>($"/business/{businessId}/employee/{employeeId}/occupationalabsence", periodOfLeaveModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public UkOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId)
        {
            return ApiRequest<UkOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.Get);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public Task<UkOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public void SetOpeningBalances(int businessId, int employeeId, UkOpeningBalancesModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.Post);
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public Task SetOpeningBalancesAsync(int businessId, int employeeId, UkOpeningBalancesModel model, CancellationToken cancellationToken = default)
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
        /// Get Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get Pension Contribution Plan settings for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel GetPensionContributionPlan(int businessId, int employeeId)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", Method.Get);
        }

        /// <summary>
        /// Get Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get Pension Contribution Plan settings for Employee
        /// </remarks>
        public Task<EmployeePensionContributionPlanSettingsApiModel> GetPensionContributionPlanAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Update Pension Contribution Plan settings for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel UpdatePensionContributionPlan(int businessId, int employeeId, EmployeePensionContributionPlanSettingsApiModel model)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel,EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", model, Method.Put);
        }

        /// <summary>
        /// Update Pension Contribution Plan
        /// </summary>
        /// <remarks>
        /// Update Pension Contribution Plan settings for Employee
        /// </remarks>
        public Task<EmployeePensionContributionPlanSettingsApiModel> UpdatePensionContributionPlanAsync(int businessId, int employeeId, EmployeePensionContributionPlanSettingsApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePensionContributionPlanSettingsApiModel,EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Force Enrolment
        /// </summary>
        /// <remarks>
        /// Force Enrolment to Pension Contribution Plan for Employee
        /// </remarks>
        public EmployeePensionContributionPlanSettingsApiModel ForceEnrolment(int businessId, int employeeId)
        {
            return ApiRequest<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension/force", Method.Post);
        }

        /// <summary>
        /// Force Enrolment
        /// </summary>
        /// <remarks>
        /// Force Enrolment to Pension Contribution Plan for Employee
        /// </remarks>
        public Task<EmployeePensionContributionPlanSettingsApiModel> ForceEnrolmentAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePensionContributionPlanSettingsApiModel>($"/business/{businessId}/employee/{employeeId}/pension/force", Method.Post, cancellationToken);
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
            return ApiRequest<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
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
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", Method.Get);
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public Task<StandardHoursModel> GetStandardHoursForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel SetStandardHoursForEmployee(int businessId, int employeeId, StandardHoursModel model)
        {
            return ApiRequest<StandardHoursModel,StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.Put);
        }

        /// <summary>
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public Task<StandardHoursModel> SetStandardHoursForEmployeeAsync(int businessId, int employeeId, StandardHoursModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<StandardHoursModel,StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create Statutory Adoption Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Adoption Leave period for an employee
        /// </remarks>
        public UkSapDataApiResponseModel CreateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, UkSapDataApiModel sap)
        {
            return ApiRequest<UkSapDataApiResponseModel,UkSapDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap", sap, Method.Post);
        }

        /// <summary>
        /// Create Statutory Adoption Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Adoption Leave period for an employee
        /// </remarks>
        public Task<UkSapDataApiResponseModel> CreateStatutoryAdoptionLeavePeriodDataAsync(int businessId, int employeeId, UkSapDataApiModel sap, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSapDataApiResponseModel,UkSapDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap", sap, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Adoption Leave Attachments
        /// </summary>
        public List<EmployeeDocumentModel> GetStatutoryAdoptionLeaveAttachments(int businessId, int employeeId, int id)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap/{id}/attachments", Method.Get);
        }

        /// <summary>
        /// Get Statutory Adoption Leave Attachments
        /// </summary>
        public Task<List<EmployeeDocumentModel>> GetStatutoryAdoptionLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap/{id}/attachments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Adoption Leave
        /// </summary>
        public EmployeeDocumentModel AttachEmployeeDocumentToStatutoryAdoptionLeave(int businessId, int employeeId, int id, int documentId)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap/{id}/employeedocument/{documentId}", Method.Put);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Adoption Leave
        /// </summary>
        public Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryAdoptionLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap/{id}/employeedocument/{documentId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Adoption Leave
        /// </summary>
        public void UnattachEmployeeDocumentFromStatutoryAdoptionLeave(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap/{id}/employeedocument/{documentId}", Method.Delete);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Adoption Leave
        /// </summary>
        public Task UnattachEmployeeDocumentFromStatutoryAdoptionLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/sap/{id}/employeedocument/{documentId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Adoption Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Adoption Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSapCalcApiModel CalculateStatutoryAdoptionLeavePeriodData(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSapCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sapcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Calculate Statutory Adoption Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Adoption Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSapCalcApiModel> CalculateStatutoryAdoptionLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryAdoptionLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSapCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sapcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Shared Parental Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Shared Parental Leave period data for a specific employee
        /// </remarks>
        public UkShppDataApiModel GetStatutorySharedParentalLeavePeriodData(int businessId, int employeeId, GetStatutorySharedParentalLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkShppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Shared Parental Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Shared Parental Leave period data for a specific employee
        /// </remarks>
        public Task<UkShppDataApiModel> GetStatutorySharedParentalLeavePeriodDataAsync(int businessId, int employeeId, GetStatutorySharedParentalLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkShppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Statutory Shared Parental Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Shared Parental Leave period for an employee
        /// </remarks>
        public UkSmpDataApiResponseModel CreateStatutorySharedParentalLeavePeriodData(int businessId, int employeeId, UkShppDataApiModel shpp)
        {
            return ApiRequest<UkSmpDataApiResponseModel,UkShppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp", shpp, Method.Post);
        }

        /// <summary>
        /// Create Statutory Shared Parental Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Shared Parental Leave period for an employee
        /// </remarks>
        public Task<UkSmpDataApiResponseModel> CreateStatutorySharedParentalLeavePeriodDataAsync(int businessId, int employeeId, UkShppDataApiModel shpp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiResponseModel,UkShppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp", shpp, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Shared Parental Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Shared Parental Leave period data for a specific employee
        /// </remarks>
        public UkShppDataApiModel GetStatutorySharedParentalLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkShppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Shared Parental Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Shared Parental Leave period data for a specific employee
        /// </remarks>
        public Task<UkShppDataApiModel> GetStatutorySharedParentalLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkShppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Shared Parental Leave Attachments
        /// </summary>
        public List<EmployeeDocumentModel> GetStatutorySharedParentalLeaveAttachments(int businessId, int employeeId, int id)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}/attachments", Method.Get);
        }

        /// <summary>
        /// Get Statutory Shared Parental Leave Attachments
        /// </summary>
        public Task<List<EmployeeDocumentModel>> GetStatutorySharedParentalLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}/attachments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Shared Parental Leave
        /// </summary>
        public EmployeeDocumentModel AttachEmployeeDocumentToStatutorySharedParentalLeave(int businessId, int employeeId, int id, int documentId)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}/employeedocument/{documentId}", Method.Put);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Shared Parental Leave
        /// </summary>
        public Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutorySharedParentalLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}/employeedocument/{documentId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Shared Parental Leave
        /// </summary>
        public void UnattachEmployeeDocumentFromStatutorySharedParentalLeave(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}/employeedocument/{documentId}", Method.Delete);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Shared Parental Leave
        /// </summary>
        public Task UnattachEmployeeDocumentFromStatutorySharedParentalLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/shpp/{id}/employeedocument/{documentId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Shared Parental Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Shared Parental Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSmpCalcApiModel CalculateStatutorySharedParentalLeavePeriodData(int businessId, int employeeId, CalculateStatutorySharedParentalLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Calculate Statutory Shared Parental Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Shared Parental Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSmpCalcApiModel> CalculateStatutorySharedParentalLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutorySharedParentalLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/shppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public UkSmpDataApiModel GetStatutoryMaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSmpDataApiModel> GetStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryMaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Statutory Maternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Maternity Leave period for an employee
        /// </remarks>
        public UkSmpDataApiResponseModel CreateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, UkSmpDataApiModel smp)
        {
            return ApiRequest<UkSmpDataApiResponseModel,UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp", smp, Method.Post);
        }

        /// <summary>
        /// Create Statutory Maternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Maternity Leave period for an employee
        /// </remarks>
        public Task<UkSmpDataApiResponseModel> CreateStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, UkSmpDataApiModel smp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiResponseModel,UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp", smp, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public UkSmpDataApiModel GetStatutoryMaternityLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSmpDataApiModel> GetStatutoryMaternityLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Statutory Maternity Leave Data
        /// </summary>
        public void DeleteStatutoryMaternityLeaveData(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Statutory Maternity Leave Data
        /// </summary>
        public Task DeleteStatutoryMaternityLeaveDataAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Attachments
        /// </summary>
        public List<EmployeeDocumentModel> GetStatutoryMaternityLeaveAttachments(int businessId, int employeeId, int id)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}/attachments", Method.Get);
        }

        /// <summary>
        /// Get Statutory Maternity Leave Attachments
        /// </summary>
        public Task<List<EmployeeDocumentModel>> GetStatutoryMaternityLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}/attachments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Maternity Leave
        /// </summary>
        public EmployeeDocumentModel AttachEmployeeDocumentToStatutoryMaternityLeave(int businessId, int employeeId, int id, int documentId)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}/employeedocument/{documentId}", Method.Put);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Maternity Leave
        /// </summary>
        public Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryMaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}/employeedocument/{documentId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Maternity Leave
        /// </summary>
        public void UnattachEmployeeDocumentFromStatutoryMaternityLeave(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}/employeedocument/{documentId}", Method.Delete);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Maternity Leave
        /// </summary>
        public Task UnattachEmployeeDocumentFromStatutoryMaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/smp/{id}/employeedocument/{documentId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSmpCalcApiModel CalculateStatutoryMaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Calculate Statutory Maternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Maternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSmpCalcApiModel> CalculateStatutoryMaternityLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryMaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSmpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/smpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public Task<UkSpbpDataApiModel> GetStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryParentalBereavementLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Statutory Parental Bereavement Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Parental Bereavement Leave period for an employee
        /// </remarks>
        public UkSpbpDataApiResponseModel CreateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, UkSpbpDataApiModel spbp)
        {
            return ApiRequest<UkSpbpDataApiResponseModel,UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp", spbp, Method.Post);
        }

        /// <summary>
        /// Create Statutory Parental Bereavement Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Parental Bereavement Leave period for an employee
        /// </remarks>
        public Task<UkSpbpDataApiResponseModel> CreateStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, UkSpbpDataApiModel spbp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpDataApiResponseModel,UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp", spbp, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data By ID
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public UkSpbpDataApiModel GetStatutoryParentalBereavementLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Period Data By ID
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee
        /// </remarks>
        public Task<UkSpbpDataApiModel> GetStatutoryParentalBereavementLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Attachments
        /// </summary>
        public List<EmployeeDocumentModel> GetStatutoryParentalBereavementLeaveAttachments(int businessId, int employeeId, int id)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}/attachments", Method.Get);
        }

        /// <summary>
        /// Get Statutory Parental Bereavement Leave Attachments
        /// </summary>
        public Task<List<EmployeeDocumentModel>> GetStatutoryParentalBereavementLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}/attachments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Parental Bereavement Leave
        /// </summary>
        public EmployeeDocumentModel AttachEmployeeDocumentToStatutoryParentalBereavementLeave(int businessId, int employeeId, int id, int documentId)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}/employeedocument/{documentId}", Method.Put);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Parental Bereavement Leave
        /// </summary>
        public Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryParentalBereavementLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}/employeedocument/{documentId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Parental Bereavement Leave
        /// </summary>
        public void UnattachEmployeeDocumentFromStatutoryParentalBereavementLeave(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}/employeedocument/{documentId}", Method.Delete);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Parental Bereavement Leave
        /// </summary>
        public Task UnattachEmployeeDocumentFromStatutoryParentalBereavementLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbp/{id}/employeedocument/{documentId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSpbpCalcApiModel CalculateStatutoryParentalBereavementLeavePeriodData(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSpbpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Calculate Statutory Parental Bereavement Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Parental Bereavement Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSpbpCalcApiModel> CalculateStatutoryParentalBereavementLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryParentalBereavementLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSpbpCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spbpcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public UkSppDataApiModel GetStatutoryPaternityLeavePeriodData(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSppDataApiModel> GetStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, GetStatutoryPaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Statutory Paternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Paternity Leave period for an employee
        /// </remarks>
        public UkSppDataApiResponseModel CreateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, UkSppDataApiModel spp)
        {
            return ApiRequest<UkSppDataApiResponseModel,UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp", spp, Method.Post);
        }

        /// <summary>
        /// Create Statutory Paternity Leave Period data
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Paternity Leave period for an employee
        /// </remarks>
        public Task<UkSppDataApiResponseModel> CreateStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, UkSppDataApiModel spp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppDataApiResponseModel,UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp", spp, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public UkSppDataApiModel GetStatutoryPaternityLeavePeriodDataById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Period Data By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee
        /// </remarks>
        public Task<UkSppDataApiModel> GetStatutoryPaternityLeavePeriodDataByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppDataApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Attachments
        /// </summary>
        public List<EmployeeDocumentModel> GetStatutoryPaternityLeaveAttachments(int businessId, int employeeId, int id)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}/attachments", Method.Get);
        }

        /// <summary>
        /// Get Statutory Paternity Leave Attachments
        /// </summary>
        public Task<List<EmployeeDocumentModel>> GetStatutoryPaternityLeaveAttachmentsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}/attachments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Paternity Leave
        /// </summary>
        public EmployeeDocumentModel AttachEmployeeDocumentToStatutoryPaternityLeave(int businessId, int employeeId, int id, int documentId)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}/employeedocument/{documentId}", Method.Put);
        }

        /// <summary>
        /// Attach Employee Document to Statutory Paternity Leave
        /// </summary>
        public Task<EmployeeDocumentModel> AttachEmployeeDocumentToStatutoryPaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}/employeedocument/{documentId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Paternity Leave
        /// </summary>
        public void UnattachEmployeeDocumentFromStatutoryPaternityLeave(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}/employeedocument/{documentId}", Method.Delete);
        }

        /// <summary>
        /// Unattach Employee Document from Statutory Paternity Leave
        /// </summary>
        public Task UnattachEmployeeDocumentFromStatutoryPaternityLeaveAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/spp/{id}/employeedocument/{documentId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Calculate Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public UkSppCalcApiModel CalculateStatutoryPaternityLeavePeriodData(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request)
        {
            return ApiRequest<UkSppCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Calculate Statutory Paternity Leave Period Data
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Paternity Leave period data for a specific employee including information about payments already made and pending
        /// </remarks>
        public Task<UkSppCalcApiModel> CalculateStatutoryPaternityLeavePeriodDataAsync(int businessId, int employeeId, CalculateStatutoryPaternityLeavePeriodDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSppCalcApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/sppcalc?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Employee
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay records for the employee between the specified dates
        /// </remarks>
        public List<UkSspApiModel> GetStatutorySickPayByEmployee(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request)
        {
            return ApiRequest<List<UkSspApiModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Employee
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay records for the employee between the specified dates
        /// </remarks>
        public Task<List<UkSspApiModel>> GetStatutorySickPayByEmployeeAsync(int businessId, int employeeId, GetStatutorySickPayByEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkSspApiModel>>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp?periodStart={request.PeriodStart.ToString("yyyy-MM-ddTHH:mm:ss")}&periodEnd={request.PeriodEnd.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Statutory Sick Pay
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Sick Pay leave period for an employee
        /// </remarks>
        public UkSspApiModel CreateStatutorySickPay(int businessId, int employeeId, UkSspApiModel ssp)
        {
            return ApiRequest<UkSspApiModel,UkSspApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp", ssp, Method.Post);
        }

        /// <summary>
        /// Create Statutory Sick Pay
        /// </summary>
        /// <remarks>
        /// Creates a Statutory Sick Pay leave period for an employee
        /// </remarks>
        public Task<UkSspApiModel> CreateStatutorySickPayAsync(int businessId, int employeeId, UkSspApiModel ssp, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSspApiModel,UkSspApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp", ssp, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay record for the employee for the given ID.
        /// </remarks>
        public UkSspApiModel GetStatutorySickPayById(int businessId, int employeeId, int periodOfLeaveId)
        {
            return ApiRequest<UkSspApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp/{periodOfLeaveId}", Method.Get);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Id
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Sick Pay record for the employee for the given ID.
        /// </remarks>
        public Task<UkSspApiModel> GetStatutorySickPayByIdAsync(int businessId, int employeeId, int periodOfLeaveId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSspApiModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp/{periodOfLeaveId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Statutory Sick Pay
        /// </summary>
        public PeriodOfLeaveModel UpdateStatutorySickPay(int businessId, int employeeId, int periodOfLeaveId, UkSspUpdateModel model)
        {
            return ApiRequest<PeriodOfLeaveModel,UkSspUpdateModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp/{periodOfLeaveId}", model, Method.Put);
        }

        /// <summary>
        /// Update Statutory Sick Pay
        /// </summary>
        public Task<PeriodOfLeaveModel> UpdateStatutorySickPayAsync(int businessId, int employeeId, int periodOfLeaveId, UkSspUpdateModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PeriodOfLeaveModel,UkSspUpdateModel>($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp/{periodOfLeaveId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Period of Leave
        /// </summary>
        public void DeletePeriodOfLeave(int businessId, int employeeId, int periodOfLeaveId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp/{periodOfLeaveId}", Method.Delete);
        }

        /// <summary>
        /// Delete Period of Leave
        /// </summary>
        public Task DeletePeriodOfLeaveAsync(int businessId, int employeeId, int periodOfLeaveId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/statutoryleave/ssp/{periodOfLeaveId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Sync Employee to QBO
        /// </summary>
        /// <remarks>
        /// Syncs an employee record to QBO.
        /// </remarks>
        public void SyncEmployeeToQbo(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/synctoqbo", Method.Post);
        }

        /// <summary>
        /// Sync Employee to QBO
        /// </summary>
        /// <remarks>
        /// Syncs an employee record to QBO.
        /// </remarks>
        public Task SyncEmployeeToQboAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/synctoqbo", Method.Post, cancellationToken);
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
            return ApiRequest<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
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
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Year to date
        /// </summary>
        public YearToDateModel GetYearToDate(int businessId, int employeeId, GetYearToDateQueryModel request)
        {
            return ApiRequest<YearToDateModel>($"/business/{businessId}/employee/{employeeId}/yeartodate?referenceDate={(request.ReferenceDate.HasValue ? request.ReferenceDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Year to date
        /// </summary>
        public Task<YearToDateModel> GetYearToDateAsync(int businessId, int employeeId, GetYearToDateQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<YearToDateModel>($"/business/{businessId}/employee/{employeeId}/yeartodate?referenceDate={(request.ReferenceDate.HasValue ? request.ReferenceDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
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
        public List<UkUnstructuredEmployeeModel> ListEmployees(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
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
        public Task<List<UkUnstructuredEmployeeModel>> ListEmployeesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.Get);
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
            return ApiRequestAsync<List<UkUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.Get, cancellationToken);
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
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// <p>Bypassing address validation:</p>
        /// <p>By default we validate addresses when they are entered. If for any reason you want to skip this validation, please follow the steps below.</p>
        /// <ol>
        ///   <li>Set "ResidentialAddressIsOverseas" and "PostalAddressIsOverseas" to "true" (this needs to be a boolean in a string).</li>
        ///   <li>Set "ResidentialCountry" and "PostalCountry" to the country of the address (e.g. United Kingdom)</li>
        ///   <li>Now you can enter your address unrestricted in the normal fields.</li>
        /// </ol>
        /// <p>Please note that when ResidentialAddressIsOverseas is set to "true", ResidentialCountry <b>must</b> be set and likewise with PostalAddressIsOverseas and PostalCountry.</p>
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.Post);
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
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// <p>Bypassing address validation:</p>
        /// <p>By default we validate addresses when they are entered. If for any reason you want to skip this validation, please follow the steps below.</p>
        /// <ol>
        ///   <li>Set "ResidentialAddressIsOverseas" and "PostalAddressIsOverseas" to "true" (this needs to be a boolean in a string).</li>
        ///   <li>Set "ResidentialCountry" and "PostalCountry" to the country of the address (e.g. United Kingdom)</li>
        ///   <li>Now you can enter your address unrestricted in the normal fields.</li>
        /// </ol>
        /// <p>Please note that when ResidentialAddressIsOverseas is set to "true", ResidentialCountry <b>must</b> be set and likewise with PostalAddressIsOverseas and PostalCountry.</p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.Post, cancellationToken);
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
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// <p>Bypassing address validation:</p>
        /// <p>By default we validate addresses when they are entered. If for any reason you want to skip this validation, please follow the steps below.</p>
        /// <ol>
        ///   <li>Set "ResidentialAddressIsOverseas" and "PostalAddressIsOverseas" to "true" (this needs to be a boolean in a string).</li>
        ///   <li>Set "ResidentialCountry" and "PostalCountry" to the country of the address (e.g. United Kingdom)</li>
        ///   <li>Now you can enter your address unrestricted in the normal fields.</li>
        /// </ol>
        /// <p>Please note that when ResidentialAddressIsOverseas is set to "true", ResidentialCountry <b>must</b> be set and likewise with PostalAddressIsOverseas and PostalCountry.</p>
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, UkUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.Post);
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
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// <p>Bypassing address validation:</p>
        /// <p>By default we validate addresses when they are entered. If for any reason you want to skip this validation, please follow the steps below.</p>
        /// <ol>
        ///   <li>Set "ResidentialAddressIsOverseas" and "PostalAddressIsOverseas" to "true" (this needs to be a boolean in a string).</li>
        ///   <li>Set "ResidentialCountry" and "PostalCountry" to the country of the address (e.g. United Kingdom)</li>
        ///   <li>Now you can enter your address unrestricted in the normal fields.</li>
        /// </ol>
        /// <p>Please note that when ResidentialAddressIsOverseas is set to "true", ResidentialCountry <b>must</b> be set and likewise with PostalAddressIsOverseas and PostalCountry.</p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> CreateOrUpdateEmployeeAsync(int businessId, UkUnstructuredEmployeeModel model, CreateOrUpdateEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByIdAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// Only fields to be updated need be specified. Fields left unspecified or null will not be changed.
        /// To update a field provide the new value, to specifically clear a value use the string "(clear)".
        /// <p>Bypassing address validation:</p><p>By default we validate addresses when they are entered. If for any reason you want to skip this validation, please follow the steps below.</p><ol><li>Set "ResidentialAddressIsOverseas" and "PostalAddressIsOverseas" to "true" (this needs to be a boolean in a string).</li><li>Set "ResidentialCountry" and "PostalCountry" to the country of the address (e.g. United Kingdom)</li><li>Now you can enter your address unrestricted in the normal fields.</li></ol><p>Please note that when ResidentialAddressIsOverseas is set to "true", ResidentialCountry <b>must</b> be set and likewise with PostalAddressIsOverseas and PostalCountry.</p>
        /// </remarks>
        public EmployeeUpdateResponseModel UpdateEmployee(int businessId, int employeeId, UkUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// Only fields to be updated need be specified. Fields left unspecified or null will not be changed.
        /// To update a field provide the new value, to specifically clear a value use the string "(clear)".
        /// <p>Bypassing address validation:</p><p>By default we validate addresses when they are entered. If for any reason you want to skip this validation, please follow the steps below.</p><ol><li>Set "ResidentialAddressIsOverseas" and "PostalAddressIsOverseas" to "true" (this needs to be a boolean in a string).</li><li>Set "ResidentialCountry" and "PostalCountry" to the country of the address (e.g. United Kingdom)</li><li>Now you can enter your address unrestricted in the normal fields.</li></ol><p>Please note that when ResidentialAddressIsOverseas is set to "true", ResidentialCountry <b>must</b> be set and likewise with PostalAddressIsOverseas and PostalCountry.</p>
        /// </remarks>
        public Task<EmployeeUpdateResponseModel> UpdateEmployeeAsync(int businessId, int employeeId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModel,UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}", Method.Get);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalIdAsync(int businessId, string externalId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public UkUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source)
        {
            return ApiRequest<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}", Method.Get);
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> GetEmployeeByExternalReferenceIdAsync(int businessId, string externalReferenceId, ExternalService source, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}", Method.Get, cancellationToken);
        }
    }
}
