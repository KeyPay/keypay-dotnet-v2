using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.EmployeeExpenseRequest;

namespace KeyPayV2.Au.Functions
{
    public class EmployeeExpenseRequestFunction : BaseFunction
    {
        public EmployeeExpenseRequestFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Expense Requests
        /// </summary>
        /// <remarks>
        /// Lists all of the expense requests for this employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<ExpenseRequestResponseModel> ListExpenseRequests(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<ExpenseRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/expenserequest{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for this employee.
        /// </remarks>
        public void CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest", model, Method.POST);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public ExpenseRequestResponseModel GetExpenseRequestById(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ExpenseRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}");
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public void UpdateExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the expense request with the specified ID.
        /// </remarks>
        public void ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/attachment", Method.PUT);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the expense request with the specified ID. The request body should just be a string, enclosed in double quotes, for the Decline Reason. Do not encase in {}
        /// eg. "Not a valid expense request"
        /// </remarks>
        public void DeclineExpenseRequest(int businessId, int employeeId, int expenseRequestId, string reason)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/decline", reason, Method.POST);
        }
    }
}
