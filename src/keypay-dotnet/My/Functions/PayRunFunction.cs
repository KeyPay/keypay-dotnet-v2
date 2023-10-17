using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.PayRun;

namespace KeyPayV2.My.Functions
{
    public interface IPayRunFunction
    {
        List<PayRunTotalModel> ListPayRunTotalsForEmployee(int businessId, int employeeId);
        Task<List<PayRunTotalModel>> ListPayRunTotalsForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<MyJournalItemResponse> GetJournalDetails(int businessId, int payRunId);
        Task<List<MyJournalItemResponse>> GetJournalDetailsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        List<PayRunModel> ListPayRuns(int businessId, ODataQuery oDataQuery = null);
        Task<List<PayRunModel>> ListPayRunsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        PayRunModel CreatePayRun(int businessId, PayRunCreateRequest request);
        Task<PayRunModel> CreatePayRunSynchronouslyAsync(int businessId, PayRunCreateRequest request, CancellationToken cancellationToken = default);
        PayRunModel GetPayRun(int businessId, int payRunId);
        Task<PayRunModel> GetPayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void DeletePayRun(int businessId, int payRunId);
        Task DeletePayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void StartApprovalProcess(int businessId, int payRunId);
        Task StartApprovalProcessAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        ApplyLeaveRequestResult BulkApplyLeaveRequests(int businessId, int payRunId, BulkApplyLeaveRequestModel bulkApplyLeaveRequestModel);
        Task<ApplyLeaveRequestResult> BulkApplyLeaveRequestsAsync(int businessId, int payRunId, BulkApplyLeaveRequestModel bulkApplyLeaveRequestModel, CancellationToken cancellationToken = default);
        MyPayRunDeductionResponse ListDeductions(int businessId, int payRunId);
        Task<MyPayRunDeductionResponse> ListDeductionsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void CreateDeductions(int businessId, int payRunId, SubmitPayRunDeductionRequest request);
        Task CreateDeductionsAsync(int businessId, int payRunId, SubmitPayRunDeductionRequest request, CancellationToken cancellationToken = default);
        void DeleteDeduction(int businessId, int payRunId, DeleteDeductionQueryModel request);
        Task DeleteDeductionAsync(int businessId, int payRunId, DeleteDeductionQueryModel request, CancellationToken cancellationToken = default);
        MyPayRunDeductionResponse GetDeductionsByEmployeeId(int businessId, int employeeId, int payRunId);
        Task<MyPayRunDeductionResponse> GetDeductionsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        MyPayRunEarningsLineResponseModel ListEarningsLines(int businessId, int payRunId);
        Task<MyPayRunEarningsLineResponseModel> ListEarningsLinesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void CreateEarningsLines(int businessId, int payRunId, MySubmitPayRunEarningsLineRequest request);
        Task CreateEarningsLinesAsync(int businessId, int payRunId, MySubmitPayRunEarningsLineRequest request, CancellationToken cancellationToken = default);
        void DeleteEarningsLine(int businessId, int payRunId, DeleteEarningsLineQueryModel request);
        Task DeleteEarningsLineAsync(int businessId, int payRunId, DeleteEarningsLineQueryModel request, CancellationToken cancellationToken = default);
        MyPayRunEarningsLineResponseModel GetEarningsLinesByEmployeeId(int businessId, int employeeId, int payRunId);
        Task<MyPayRunEarningsLineResponseModel> GetEarningsLinesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        PayRunTotalModel IncludeEmployee(int businessId, int employeeId, int payRunId);
        Task<PayRunTotalModel> IncludeEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        void RemoveEmployeeFromPayRun(int businessId, int employeeId, int payRunId);
        Task RemoveEmployeeFromPayRunAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        PayRunEmployeeExpenseResponse ListEmployeeExpenses(int businessId, int payRunId);
        Task<PayRunEmployeeExpenseResponse> ListEmployeeExpensesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void CreateEmployeeExpenses(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request);
        Task CreateEmployeeExpensesAsync(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request, CancellationToken cancellationToken = default);
        void DeleteEmployeeExpense(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request);
        Task DeleteEmployeeExpenseAsync(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request, CancellationToken cancellationToken = default);
        PayRunEmployeeExpenseResponse GetEmployeeExpensesByEmployeeId(int businessId, int employeeId, int payRunId);
        Task<PayRunEmployeeExpenseResponse> GetEmployeeExpensesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        PayRunEmployerLiabilityResponse ListEmployerLiabilities(int businessId, int payRunId);
        Task<PayRunEmployerLiabilityResponse> ListEmployerLiabilitiesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void CreateEmployerLiabilities(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request);
        Task CreateEmployerLiabilitiesAsync(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request, CancellationToken cancellationToken = default);
        void DeleteEmployerLiability(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request);
        Task DeleteEmployerLiabilityAsync(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request, CancellationToken cancellationToken = default);
        PayRunEmployerLiabilityResponse GetEmployerLiabilitiesByEmployeeId(int businessId, int employeeId, int payRunId);
        Task<PayRunEmployerLiabilityResponse> GetEmployerLiabilitiesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        byte[] GetPaySlipFile(int businessId, int employeeId, int payRunId);
        Task<byte[]> GetPaySlipFileAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        PayRunFinaliseResult FinalisePayRun(int businessId, int payRunId, FinalisePayRunOptions options);
        Task<PayRunFinaliseResult> FinalisePayRunAsync(int businessId, int payRunId, FinalisePayRunOptions options, CancellationToken cancellationToken = default);
        LeaveAccrualResponse GetLeaveAccruals(int businessId, int payRunId);
        Task<LeaveAccrualResponse> GetLeaveAccrualsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        LeaveAccrualResponse GetLeaveAccruals(int businessId, int payRunId, GetLeaveAccrualsQueryModel request);
        Task<LeaveAccrualResponse> GetLeaveAccrualsAsync(int businessId, int payRunId, GetLeaveAccrualsQueryModel request, CancellationToken cancellationToken = default);
        void SaveLeaveAccruals(int businessId, int payRunId, SubmitLeaveAccrualsModel model);
        Task SaveLeaveAccrualsAsync(int businessId, int payRunId, SubmitLeaveAccrualsModel model, CancellationToken cancellationToken = default);
        void DeleteLeaveAccrual(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request);
        Task DeleteLeaveAccrualAsync(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request, CancellationToken cancellationToken = default);
        LeaveAccrualResponse GetLeaveAccrualsForEmployee(int businessId, int employeeId, int payRunId);
        Task<LeaveAccrualResponse> GetLeaveAccrualsForEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        LeaveAccrualResponse GetLeaveAccrualsForEmployee(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request);
        Task<LeaveAccrualResponse> GetLeaveAccrualsForEmployeeAsync(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request, CancellationToken cancellationToken = default);
        NetToGrossModel NetToGross(int businessId, NetToGrossRequest netToGrossRequest, string payRunId);
        Task<NetToGrossModel> NetToGrossAsync(int businessId, NetToGrossRequest netToGrossRequest, string payRunId, CancellationToken cancellationToken = default);
        void SetPayRunNotation(int businessId, int payRunId, PayRunNotationModel model);
        Task SetPayRunNotationAsync(int businessId, int payRunId, PayRunNotationModel model, CancellationToken cancellationToken = default);
        void DeletePayRunNotation(int businessId, int payRunId);
        Task DeletePayRunNotationAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        PayRunTotalNotationModel CreateNoteForEmployee(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model);
        Task<PayRunTotalNotationModel> CreateNoteForEmployeeAsync(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model, CancellationToken cancellationToken = default);
        void DeleteNoteForEmployee(int businessId, int employeeId, int payRunId);
        Task DeleteNoteForEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        List<MyBankPaymentModel> GetPayRunPayments(int businessId, int payRunId);
        Task<List<MyBankPaymentModel>> GetPayRunPaymentsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        Dictionary<String,MyApiPaySlipModel> ListPaySlipData(int businessId, int payRunId);
        Task<Dictionary<String,MyApiPaySlipModel>> ListPaySlipDataAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        Dictionary<String,MyApiPaySlipModel> ListPaySlipData(int businessId, int payRunId, ListPaySlipDataQueryModel request);
        Task<Dictionary<String,MyApiPaySlipModel>> ListPaySlipDataAsync(int businessId, int payRunId, ListPaySlipDataQueryModel request, CancellationToken cancellationToken = default);
        MyApiPaySlipModel GetPaySlipDataByEmployeeId(int businessId, int employeeId, int payRunId);
        Task<MyApiPaySlipModel> GetPaySlipDataByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        MyApiPaySlipModel GetPaySlipDataByEmployeeId(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request);
        Task<MyApiPaySlipModel> GetPaySlipDataByEmployeeIdAsync(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request, CancellationToken cancellationToken = default);
        void Recalculate(int businessId, int payRunId);
        Task RecalculateAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void SetUiUnlockEnabled(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request);
        Task SetUiUnlockEnabledAsync(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request, CancellationToken cancellationToken = default);
        PayRunSummaryModel GetPayRunSummary(int businessId, int payRunId);
        Task<PayRunSummaryModel> GetPayRunSummaryAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void TerminateEmployeeInPayRun(int businessId, int payRunId, TerminateEmployeeRequest request);
        Task TerminateEmployeeInPayRunAsync(int businessId, int payRunId, TerminateEmployeeRequest request, CancellationToken cancellationToken = default);
        MyPayRunTotalResponse ListPayRunTotals(int businessId, int payRunId);
        Task<MyPayRunTotalResponse> ListPayRunTotalsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        MyPayRunTotalResponse GetPayRunTotalsByEmployeeId(int businessId, int employeeId, int payRunId);
        Task<MyPayRunTotalResponse> GetPayRunTotalsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default);
        void UnlockPayRun(int businessId, int payRunId, PayRunUnlockRequest request);
        Task UnlockPayRunAsync(int businessId, int payRunId, PayRunUnlockRequest request, CancellationToken cancellationToken = default);
        List<DetailedPayRunWarningModel> ListPayRunWarnings(int businessId, int payRunId);
        Task<List<DetailedPayRunWarningModel>> ListPayRunWarningsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        PayRunJobModel CreatePayRunAsync(int businessId, PayRunCreateRequest request);
        Task<PayRunJobModel> CreatePayRunAsynchronouslyAsync(int businessId, PayRunCreateRequest request, CancellationToken cancellationToken = default);
        PayRunJobStatusModel GetCreationStatus(int businessId, Guid jobId);
        Task<PayRunJobStatusModel> GetCreationStatusAsync(int businessId, Guid jobId, CancellationToken cancellationToken = default);
        List<PayRunSummaryModel> ListPayRunsSummaries(int businessId, ODataQuery oDataQuery = null);
        Task<List<PayRunSummaryModel>> ListPayRunsSummariesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
    }
    public class PayRunFunction : BaseFunction, IPayRunFunction
    {
        public PayRunFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Run Totals for Employee
        /// </summary>
        /// <remarks>
        /// Lists all the pay run totals for the employee with the specified ID.
        /// </remarks>
        public List<PayRunTotalModel> ListPayRunTotalsForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<List<PayRunTotalModel>>($"/business/{businessId}/employee/{employeeId}/payruntotals", Method.Get);
        }

        /// <summary>
        /// List Pay Run Totals for Employee
        /// </summary>
        /// <remarks>
        /// Lists all the pay run totals for the employee with the specified ID.
        /// </remarks>
        public Task<List<PayRunTotalModel>> ListPayRunTotalsForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRunTotalModel>>($"/business/{businessId}/employee/{employeeId}/payruntotals", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Journal Details
        /// </summary>
        /// <remarks>
        /// Gets the journal details for this pay run.
        /// </remarks>
        public List<MyJournalItemResponse> GetJournalDetails(int businessId, int payRunId)
        {
            return ApiRequest<List<MyJournalItemResponse>>($"/business/{businessId}/journal/{payRunId}", Method.Get);
        }

        /// <summary>
        /// Get Journal Details
        /// </summary>
        /// <remarks>
        /// Gets the journal details for this pay run.
        /// </remarks>
        public Task<List<MyJournalItemResponse>> GetJournalDetailsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyJournalItemResponse>>($"/business/{businessId}/journal/{payRunId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Pay Runs
        /// </summary>
        /// <remarks>
        /// Get a list of pay runs associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PayRunModel> ListPayRuns(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PayRunModel>>($"/business/{businessId}/payrun{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Runs
        /// </summary>
        /// <remarks>
        /// Get a list of pay runs associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PayRunModel>> ListPayRunsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRunModel>>($"/business/{businessId}/payrun{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Run
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business.
        /// </remarks>
        public PayRunModel CreatePayRun(int businessId, PayRunCreateRequest request)
        {
            return ApiRequest<PayRunModel,PayRunCreateRequest>($"/business/{businessId}/payrun", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Run
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business.
        /// </remarks>
        public Task<PayRunModel> CreatePayRunSynchronouslyAsync(int businessId, PayRunCreateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunModel,PayRunCreateRequest>($"/business/{businessId}/payrun", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Run
        /// </summary>
        /// <remarks>
        /// Gets the pay run with the specified ID.
        /// </remarks>
        public PayRunModel GetPayRun(int businessId, int payRunId)
        {
            return ApiRequest<PayRunModel>($"/business/{businessId}/payrun/{payRunId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Run
        /// </summary>
        /// <remarks>
        /// Gets the pay run with the specified ID.
        /// </remarks>
        public Task<PayRunModel> GetPayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunModel>($"/business/{businessId}/payrun/{payRunId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Run
        /// </summary>
        /// <remarks>
        /// Deletes the pay run with the specified ID.
        /// </remarks>
        public void DeletePayRun(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Run
        /// </summary>
        /// <remarks>
        /// Deletes the pay run with the specified ID.
        /// </remarks>
        public Task DeletePayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Start Approval Process
        /// </summary>
        /// <remarks>
        /// Start the approval process for a pay run that requires approval, notifying the default contacts for this pay schedule.
        /// </remarks>
        public void StartApprovalProcess(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/approval/start", Method.Post);
        }

        /// <summary>
        /// Start Approval Process
        /// </summary>
        /// <remarks>
        /// Start the approval process for a pay run that requires approval, notifying the default contacts for this pay schedule.
        /// </remarks>
        public Task StartApprovalProcessAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/approval/start", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Bulk Apply Leave Requests
        /// </summary>
        /// <remarks>
        /// Bulk apply leave requests
        /// </remarks>
        public ApplyLeaveRequestResult BulkApplyLeaveRequests(int businessId, int payRunId, BulkApplyLeaveRequestModel bulkApplyLeaveRequestModel)
        {
            return ApiRequest<ApplyLeaveRequestResult,BulkApplyLeaveRequestModel>($"/business/{businessId}/payrun/{payRunId}/bulkapplyleaverequests", bulkApplyLeaveRequestModel, Method.Post);
        }

        /// <summary>
        /// Bulk Apply Leave Requests
        /// </summary>
        /// <remarks>
        /// Bulk apply leave requests
        /// </remarks>
        public Task<ApplyLeaveRequestResult> BulkApplyLeaveRequestsAsync(int businessId, int payRunId, BulkApplyLeaveRequestModel bulkApplyLeaveRequestModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ApplyLeaveRequestResult,BulkApplyLeaveRequestModel>($"/business/{businessId}/payrun/{payRunId}/bulkapplyleaverequests", bulkApplyLeaveRequestModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Deductions
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a pay run.
        /// </remarks>
        public MyPayRunDeductionResponse ListDeductions(int businessId, int payRunId)
        {
            return ApiRequest<MyPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions", Method.Get);
        }

        /// <summary>
        /// List Deductions
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a pay run.
        /// </remarks>
        public Task<MyPayRunDeductionResponse> ListDeductionsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Deductions
        /// </summary>
        /// <remarks>
        /// Add deductions to the specified pay run.
        /// </remarks>
        public void CreateDeductions(int businessId, int payRunId, SubmitPayRunDeductionRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/deductions", request, Method.Post);
        }

        /// <summary>
        /// Create Deductions
        /// </summary>
        /// <remarks>
        /// Add deductions to the specified pay run.
        /// </remarks>
        public Task CreateDeductionsAsync(int businessId, int payRunId, SubmitPayRunDeductionRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/deductions", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the deduction with the specified ID from the pay run.
        /// </remarks>
        public void DeleteDeduction(int businessId, int payRunId, DeleteDeductionQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/deductions?id={request.Id}", Method.Delete);
        }

        /// <summary>
        /// Delete Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the deduction with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteDeductionAsync(int businessId, int payRunId, DeleteDeductionQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/deductions?id={request.Id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Deductions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a specific employee in a pay run.
        /// </remarks>
        public MyPayRunDeductionResponse GetDeductionsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<MyPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Deductions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a specific employee in a pay run.
        /// </remarks>
        public Task<MyPayRunDeductionResponse> GetDeductionsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Earnings Lines
        /// </summary>
        /// <remarks>
        /// Lists all the earnings lines for a pay run.
        /// </remarks>
        public MyPayRunEarningsLineResponseModel ListEarningsLines(int businessId, int payRunId)
        {
            return ApiRequest<MyPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines", Method.Get);
        }

        /// <summary>
        /// List Earnings Lines
        /// </summary>
        /// <remarks>
        /// Lists all the earnings lines for a pay run.
        /// </remarks>
        public Task<MyPayRunEarningsLineResponseModel> ListEarningsLinesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Earnings Lines
        /// </summary>
        /// <remarks>
        /// Adds earnings lines to the specified pay run.
        /// </remarks>
        public void CreateEarningsLines(int businessId, int payRunId, MySubmitPayRunEarningsLineRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/earningslines", request, Method.Post);
        }

        /// <summary>
        /// Create Earnings Lines
        /// </summary>
        /// <remarks>
        /// Adds earnings lines to the specified pay run.
        /// </remarks>
        public Task CreateEarningsLinesAsync(int businessId, int payRunId, MySubmitPayRunEarningsLineRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/earningslines", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Earnings Line
        /// </summary>
        /// <remarks>
        /// Deletes the earnings with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEarningsLine(int businessId, int payRunId, DeleteEarningsLineQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/earningslines?id={request.Id}", Method.Delete);
        }

        /// <summary>
        /// Delete Earnings Line
        /// </summary>
        /// <remarks>
        /// Deletes the earnings with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteEarningsLineAsync(int businessId, int payRunId, DeleteEarningsLineQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/earningslines?id={request.Id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Earnings Lines by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the earnings lines for a specific employee in a pay run.
        /// </remarks>
        public MyPayRunEarningsLineResponseModel GetEarningsLinesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<MyPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Earnings Lines by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the earnings lines for a specific employee in a pay run.
        /// </remarks>
        public Task<MyPayRunEarningsLineResponseModel> GetEarningsLinesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Include Employee
        /// </summary>
        /// <remarks>
        /// Includes an employee in a pay run.
        /// </remarks>
        public PayRunTotalModel IncludeEmployee(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunTotalModel>($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.Post);
        }

        /// <summary>
        /// Include Employee
        /// </summary>
        /// <remarks>
        /// Includes an employee in a pay run.
        /// </remarks>
        public Task<PayRunTotalModel> IncludeEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunTotalModel>($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Remove Employee from Pay Run
        /// </summary>
        /// <remarks>
        /// Removes an employee from a pay run.
        /// </remarks>
        public void RemoveEmployeeFromPayRun(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.Delete);
        }

        /// <summary>
        /// Remove Employee from Pay Run
        /// </summary>
        /// <remarks>
        /// Removes an employee from a pay run.
        /// </remarks>
        public Task RemoveEmployeeFromPayRunAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the employee expenses for a pay run.
        /// </remarks>
        public PayRunEmployeeExpenseResponse ListEmployeeExpenses(int businessId, int payRunId)
        {
            return ApiRequest<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", Method.Get);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the employee expenses for a pay run.
        /// </remarks>
        public Task<PayRunEmployeeExpenseResponse> ListEmployeeExpensesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Expenses
        /// </summary>
        /// <remarks>
        /// Add employee expenses to the specified pay run.
        /// </remarks>
        public void CreateEmployeeExpenses(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", request, Method.Post);
        }

        /// <summary>
        /// Create Employee Expenses
        /// </summary>
        /// <remarks>
        /// Add employee expenses to the specified pay run.
        /// </remarks>
        public Task CreateEmployeeExpensesAsync(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEmployeeExpense(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses?id={request.Id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteEmployeeExpenseAsync(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses?id={request.Id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expenses by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employee expenses for a specific employee in a pay run.
        /// </remarks>
        public PayRunEmployeeExpenseResponse GetEmployeeExpensesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Employee Expenses by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employee expenses for a specific employee in a pay run.
        /// </remarks>
        public Task<PayRunEmployeeExpenseResponse> GetEmployeeExpensesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the employer liabilities for a pay run.
        /// </remarks>
        public PayRunEmployerLiabilityResponse ListEmployerLiabilities(int businessId, int payRunId)
        {
            return ApiRequest<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities", Method.Get);
        }

        /// <summary>
        /// List Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the employer liabilities for a pay run.
        /// </remarks>
        public Task<PayRunEmployerLiabilityResponse> ListEmployerLiabilitiesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Add employer liabilities to the specified pay run.
        /// </remarks>
        public void CreateEmployerLiabilities(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employerliabilities", request, Method.Post);
        }

        /// <summary>
        /// Create Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Add employer liabilities to the specified pay run.
        /// </remarks>
        public Task CreateEmployerLiabilitiesAsync(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/employerliabilities", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Employer Liability
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEmployerLiability(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employerliabilities?id={request.Id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employer Liability
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteEmployerLiabilityAsync(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/employerliabilities?id={request.Id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Employer Liabilities by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employer liabilities for a specific employee in a pay run.
        /// </remarks>
        public PayRunEmployerLiabilityResponse GetEmployerLiabilitiesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Employer Liabilities by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employer liabilities for a specific employee in a pay run.
        /// </remarks>
        public Task<PayRunEmployerLiabilityResponse> GetEmployerLiabilitiesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip File
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for an employee in a pay run.
        /// </remarks>
        public byte[] GetPaySlipFile(int businessId, int employeeId, int payRunId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/payrun/{payRunId}/file/payslip/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Slip File
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for an employee in a pay run.
        /// </remarks>
        public Task<byte[]> GetPaySlipFileAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/payrun/{payRunId}/file/payslip/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Finalise Pay Run
        /// </summary>
        /// <remarks>
        /// Finalises the specified pay run. A pay run can only be finalised if there are no calculations in progress.
        /// </remarks>
        public PayRunFinaliseResult FinalisePayRun(int businessId, int payRunId, FinalisePayRunOptions options)
        {
            return ApiRequest<PayRunFinaliseResult,FinalisePayRunOptions>($"/business/{businessId}/payrun/{payRunId}/finalise", options, Method.Post);
        }

        /// <summary>
        /// Finalise Pay Run
        /// </summary>
        /// <remarks>
        /// Finalises the specified pay run. A pay run can only be finalised if there are no calculations in progress.
        /// </remarks>
        public Task<PayRunFinaliseResult> FinalisePayRunAsync(int businessId, int payRunId, FinalisePayRunOptions options, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunFinaliseResult,FinalisePayRunOptions>($"/business/{businessId}/payrun/{payRunId}/finalise", options, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccruals(int businessId, int payRunId)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", Method.Get);
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public Task<LeaveAccrualResponse> GetLeaveAccrualsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccruals(int businessId, int payRunId, GetLeaveAccrualsQueryModel request)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?includeLeaveTaken={request.IncludeLeaveTaken}", Method.Get);
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public Task<LeaveAccrualResponse> GetLeaveAccrualsAsync(int businessId, int payRunId, GetLeaveAccrualsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?includeLeaveTaken={request.IncludeLeaveTaken}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Save Leave Accruals
        /// </summary>
        /// <remarks>
        /// Saves a set of leave accruals for the pay run.
        /// </remarks>
        public void SaveLeaveAccruals(int businessId, int payRunId, SubmitLeaveAccrualsModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", model, Method.Post);
        }

        /// <summary>
        /// Save Leave Accruals
        /// </summary>
        /// <remarks>
        /// Saves a set of leave accruals for the pay run.
        /// </remarks>
        public Task SaveLeaveAccrualsAsync(int businessId, int payRunId, SubmitLeaveAccrualsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Accrual
        /// </summary>
        /// <remarks>
        /// Deletes the manually added leave accrual, leave taken or leave adjustment with the specified ID from the pay run.
        /// </remarks>
        public void DeleteLeaveAccrual(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?id={request.Id}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Accrual
        /// </summary>
        /// <remarks>
        /// Deletes the manually added leave accrual, leave taken or leave adjustment with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteLeaveAccrualAsync(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?id={request.Id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccrualsForEmployee(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public Task<LeaveAccrualResponse> GetLeaveAccrualsForEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccrualsForEmployee(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}?includeLeaveTaken={request.IncludeLeaveTaken}", Method.Get);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public Task<LeaveAccrualResponse> GetLeaveAccrualsForEmployeeAsync(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}?includeLeaveTaken={request.IncludeLeaveTaken}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Net to Gross
        /// </summary>
        /// <remarks>
        /// Calculates net to gross for a given pay run.
        /// </remarks>
        public NetToGrossModel NetToGross(int businessId, NetToGrossRequest netToGrossRequest, string payRunId)
        {
            return ApiRequest<NetToGrossModel,NetToGrossRequest>($"/business/{businessId}/payrun/{payRunId}/nettogross", netToGrossRequest, Method.Post);
        }

        /// <summary>
        /// Net to Gross
        /// </summary>
        /// <remarks>
        /// Calculates net to gross for a given pay run.
        /// </remarks>
        public Task<NetToGrossModel> NetToGrossAsync(int businessId, NetToGrossRequest netToGrossRequest, string payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NetToGrossModel,NetToGrossRequest>($"/business/{businessId}/payrun/{payRunId}/nettogross", netToGrossRequest, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Set Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Sets the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public void SetPayRunNotation(int businessId, int payRunId, PayRunNotationModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation", model, Method.Post);
        }

        /// <summary>
        /// Set Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Sets the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public Task SetPayRunNotationAsync(int businessId, int payRunId, PayRunNotationModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Deletes the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public void DeletePayRunNotation(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Deletes the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public Task DeletePayRunNotationAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Create Note for Employee
        /// </summary>
        /// <remarks>
        /// Creates a note for an employee record in a pay run.
        /// </remarks>
        public PayRunTotalNotationModel CreateNoteForEmployee(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model)
        {
            return ApiRequest<PayRunTotalNotationModel,PayRunTotalNotationModel>($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", model, Method.Post);
        }

        /// <summary>
        /// Create Note for Employee
        /// </summary>
        /// <remarks>
        /// Creates a note for an employee record in a pay run.
        /// </remarks>
        public Task<PayRunTotalNotationModel> CreateNoteForEmployeeAsync(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunTotalNotationModel,PayRunTotalNotationModel>($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Note for Employee
        /// </summary>
        /// <remarks>
        /// Deletes the note for an employee record in a pay run.
        /// </remarks>
        public void DeleteNoteForEmployee(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", Method.Delete);
        }

        /// <summary>
        /// Delete Note for Employee
        /// </summary>
        /// <remarks>
        /// Deletes the note for an employee record in a pay run.
        /// </remarks>
        public Task DeleteNoteForEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get pay run payments
        /// </summary>
        /// <remarks>
        /// Gets the payments associated with a pay run.
        /// </remarks>
        public List<MyBankPaymentModel> GetPayRunPayments(int businessId, int payRunId)
        {
            return ApiRequest<List<MyBankPaymentModel>>($"/business/{businessId}/payrun/{payRunId}/payments", Method.Get);
        }

        /// <summary>
        /// Get pay run payments
        /// </summary>
        /// <remarks>
        /// Gets the payments associated with a pay run.
        /// </remarks>
        public Task<List<MyBankPaymentModel>> GetPayRunPaymentsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyBankPaymentModel>>($"/business/{businessId}/payrun/{payRunId}/payments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Dictionary<String,MyApiPaySlipModel> ListPaySlipData(int businessId, int payRunId)
        {
            return ApiRequest<Dictionary<String,MyApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips", Method.Get);
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Task<Dictionary<String,MyApiPaySlipModel>> ListPaySlipDataAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<String,MyApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Dictionary<String,MyApiPaySlipModel> ListPaySlipData(int businessId, int payRunId, ListPaySlipDataQueryModel request)
        {
            return ApiRequest<Dictionary<String,MyApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips?showAllData={request.ShowAllData}", Method.Get);
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Task<Dictionary<String,MyApiPaySlipModel>> ListPaySlipDataAsync(int businessId, int payRunId, ListPaySlipDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<String,MyApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips?showAllData={request.ShowAllData}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public MyApiPaySlipModel GetPaySlipDataByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<MyApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public Task<MyApiPaySlipModel> GetPaySlipDataByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public MyApiPaySlipModel GetPaySlipDataByEmployeeId(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request)
        {
            return ApiRequest<MyApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}?showAllData={request.ShowAllData}", Method.Get);
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public Task<MyApiPaySlipModel> GetPaySlipDataByEmployeeIdAsync(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}?showAllData={request.ShowAllData}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Recalculate
        /// </summary>
        /// <remarks>
        /// Recalculates a pay run.
        /// </remarks>
        public void Recalculate(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/recalculate", Method.Post);
        }

        /// <summary>
        /// Recalculate
        /// </summary>
        /// <remarks>
        /// Recalculates a pay run.
        /// </remarks>
        public Task RecalculateAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/recalculate", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Set UI Unlock enabled
        /// </summary>
        /// <remarks>
        /// Sets whether a pay run can be unlocked by the UI or not. Only applies to finalized pay runs.
        /// </remarks>
        public void SetUiUnlockEnabled(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/setuiunlockstate", request, Method.Post);
        }

        /// <summary>
        /// Set UI Unlock enabled
        /// </summary>
        /// <remarks>
        /// Sets whether a pay run can be unlocked by the UI or not. Only applies to finalized pay runs.
        /// </remarks>
        public Task SetUiUnlockEnabledAsync(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/setuiunlockstate", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Run Summary
        /// </summary>
        /// <remarks>
        /// Gets the pay run summary information with the specified ID.
        /// </remarks>
        public PayRunSummaryModel GetPayRunSummary(int businessId, int payRunId)
        {
            return ApiRequest<PayRunSummaryModel>($"/business/{businessId}/payrun/{payRunId}/summary", Method.Get);
        }

        /// <summary>
        /// Get Pay Run Summary
        /// </summary>
        /// <remarks>
        /// Gets the pay run summary information with the specified ID.
        /// </remarks>
        public Task<PayRunSummaryModel> GetPayRunSummaryAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunSummaryModel>($"/business/{businessId}/payrun/{payRunId}/summary", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Terminate Employee in Pay Run
        /// </summary>
        /// <remarks>
        /// Terminates an employee in the specified pay run.
        /// </remarks>
        public void TerminateEmployeeInPayRun(int businessId, int payRunId, TerminateEmployeeRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/terminate", request, Method.Post);
        }

        /// <summary>
        /// Terminate Employee in Pay Run
        /// </summary>
        /// <remarks>
        /// Terminates an employee in the specified pay run.
        /// </remarks>
        public Task TerminateEmployeeInPayRunAsync(int businessId, int payRunId, TerminateEmployeeRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/terminate", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Pay Run Totals
        /// </summary>
        /// <remarks>
        /// Lists all of the pay run totals in a pay run.
        /// </remarks>
        public MyPayRunTotalResponse ListPayRunTotals(int businessId, int payRunId)
        {
            return ApiRequest<MyPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals", Method.Get);
        }

        /// <summary>
        /// List Pay Run Totals
        /// </summary>
        /// <remarks>
        /// Lists all of the pay run totals in a pay run.
        /// </remarks>
        public Task<MyPayRunTotalResponse> ListPayRunTotalsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Run Totals by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay run totals for a specific employee in a pay run.
        /// </remarks>
        public MyPayRunTotalResponse GetPayRunTotalsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<MyPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Run Totals by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay run totals for a specific employee in a pay run.
        /// </remarks>
        public Task<MyPayRunTotalResponse> GetPayRunTotalsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Unlock Pay Run
        /// </summary>
        /// <remarks>
        /// Unlocks the specified pay run.
        /// </remarks>
        public void UnlockPayRun(int businessId, int payRunId, PayRunUnlockRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/unlock", request, Method.Post);
        }

        /// <summary>
        /// Unlock Pay Run
        /// </summary>
        /// <remarks>
        /// Unlocks the specified pay run.
        /// </remarks>
        public Task UnlockPayRunAsync(int businessId, int payRunId, PayRunUnlockRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/unlock", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Pay Run Warnings
        /// </summary>
        /// <remarks>
        /// Lists all of the warnings in a pay run.
        /// </remarks>
        public List<DetailedPayRunWarningModel> ListPayRunWarnings(int businessId, int payRunId)
        {
            return ApiRequest<List<DetailedPayRunWarningModel>>($"/business/{businessId}/payrun/{payRunId}/warnings", Method.Get);
        }

        /// <summary>
        /// List Pay Run Warnings
        /// </summary>
        /// <remarks>
        /// Lists all of the warnings in a pay run.
        /// </remarks>
        public Task<List<DetailedPayRunWarningModel>> ListPayRunWarningsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DetailedPayRunWarningModel>>($"/business/{businessId}/payrun/{payRunId}/warnings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Run (Async)
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business asynchronously (the request will return before the pay run is created).
        /// </remarks>
        public PayRunJobModel CreatePayRunAsync(int businessId, PayRunCreateRequest request)
        {
            return ApiRequest<PayRunJobModel,PayRunCreateRequest>($"/business/{businessId}/payrun/async", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Run (Async)
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business asynchronously (the request will return before the pay run is created).
        /// </remarks>
        public Task<PayRunJobModel> CreatePayRunAsynchronouslyAsync(int businessId, PayRunCreateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunJobModel,PayRunCreateRequest>($"/business/{businessId}/payrun/async", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Creation Status
        /// </summary>
        /// <remarks>
        /// Gets the creation status of a pay run that was created asynchronously.
        /// </remarks>
        public PayRunJobStatusModel GetCreationStatus(int businessId, Guid jobId)
        {
            return ApiRequest<PayRunJobStatusModel>($"/business/{businessId}/payrun/creationstatus/{jobId}", Method.Get);
        }

        /// <summary>
        /// Get Creation Status
        /// </summary>
        /// <remarks>
        /// Gets the creation status of a pay run that was created asynchronously.
        /// </remarks>
        public Task<PayRunJobStatusModel> GetCreationStatusAsync(int businessId, Guid jobId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunJobStatusModel>($"/business/{businessId}/payrun/creationstatus/{jobId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Pay Runs Summaries
        /// </summary>
        /// <remarks>
        /// Get a list of pay run summaries associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PayRunSummaryModel> ListPayRunsSummaries(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PayRunSummaryModel>>($"/business/{businessId}/payrun/summary{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Runs Summaries
        /// </summary>
        /// <remarks>
        /// Get a list of pay run summaries associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PayRunSummaryModel>> ListPayRunsSummariesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRunSummaryModel>>($"/business/{businessId}/payrun/summary{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }
    }
}
