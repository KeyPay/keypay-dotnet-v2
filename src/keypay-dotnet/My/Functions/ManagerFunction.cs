using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Manager;

namespace KeyPayV2.My.Functions
{
    public class ManagerFunction : BaseFunction
    {
        public ManagerFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the manager.
        /// </remarks>
        public void DownloadDocument(int businessId, int employeeId, int documentId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/document/download/{documentId}", Method.GET);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the manager.
        /// </remarks>
        public Task DownloadDocumentAsync(int businessId, int employeeId, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/document/download/{documentId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create expense request
        /// </summary>
        /// <remarks>
        /// Creates an expense request for the employee
        /// </remarks>
        public ManagerExpenseRequestModel CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest)
        {
            return ApiRequest<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense", expenseRequest, Method.POST);
        }

        /// <summary>
        /// Create expense request
        /// </summary>
        /// <remarks>
        /// Creates an expense request for the employee
        /// </remarks>
        public Task<ManagerExpenseRequestModel> CreateExpenseRequestAsync(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense", expenseRequest, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get expense request
        /// </summary>
        /// <remarks>
        /// Gets the expense request  with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel GetExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.GET);
        }

        /// <summary>
        /// Get expense request
        /// </summary>
        /// <remarks>
        /// Gets the expense request  with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> GetExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Edit Expense Request
        /// </summary>
        /// <remarks>
        /// Edits the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel EditExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest)
        {
            return ApiRequest<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", expenseRequest, Method.PUT);
        }

        /// <summary>
        /// Edit Expense Request
        /// </summary>
        /// <remarks>
        /// Edits the Expense Request with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> EditExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", expenseRequest, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the Expense Request with the specified ID.
        /// </remarks>
        public void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the Expense Request with the specified ID.
        /// </remarks>
        public Task DeleteExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the Expense Request with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> ApproveExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/approve", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public AttachmentModel UploadAttachmentToExpenseRequest(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request)
        {
            return ApiFileRequest<AttachmentModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", file, Method.PUT);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<AttachmentModel> UploadAttachmentToExpenseRequestAsync(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<AttachmentModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", file, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel DeclineExpenseRequest(int businessId, int employeeId, int expenseRequestId, DeclineReason reason)
        {
            return ApiRequest<ManagerExpenseRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/decline", reason, Method.POST);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the Expense Request with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> DeclineExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, DeclineReason reason, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/decline", reason, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get expenses reference data
        /// </summary>
        /// <remarks>
        /// Gets the Tax Codes, Expense Categories, and Locations for this Employee.
        /// </remarks>
        public ExpenseReferenceData GetExpensesReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<ExpenseReferenceData>($"/business/{businessId}/manager/{employeeId}/expense/reference", Method.GET);
        }

        /// <summary>
        /// Get expenses reference data
        /// </summary>
        /// <remarks>
        /// Gets the Tax Codes, Expense Categories, and Locations for this Employee.
        /// </remarks>
        public Task<ExpenseReferenceData> GetExpensesReferenceDataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ExpenseReferenceData>($"/business/{businessId}/manager/{employeeId}/expense/reference", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request.
        /// </remarks>
        public ManagerLeaveRequestModel CreateLeaveRequest(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication)
        {
            return ApiRequest<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> CreateLeaveRequestAsync(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest", leaveApplication, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.GET);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication)
        {
            return ApiRequest<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", leaveApplication, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request Attachment
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee leave request by ID.
        /// </remarks>
        public DocumentFile GetLeaveRequestAttachment(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/attachment", Method.GET);
        }

        /// <summary>
        /// Get Leave Request Attachment
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee leave request by ID.
        /// </remarks>
        public Task<DocumentFile> GetLeaveRequestAttachmentAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/attachment", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason)
        {
            return ApiRequest<ManagerLeaveRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", declineReason, Method.POST);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", declineReason, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/overlapping", Method.GET);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> OverlappingLeaveRequestsAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/overlapping", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this employee.
        /// </remarks>
        public List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId, int employeeId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/categories", Method.GET);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this employee.
        /// </remarks>
        public Task<List<ManagerLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/categories", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public ManagerLeaveEstimate EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<ManagerLeaveEstimate>($"/business/{businessId}/manager/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.GET);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public Task<ManagerLeaveEstimate> EstimateLeaveHoursAsync(int businessId, int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveEstimate>($"/business/{businessId}/manager/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Create an unavailability for an employee.
        /// </remarks>
        public ManagerUnavailabilityModel CreateUnavailability(int businessId, int employeeId, UnavailabilityEditModel model)
        {
            return ApiRequest<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability", model, Method.POST);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Create an unavailability for an employee.
        /// </remarks>
        public Task<ManagerUnavailabilityModel> CreateUnavailabilityAsync(int businessId, int employeeId, UnavailabilityEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public ManagerUnavailabilityModel UpdateUnavailability(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model)
        {
            return ApiRequest<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", model, Method.PUT);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public Task<ManagerUnavailabilityModel> UpdateUnavailabilityAsync(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int businessId, int employeeId, int unavailabilityId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public Task DeleteUnavailabilityAsync(int businessId, int employeeId, int unavailabilityId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get timesheet
        /// </summary>
        /// <remarks>
        /// Gets the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel GetTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.GET);
        }

        /// <summary>
        /// Get timesheet
        /// </summary>
        /// <remarks>
        /// Gets the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> GetTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel EditTimesheet(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet)
        {
            return ApiRequest<ManagerTimesheetLineModel,ManagerTimesheetSubmitModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", timesheet, Method.POST);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> EditTimesheetAsync(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel,ManagerTimesheetSubmitModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", timesheet, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public void DeleteTimesheet(int businessId, int employeeId, int timesheetId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public Task DeleteTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Approve Timesheet
        /// </summary>
        /// <remarks>
        /// Approves the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel ApproveTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/approve", Method.POST);
        }

        /// <summary>
        /// Approve Timesheet
        /// </summary>
        /// <remarks>
        /// Approves the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> ApproveTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/approve", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Reject Timesheet
        /// </summary>
        /// <remarks>
        /// Rejects the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel RejectTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/reject", Method.POST);
        }

        /// <summary>
        /// Reject Timesheet
        /// </summary>
        /// <remarks>
        /// Rejects the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> RejectTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/reject", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get timesheet reference data
        /// </summary>
        /// <remarks>
        /// Gets the Work Types, Shift Conditions, Locations and Classifications for this Employee.
        /// </remarks>
        public MyTimesheetReferenceData GetTimesheetReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<MyTimesheetReferenceData>($"/business/{businessId}/manager/{employeeId}/timesheet/reference", Method.GET);
        }

        /// <summary>
        /// Get timesheet reference data
        /// </summary>
        /// <remarks>
        /// Gets the Work Types, Shift Conditions, Locations and Classifications for this Employee.
        /// </remarks>
        public Task<MyTimesheetReferenceData> GetTimesheetReferenceDataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyTimesheetReferenceData>($"/business/{businessId}/manager/{employeeId}/timesheet/reference", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/manager/employee/{employeeId}/image", Method.GET);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public Task GetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/employee/{employeeId}/image", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/business/{businessId}/manager/employee/{employeeId}/image", Method.POST);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ProfileImageMetadata>($"/business/{businessId}/manager/employee/{employeeId}/image", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/manager/employee/{employeeId}/image", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public Task DeleteEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/employee/{employeeId}/image", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<LocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<LocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Initiate Employee Self Setup
        /// </summary>
        /// <remarks>
        /// Initiate the Self Setup process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public void InitiateEmployeeSelfSetup(int businessId, MyInitiateEmployeeOnboardingApiModel model)
        {
            ApiRequest($"/business/{businessId}/manager/employeeonboarding/initiateselfservice", model, Method.POST);
        }

        /// <summary>
        /// Initiate Employee Self Setup
        /// </summary>
        /// <remarks>
        /// Initiate the Self Setup process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public Task InitiateEmployeeSelfSetupAsync(int businessId, MyInitiateEmployeeOnboardingApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/employeeonboarding/initiateselfservice", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get List of Employees
        /// </summary>
        /// <remarks>
        /// Lists all employees the manager can access.
        /// </remarks>
        public List<EmployeeDetailsModel> GetListOfEmployees(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/manager/employees", Method.GET);
        }

        /// <summary>
        /// Get List of Employees
        /// </summary>
        /// <remarks>
        /// Lists all employees the manager can access.
        /// </remarks>
        public Task<List<EmployeeDetailsModel>> GetListOfEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsModel>>($"/business/{businessId}/manager/employees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerExpenseRequestModel> GetBusinessExpenseRequests(int businessId, GetBusinessExpenseRequestsQueryModel request)
        {
            return ApiRequest<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&locationId={request.LocationId}&expenseCategoryId={request.ExpenseCategoryId}&groupBy={request.GroupBy}&currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.GET);
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public Task<PagedResultModel<ManagerExpenseRequestModel>> GetBusinessExpenseRequestsAsync(int businessId, GetBusinessExpenseRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&locationId={request.LocationId}&expenseCategoryId={request.ExpenseCategoryId}&groupBy={request.GroupBy}&currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the expense categories
        /// </remarks>
        public List<ExpenseCategoryResponseModel> ListExpenseCategories(int businessId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/business/{businessId}/manager/expense/categories", Method.GET);
        }

        /// <summary>
        /// List Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the expense categories
        /// </remarks>
        public Task<List<ExpenseCategoryResponseModel>> ListExpenseCategoriesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseCategoryResponseModel>>($"/business/{businessId}/manager/expense/categories", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Expense Request Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve expense request permissions on.
        /// </remarks>
        public List<ManagerExpenseEmployeeModel> ListExpenseRequestEmployees(int businessId)
        {
            return ApiRequest<List<ManagerExpenseEmployeeModel>>($"/business/{businessId}/manager/expense/employees", Method.GET);
        }

        /// <summary>
        /// List Expense Request Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve expense request permissions on.
        /// </remarks>
        public Task<List<ManagerExpenseEmployeeModel>> ListExpenseRequestEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerExpenseEmployeeModel>>($"/business/{businessId}/manager/expense/employees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Expense Request Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve expense request permissions on.
        /// </remarks>
        public List<LocationModel> ListExpenseRequestLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/expense/locations", Method.GET);
        }

        /// <summary>
        /// List Expense Request Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve expense request permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListExpenseRequestLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/expense/locations", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Tax Codes
        /// </summary>
        /// <remarks>
        /// Lists all of the tax codes
        /// </remarks>
        public List<ExpenseTaxCode> ListTaxCodes(int businessId)
        {
            return ApiRequest<List<ExpenseTaxCode>>($"/business/{businessId}/manager/expense/taxcodes", Method.GET);
        }

        /// <summary>
        /// List Tax Codes
        /// </summary>
        /// <remarks>
        /// Lists all of the tax codes
        /// </remarks>
        public Task<List<ExpenseTaxCode>> ListTaxCodesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseTaxCode>>($"/business/{businessId}/manager/expense/taxcodes", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Kiosks
        /// </summary>
        /// <remarks>
        /// Returns all kiosks that the user has access to for this business
        /// </remarks>
        public List<TimeAndAttendanceKioskModel> GetKiosks(int businessId)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/manager/kiosk", Method.GET);
        }

        /// <summary>
        /// Get Kiosks
        /// </summary>
        /// <remarks>
        /// Returns all kiosks that the user has access to for this business
        /// </remarks>
        public Task<List<TimeAndAttendanceKioskModel>> GetKiosksAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/manager/kiosk", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel GetKioskById(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/manager/kiosk/{id}", Method.GET);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> GetKioskByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel>($"/business/{businessId}/manager/kiosk/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public KioskEmployeeModel ChangePin(int businessId, int kioskId, ChangeKioskPinModel model)
        {
            return ApiRequest<KioskEmployeeModel,ChangeKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/changepin", model, Method.POST);
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public Task<KioskEmployeeModel> ChangePinAsync(int businessId, int kioskId, ChangeKioskPinModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ChangeKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/changepin", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public BasicKioskEmployeeModel CheckEmployee(int businessId, int kioskId, CheckKioskEmployeeIdModel model)
        {
            return ApiRequest<BasicKioskEmployeeModel,CheckKioskEmployeeIdModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkid", model, Method.POST);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public Task<BasicKioskEmployeeModel> CheckEmployeeAsync(int businessId, int kioskId, CheckKioskEmployeeIdModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BasicKioskEmployeeModel,CheckKioskEmployeeIdModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkid", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public KioskEmployeeModel VerifyKioskPin(int businessId, int kioskId, CheckKioskPinModel model)
        {
            return ApiRequest<KioskEmployeeModel,CheckKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkpin", model, Method.POST);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public Task<KioskEmployeeModel> VerifyKioskPinAsync(int businessId, int kioskId, CheckKioskPinModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,CheckKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkpin", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out an employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public KioskEmployeeModel ClockOutEmployee(int businessId, int kioskId, ClockOffModel request)
        {
            return ApiRequest<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockoff", request, Method.POST);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out an employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task<KioskEmployeeModel> ClockOutEmployeeAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockoff", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public KioskEmployeeModel ClockInEmployee(int businessId, int kioskId, ClockOnModel request)
        {
            return ApiRequest<KioskEmployeeModel,ClockOnModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockon", request, Method.POST);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public Task<KioskEmployeeModel> ClockInEmployeeAsync(int businessId, int kioskId, ClockOnModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ClockOnModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockon", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public KioskEmployeeModel DiscardCurrentShift(int businessId, int kioskId, ClockOffModel request)
        {
            return ApiRequest<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/discard", request, Method.POST);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task<KioskEmployeeModel> DiscardCurrentShiftAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/discard", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public void SendPinResetEmail(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/emailreset", model, Method.POST);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public Task SendPinResetEmailAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/emailreset", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public KioskEmployeeModel EndBreak(int businessId, int kioskId, EndBreakModel request)
        {
            return ApiRequest<KioskEmployeeModel,EndBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/endbreak", request, Method.POST);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public Task<KioskEmployeeModel> EndBreakAsync(int businessId, int kioskId, EndBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,EndBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/endbreak", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public MyTimeAndAttendanceLookupDataModel GetEmployeeLookupData(int businessId, int employeeId, int kioskId)
        {
            return ApiRequest<MyTimeAndAttendanceLookupDataModel>($"/business/{businessId}/manager/kiosk/{kioskId}/lookupdata/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public Task<MyTimeAndAttendanceLookupDataModel> GetEmployeeLookupDataAsync(int businessId, int employeeId, int kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyTimeAndAttendanceLookupDataModel>($"/business/{businessId}/manager/kiosk/{kioskId}/lookupdata/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public List<ShiftNoteViewModel> GetShiftNotes(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request)
        {
            return ApiRequest<List<ShiftNoteViewModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.GET);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public Task<List<ShiftNoteViewModel>> GetShiftNotesAsync(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftNoteViewModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public ShiftNoteViewModel AddNoteToShift(int businessId, int kioskId, int shiftId, AddNoteModel model)
        {
            return ApiRequest<ShiftNoteViewModel,AddNoteModel>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public Task<ShiftNoteViewModel> AddNoteToShiftAsync(int businessId, int kioskId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ShiftNoteViewModel,AddNoteModel>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public void DeleteNoteFromShift(int businessId, int kioskId, int shiftId, int noteId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public Task DeleteNoteFromShiftAsync(int businessId, int kioskId, int shiftId, int noteId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.POST);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public Task MarkShiftNotesReadAsync(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public void SendPinResetSms(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/smsreset", model, Method.POST);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public Task SendPinResetSmsAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/smsreset", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk.
        /// </remarks>
        public List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff", Method.GET);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk.
        /// </remarks>
        public Task<List<BasicKioskEmployeeModel>> ListKioskStaffAsync(int businessId, int kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled. If the employee already exists, the kiosk will be enabled for that employee.
        /// </remarks>
        public void AddAnEmployee(int businessId, int kioskId, KioskCreateEmployeeModel model)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/staff", model, Method.POST);
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled. If the employee already exists, the kiosk will be enabled for that employee.
        /// </remarks>
        public Task AddAnEmployeeAsync(int businessId, int kioskId, KioskCreateEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/staff", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public KioskEmployeeModel StartBreak(int businessId, int kioskId, StartBreakModel request)
        {
            return ApiRequest<KioskEmployeeModel,StartBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/startbreak", request, Method.POST);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public Task<KioskEmployeeModel> StartBreakAsync(int businessId, int kioskId, StartBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,StartBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/startbreak", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<MyTimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model)
        {
            return ApiRequest<List<MyTimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/manager/kiosk/shifts", model, Method.POST);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task<List<MyTimeAndAttendanceShiftModel>> ShiftsAsync(int businessId, GetShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyTimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/manager/kiosk/shifts", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets that the manager has access to for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<TimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<TimesheetLineModel>>($"/business/{businessId}/manager/kiosk/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets that the manager has access to for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<TimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TimesheetLineModel>>($"/business/{businessId}/manager/kiosk/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public void CreateKioskTimesheetLine(int businessId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Create kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public Task CreateKioskTimesheetLineAsync(int businessId, IndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/timesheet", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Update kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public void UpdateKioskTimesheetLine(int businessId, int timesheetLineId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheet/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// Update kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public Task UpdateKioskTimesheetLineAsync(int businessId, int timesheetLineId, IndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/timesheet/{timesheetLineId}", request, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Update comments in a timesheet
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line with comments
        /// </remarks>
        public void UpdateCommentsInATimesheet(int businessId, TimesheetLineCommentsModel request, string timesheetLineId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheetcomments/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// Update comments in a timesheet
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line with comments
        /// </remarks>
        public Task UpdateCommentsInATimesheetAsync(int businessId, TimesheetLineCommentsModel request, string timesheetLineId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/timesheetcomments/{timesheetLineId}", request, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public List<ManagerLeaveRequestModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.GET);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this business.
        /// </remarks>
        public List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/leaverequest/categories", Method.GET);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this business.
        /// </remarks>
        public Task<List<ManagerLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/leaverequest/categories", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Leave Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has leave permissions on.
        /// </remarks>
        public List<ManagerLeaveEmployeeModel> ListLeaveEmployees(int businessId)
        {
            return ApiRequest<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/leaverequest/employees", Method.GET);
        }

        /// <summary>
        /// List Leave Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has leave permissions on.
        /// </remarks>
        public Task<List<ManagerLeaveEmployeeModel>> ListLeaveEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/leaverequest/employees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Leave Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has leave permissions on.
        /// </remarks>
        public List<LocationModel> ListLeaveLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/leaverequest/locations", Method.GET);
        }

        /// <summary>
        /// List Leave Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has leave permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListLeaveLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/leaverequest/locations", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, OverlappingLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest/overlapping?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> OverlappingLeaveRequestsAsync(int businessId, OverlappingLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest/overlapping?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<LocationModel> ListEmployeeLocations(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<LocationModel>> ListEmployeeLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get List of Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations the manager can access.
        /// </remarks>
        public List<LocationModel> GetListOfLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/locations", Method.GET);
        }

        /// <summary>
        /// Get List of Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations the manager can access.
        /// </remarks>
        public Task<List<LocationModel>> GetListOfLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/locations", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<MyRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request)
        {
            return ApiRequest<List<MyRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("shiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&pageNum={request.PageNum}&includeWarnings={request.IncludeWarnings}", Method.GET);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<MyRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("shiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&pageNum={request.PageNum}&includeWarnings={request.IncludeWarnings}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public MyRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<MyRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public Task<MyRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public MyRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<MyRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public Task<MyRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<MyEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<MyEssRosterShiftModel>>($"/business/{businessId}/manager/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<MyEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssRosterShiftModel>>($"/business/{businessId}/manager/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public ManagerRosterShiftModel GetRosterShiftById(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request)
        {
            return ApiRequest<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}?includeCosts={request.IncludeCosts}", Method.GET);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public Task<ManagerRosterShiftModel> GetRosterShiftByIdAsync(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}?includeCosts={request.IncludeCosts}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model)
        {
            ApiRequest($"/business/{businessId}/manager/rostershift/{rosterShiftId}/stub", model, Method.POST);
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/rostershift/{rosterShiftId}/stub", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has roster permissions on.
        /// </remarks>
        public List<ManagerRosterEmployeeModel> ListRosterEmployees(int businessId)
        {
            return ApiRequest<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/employees", Method.GET);
        }

        /// <summary>
        /// List Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has roster permissions on.
        /// </remarks>
        public Task<List<ManagerRosterEmployeeModel>> ListRosterEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/employees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Roster Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has roster permissions on.
        /// </remarks>
        public List<LocationModel> ListRosterLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/rostershift/locations", Method.GET);
        }

        /// <summary>
        /// List Roster Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has roster permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListRosterLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/rostershift/locations", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public MyManagerRosterDataModel ManageRosterData(int businessId, ManageRosterDataQueryModel request)
        {
            return ApiRequest<MyManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}&employeeId={request.EmployeeId}&locationId={request.LocationId}&roleId={request.RoleId}&includeCosts={request.IncludeCosts}&includeSubLocations={request.IncludeSubLocations}", Method.GET);
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public Task<MyManagerRosterDataModel> ManageRosterDataAsync(int businessId, ManageRosterDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}&employeeId={request.EmployeeId}&locationId={request.LocationId}&roleId={request.RoleId}&includeCosts={request.IncludeCosts}&includeSubLocations={request.IncludeSubLocations}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Manager Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has manage roster permissions on.
        /// </remarks>
        public List<ManagerRosterEmployeeModel> ListManagerRosterEmployees(int businessId)
        {
            return ApiRequest<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/manageemployees", Method.GET);
        }

        /// <summary>
        /// List Manager Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has manage roster permissions on.
        /// </remarks>
        public Task<List<ManagerRosterEmployeeModel>> ListManagerRosterEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/manageemployees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get the list of roles available
        /// </summary>
        public List<RosterShiftRole> GetTheListOfRolesAvailable(int businessId)
        {
            return ApiRequest<List<RosterShiftRole>>($"/business/{businessId}/manager/rostershift/roles", Method.GET);
        }

        /// <summary>
        /// Get the list of roles available
        /// </summary>
        public Task<List<RosterShiftRole>> GetTheListOfRolesAvailableAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<RosterShiftRole>>($"/business/{businessId}/manager/rostershift/roles", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public TimesheetRoundingRulesModel GetRoundingRules(int businessId)
        {
            return ApiRequest<TimesheetRoundingRulesModel>($"/business/{businessId}/manager/roundingrules", Method.GET);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimesheetRoundingRulesModel>($"/business/{businessId}/manager/roundingrules", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules)
        {
            ApiRequest($"/business/{businessId}/manager/roundingrules", roundingRules, Method.POST);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/roundingrules", roundingRules, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerTimesheetLineModel> GetBusinessTimesheets(int businessId, GetBusinessTimesheetsQueryModel request)
        {
            return ApiRequest<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&status={request.Status}&employeeId={request.EmployeeId}&employeeGroupId={request.EmployeeGroupId}&locationId={request.LocationId}&includeCosts={request.IncludeCosts}&currentPage={request.CurrentPage}&pageSize={request.PageSize}&orderBy={request.OrderBy}", Method.GET);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public Task<PagedResultModel<ManagerTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, GetBusinessTimesheetsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&status={request.Status}&employeeId={request.EmployeeId}&employeeGroupId={request.EmployeeGroupId}&locationId={request.LocationId}&includeCosts={request.IncludeCosts}&currentPage={request.CurrentPage}&pageSize={request.PageSize}&orderBy={request.OrderBy}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public MyIndividualTimesheetLineModel CreateTimesheetLine(int businessId, MyIndividualTimesheetLineModel request)
        {
            return ApiRequest<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/manager/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public Task<MyIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/manager/timesheet", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public MyIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request)
        {
            return ApiRequest<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/manager/timesheet/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public Task<MyIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/manager/timesheet/{timesheetLineId}", request, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<ManagerEmployeeGroup> ListEmployeeGroups(int businessId)
        {
            return ApiRequest<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/timesheet/employeegroups", Method.GET);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public Task<List<ManagerEmployeeGroup>> ListEmployeeGroupsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/timesheet/employeegroups", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Timesheet Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<ManagerTimesheetEmployeeModel> ListTimesheetEmployees(int businessId)
        {
            return ApiRequest<List<ManagerTimesheetEmployeeModel>>($"/business/{businessId}/manager/timesheet/employees", Method.GET);
        }

        /// <summary>
        /// List Timesheet Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public Task<List<ManagerTimesheetEmployeeModel>> ListTimesheetEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerTimesheetEmployeeModel>>($"/business/{businessId}/manager/timesheet/employees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Timesheet Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<LocationModel> ListTimesheetLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/timesheet/locations", Method.GET);
        }

        /// <summary>
        /// List Timesheet Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve timesheet permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListTimesheetLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/timesheet/locations", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Returns all the businesses the user can access.
        /// </remarks>
        public List<MyAvailableBusinessModel> ListBusinesses()
        {
            return ApiRequest<List<MyAvailableBusinessModel>>($"/manager/security/businesses", Method.GET);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Returns all the businesses the user can access.
        /// </remarks>
        public Task<List<MyAvailableBusinessModel>> ListBusinessesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyAvailableBusinessModel>>($"/manager/security/businesses", Method.GET, cancellationToken);
        }
    }
}