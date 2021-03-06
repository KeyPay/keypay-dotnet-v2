using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PayRun;

namespace KeyPayV2.Uk.Functions
{
    public class PayRunFunction : BaseFunction
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
            return ApiRequest<List<PayRunTotalModel>>($"/business/{businessId}/employee/{employeeId}/payruntotals");
        }

        /// <summary>
        /// Get Journal Details
        /// </summary>
        /// <remarks>
        /// Gets the journal details for this pay run.
        /// </remarks>
        public List<UkJournalItemResponse> GetJournalDetails(int businessId, int payRunId)
        {
            return ApiRequest<List<UkJournalItemResponse>>($"/business/{businessId}/journal/{payRunId}");
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
            return ApiRequest<List<PayRunModel>>($"/business/{businessId}/payrun{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Pay Run
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business.
        /// </remarks>
        public PayRunModel CreatePayRun(int businessId, PayRunCreateRequest request)
        {
            return ApiRequest<PayRunModel,PayRunCreateRequest>($"/business/{businessId}/payrun", request, Method.POST);
        }

        /// <summary>
        /// Get Pay Run
        /// </summary>
        /// <remarks>
        /// Gets the pay run with the specified ID.
        /// </remarks>
        public PayRunModel GetPayRun(int businessId, int payRunId)
        {
            return ApiRequest<PayRunModel>($"/business/{businessId}/payrun/{payRunId}");
        }

        /// <summary>
        /// Delete Pay Run
        /// </summary>
        /// <remarks>
        /// Deletes the pay run with the specified ID.
        /// </remarks>
        public void DeletePayRun(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}", Method.DELETE);
        }

        /// <summary>
        /// List Benefits
        /// </summary>
        /// <remarks>
        /// Lists all the benefits assigned to employees in the pay run.
        /// </remarks>
        public UkPayRunTotalBenefitResponse ListBenefits(int businessId, int payRunId)
        {
            return ApiRequest<UkPayRunTotalBenefitResponse>($"/business/{businessId}/payrun/{payRunId}/benefits");
        }

        /// <summary>
        /// Get Benefits
        /// </summary>
        /// <remarks>
        /// Gets all the benefits assigned to a particular employee in the pay run.
        /// </remarks>
        public UkPayRunTotalBenefitResponse GetBenefits(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<UkPayRunTotalBenefitResponse>($"/business/{businessId}/payrun/{payRunId}/benefits/{employeeId}");
        }

        /// <summary>
        /// List Deductions
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a pay run.
        /// </remarks>
        public UkPayRunDeductionResponse ListDeductions(int businessId, int payRunId)
        {
            return ApiRequest<UkPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions");
        }

        /// <summary>
        /// Create Deductions
        /// </summary>
        /// <remarks>
        /// Add deductions to the specified pay run.
        /// </remarks>
        public void CreateDeductions(int businessId, int payRunId, SubmitPayRunDeductionRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/deductions", request, Method.POST);
        }

        /// <summary>
        /// Delete Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the deduction with the specified ID from the pay run.
        /// </remarks>
        public void DeleteDeduction(int businessId, int payRunId, DeleteDeductionQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/deductions?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get Deductions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a specific employee in a pay run.
        /// </remarks>
        public UkPayRunDeductionResponse GetDeductionsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<UkPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions/{employeeId}");
        }

        /// <summary>
        /// List Earnings Lines
        /// </summary>
        /// <remarks>
        /// Lists all the earnings lines for a pay run.
        /// </remarks>
        public UkPayRunEarningsLineResponseModel ListEarningsLines(int businessId, int payRunId)
        {
            return ApiRequest<UkPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines");
        }

        /// <summary>
        /// Create Earnings Lines
        /// </summary>
        /// <remarks>
        /// Adds earnings lines to the specified pay run.
        /// </remarks>
        public void CreateEarningsLines(int businessId, int payRunId, UkSubmitPayRunEarningsLineRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/earningslines", request, Method.POST);
        }

        /// <summary>
        /// Delete Earnings Line
        /// </summary>
        /// <remarks>
        /// Deletes the earnings with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEarningsLine(int businessId, int payRunId, DeleteEarningsLineQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/earningslines?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get Earnings Lines by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the earnings lines for a specific employee in a pay run.
        /// </remarks>
        public UkPayRunEarningsLineResponseModel GetEarningsLinesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<UkPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines/{employeeId}");
        }

        /// <summary>
        /// Include Employee
        /// </summary>
        /// <remarks>
        /// Includes an employee in a pay run.
        /// </remarks>
        public PayRunTotalModel IncludeEmployee(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunTotalModel>($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.POST);
        }

        /// <summary>
        /// Remove Employee from Pay Run
        /// </summary>
        /// <remarks>
        /// Removes an employee from a pay run.
        /// </remarks>
        public void RemoveEmployeeFromPayRun(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.DELETE);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the employee expenses for a pay run.
        /// </remarks>
        public PayRunEmployeeExpenseResponse ListEmployeeExpenses(int businessId, int payRunId)
        {
            return ApiRequest<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses");
        }

        /// <summary>
        /// Create Employee Expenses
        /// </summary>
        /// <remarks>
        /// Add employee expenses to the specified pay run.
        /// </remarks>
        public void CreateEmployeeExpenses(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", request, Method.POST);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEmployeeExpense(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get Employee Expenses by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employee expenses for a specific employee in a pay run.
        /// </remarks>
        public PayRunEmployeeExpenseResponse GetEmployeeExpensesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses/{employeeId}");
        }

        /// <summary>
        /// List Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the employer liabilities for a pay run.
        /// </remarks>
        public PayRunEmployerLiabilityResponse ListEmployerLiabilities(int businessId, int payRunId)
        {
            return ApiRequest<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities");
        }

        /// <summary>
        /// Create Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Add employer liabilities to the specified pay run.
        /// </remarks>
        public void CreateEmployerLiabilities(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employerliabilities", request, Method.POST);
        }

        /// <summary>
        /// Delete Employer Liability
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEmployerLiability(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employerliabilities?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get Employer Liabilities by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employer liabilities for a specific employee in a pay run.
        /// </remarks>
        public PayRunEmployerLiabilityResponse GetEmployerLiabilitiesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities/{employeeId}");
        }

        /// <summary>
        /// Exclude employee from pay run
        /// </summary>
        public void ExcludeEmployeeFromPayRun(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/exclude/{employeeId}", Method.POST);
        }

        /// <summary>
        /// Get BACS File
        /// </summary>
        /// <remarks>
        /// Gets a BACS file associated with a pay run.
        /// </remarks>
        public void GetBacsFile(int businessId, int payRunId, int bacsDetailsId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/file/bacs/{bacsDetailsId}");
        }

        /// <summary>
        /// Get Pay Slip File
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for an employee in a pay run.
        /// </remarks>
        public byte[] GetPaySlipFile(int businessId, int employeeId, int payRunId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/payrun/{payRunId}/file/payslip/{employeeId}");
        }

        /// <summary>
        /// Finalise Pay Run
        /// </summary>
        /// <remarks>
        /// Finalises the specified pay run. A pay run can only be finalised if there are no calculations in progress.
        /// </remarks>
        public PayRunFinaliseResult FinalisePayRun(int businessId, int payRunId, FinalisePayRunOptions options)
        {
            return ApiRequest<PayRunFinaliseResult,FinalisePayRunOptions>($"/business/{businessId}/payrun/{payRunId}/finalise", options, Method.POST);
        }

        /// <summary>
        /// List HMRC Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the HMRC adjustments for a pay run.
        /// </remarks>
        public PayRunHmrcAdjustmentResponse ListHmrcAdjustments(int businessId, int payRunId)
        {
            return ApiRequest<PayRunHmrcAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/hmrcadjustments");
        }

        /// <summary>
        /// Create HMRC Adjustments
        /// </summary>
        /// <remarks>
        /// Adds HMRC adjustments to the specified pay run.
        /// </remarks>
        public void CreateHmrcAdjustments(int businessId, int payRunId, SubmitPayRunHmrcAdjustmentRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/hmrcadjustments", request, Method.POST);
        }

        /// <summary>
        /// Delete HMRC Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the HMRC adjustment with the specified ID from the pay run.
        /// </remarks>
        public void DeleteHmrcAdjustment(int businessId, int payRunId, DeleteHmrcAdjustmentQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/hmrcadjustments?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get HMRC Adjustments by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the HMRC adjustments for a specific employee in a pay run.
        /// </remarks>
        public PayRunHmrcAdjustmentResponse GetHmrcAdjustmentsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunHmrcAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/hmrcadjustments/{employeeId}");
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccruals(int businessId, int payRunId, GetLeaveAccrualsQueryModel request)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?includeLeaveTaken={request.IncludeLeaveTaken}");
        }

        /// <summary>
        /// Save Leave Accruals
        /// </summary>
        /// <remarks>
        /// Saves a set of leave accruals for the pay run.
        /// </remarks>
        public void SaveLeaveAccruals(int businessId, int payRunId, SubmitLeaveAccrualsModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", model, Method.POST);
        }

        /// <summary>
        /// Delete Leave Accrual
        /// </summary>
        /// <remarks>
        /// Deletes the manually added leave accrual, leave taken or leave adjustment with the specified ID from the pay run.
        /// </remarks>
        public void DeleteLeaveAccrual(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccrualsForEmployee(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}?includeLeaveTaken={request.IncludeLeaveTaken}");
        }

        /// <summary>
        /// Net to Gross
        /// </summary>
        /// <remarks>
        /// Calculates net to gross for a given pay run.
        /// </remarks>
        public NetToGrossModel NetToGross(int businessId, NetToGrossRequest netToGrossRequest, string payRunId)
        {
            return ApiRequest<NetToGrossModel,NetToGrossRequest>($"/business/{businessId}/payrun/{payRunId}/nettogross", netToGrossRequest, Method.POST);
        }

        /// <summary>
        /// Set Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Sets the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public void SetPayRunNotation(int businessId, int payRunId, PayRunNotationModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation", model, Method.POST);
        }

        /// <summary>
        /// Delete Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Deletes the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public void DeletePayRunNotation(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation", Method.DELETE);
        }

        /// <summary>
        /// Create Note for Employee
        /// </summary>
        /// <remarks>
        /// Creates a note for an employee record in a pay run.
        /// </remarks>
        public PayRunTotalNotationModel CreateNoteForEmployee(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model)
        {
            return ApiRequest<PayRunTotalNotationModel,PayRunTotalNotationModel>($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", model, Method.POST);
        }

        /// <summary>
        /// Delete Note for Employee
        /// </summary>
        /// <remarks>
        /// Deletes the note for an employee record in a pay run.
        /// </remarks>
        public void DeleteNoteForEmployee(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", Method.DELETE);
        }

        /// <summary>
        /// List PAYE Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the PAYE adjustments for a pay run.
        /// </remarks>
        public PayRunPayeAdjustmentResponse ListPayeAdjustments(int businessId, int payRunId)
        {
            return ApiRequest<PayRunPayeAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/payeadjustments");
        }

        /// <summary>
        /// Create PAYE Adjustments
        /// </summary>
        /// <remarks>
        /// Adds PAYE adjustments to the specified pay run.
        /// </remarks>
        public void CreatePayeAdjustments(int businessId, int payRunId, SubmitPayRunPayeAdjustmentRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/payeadjustments", request, Method.POST);
        }

        /// <summary>
        /// Delete PAYE Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the PAYE adjustment with the specified ID from the pay run.
        /// </remarks>
        public void DeletePayeAdjustment(int businessId, int payRunId, DeletePayeAdjustmentQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/payeadjustments?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Get PAYE Adjustments by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the PAYE adjustments for a specific employee in a pay run.
        /// </remarks>
        public PayRunPayeAdjustmentResponse GetPayeAdjustmentsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunPayeAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/payeadjustments/{employeeId}");
        }

        /// <summary>
        /// Get pay run payments
        /// </summary>
        /// <remarks>
        /// Gets the payments associated with a pay run.
        /// </remarks>
        public List<UkBankPaymentModel> GetPayRunPayments(int businessId, int payRunId)
        {
            return ApiRequest<List<UkBankPaymentModel>>($"/business/{businessId}/payrun/{payRunId}/payments");
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Dictionary<String,UkApiPaySlipModel> ListPaySlipData(int businessId, int payRunId, ListPaySlipDataQueryModel request)
        {
            return ApiRequest<Dictionary<String,UkApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips?showAllData={request.ShowAllData}");
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public UkApiPaySlipModel GetPaySlipDataByEmployeeId(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request)
        {
            return ApiRequest<UkApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}?showAllData={request.ShowAllData}");
        }

        /// <summary>
        /// Recalculate
        /// </summary>
        /// <remarks>
        /// Recalculates a pay run.
        /// </remarks>
        public void Recalculate(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/recalculate", Method.POST);
        }

        /// <summary>
        /// Set UI Unlock enabled
        /// </summary>
        /// <remarks>
        /// Sets whether a pay run can be unlocked by the UI or not. Only applies to finalized pay runs.
        /// </remarks>
        public void SetUiUnlockEnabled(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/setuiunlockstate", request, Method.POST);
        }

        /// <summary>
        /// Get statutory adoption pay calculation for pay run
        /// </summary>
        public UkSapApiCalculationResultViewModel GetStatutoryAdoptionPayCalculationForPayRun(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<UkSapApiCalculationResultViewModel>($"/business/{businessId}/payrun/{payRunId}/statutorypay/sap/employee/{employeeId}");
        }

        /// <summary>
        /// Apply statutory adoption payments to pay run
        /// </summary>
        public void ApplyStatutoryAdoptionPaymentsToPayRun(int businessId, int employeeId, int payRunId, UkApplySapPaymentsApiModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/statutorypay/sap/employee/{employeeId}", model, Method.POST);
        }

        /// <summary>
        /// Add Statutory Maternity Pay
        /// </summary>
        public UkSmpApiResponseModel AddStatutoryMaternityPay(int businessId, int employeeId, int payRunId, UkSmpApiRequestModel model)
        {
            return ApiRequest<UkSmpApiResponseModel,UkSmpApiRequestModel>($"/business/{businessId}/payrun/{payRunId}/statutorypay/smp/employee/{employeeId}", model, Method.POST);
        }

        /// <summary>
        /// Get Statutory Sick Pay By Id
        /// </summary>
        public UkSspApiModel GetStatutorySickPayById(int businessId, int payRunId, int sspId)
        {
            return ApiRequest<UkSspApiModel>($"/business/{businessId}/payrun/{payRunId}/statutorypay/ssp/{sspId}");
        }

        /// <summary>
        /// Get Statutory Sick Pay By Employee Id
        /// </summary>
        public List<UkSspApiModel> GetStatutorySickPayByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<List<UkSspApiModel>>($"/business/{businessId}/payrun/{payRunId}/statutorypay/ssp/employee/{employeeId}");
        }

        /// <summary>
        /// Add Statutory Sick Pay
        /// </summary>
        public UkSspApiResponseModel AddStatutorySickPay(int businessId, int employeeId, int payRunId, UkSspApiModel model)
        {
            return ApiRequest<UkSspApiResponseModel,UkSspApiModel>($"/business/{businessId}/payrun/{payRunId}/statutorypay/ssp/employee/{employeeId}", model, Method.POST);
        }

        /// <summary>
        /// Terminate Employee in Pay Run
        /// </summary>
        /// <remarks>
        /// Terminates an employee in the specified pay run.
        /// </remarks>
        public void TerminateEmployeeInPayRun(int businessId, int payRunId, TerminateEmployeeRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/terminate", request, Method.POST);
        }

        /// <summary>
        /// List Pay Run Totals
        /// </summary>
        /// <remarks>
        /// Lists all of the pay run totals in a pay run.
        /// </remarks>
        public UkPayRunTotalResponse ListPayRunTotals(int businessId, int payRunId)
        {
            return ApiRequest<UkPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals");
        }

        /// <summary>
        /// Get Pay Run Totals by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay run totals for a specific employee in a pay run.
        /// </remarks>
        public UkPayRunTotalResponse GetPayRunTotalsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<UkPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals/{employeeId}");
        }

        /// <summary>
        /// Unlock Pay Run
        /// </summary>
        /// <remarks>
        /// Unlocks the specified pay run.
        /// </remarks>
        public void UnlockPayRun(int businessId, int payRunId, PayRunUnlockRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/unlock", request, Method.POST);
        }

        /// <summary>
        /// Create Pay Run (Async)
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business asynchronously (the request will return before the pay run is created).
        /// </remarks>
        public PayRunJobModel CreatePayRunAsync(int businessId, PayRunCreateRequest request)
        {
            return ApiRequest<PayRunJobModel,PayRunCreateRequest>($"/business/{businessId}/payrun/async", request, Method.POST);
        }

        /// <summary>
        /// Get Creation Status
        /// </summary>
        /// <remarks>
        /// Gets the creation status of a pay run that was created asynchronously.
        /// </remarks>
        public PayRunJobStatusModel GetCreationStatus(int businessId, Guid jobId)
        {
            return ApiRequest<PayRunJobStatusModel>($"/business/{businessId}/payrun/creationstatus/{jobId}");
        }
    }
}
