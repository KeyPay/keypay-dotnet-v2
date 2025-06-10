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
using KeyPayV2.Au.Models.EmployeeExpenseRequest;

namespace KeyPayV2.Au.Functions
{
    public interface IEmployeeExpenseRequestFunction
    {
        List<ExpenseRequestResponseModel> ListExpenseRequests(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<ExpenseRequestResponseModel>> ListExpenseRequestsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel model);
        Task CreateExpenseRequestAsync(int businessId, int employeeId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default);
        ExpenseRequestResponseModel GetExpenseRequestById(int businessId, int employeeId, int expenseRequestId);
        Task<ExpenseRequestResponseModel> GetExpenseRequestByIdAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        void UpdateExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel model);
        Task UpdateExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default);
        void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId);
        Task DeleteExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        void ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId);
        Task ApproveExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        void UploadAttachmentToExpenseRequest(int businessId, int employeeId, int expenseRequestId);
        Task UploadAttachmentToExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        void DeclineExpenseRequest(int businessId, int employeeId, int expenseRequestId, string reason);
        Task DeclineExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, string reason, CancellationToken cancellationToken = default);
    }
    public class EmployeeExpenseRequestFunction : BaseFunction, IEmployeeExpenseRequestFunction
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
            return ApiRequest<List<ExpenseRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/expenserequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Expense Requests
        /// </summary>
        /// <remarks>
        /// Lists all of the expense requests for this employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<ExpenseRequestResponseModel>> ListExpenseRequestsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/expenserequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for this employee.
        /// </remarks>
        public void CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest", model, Method.Post);
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for this employee.
        /// </remarks>
        public Task CreateExpenseRequestAsync(int businessId, int employeeId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expenserequest", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public ExpenseRequestResponseModel GetExpenseRequestById(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ExpenseRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", Method.Get);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public Task<ExpenseRequestResponseModel> GetExpenseRequestByIdAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ExpenseRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public void UpdateExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", model, Method.Put);
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public Task UpdateExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public Task DeleteExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the expense request with the specified ID.
        /// </remarks>
        public void ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/approve", Method.Post);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the expense request with the specified ID.
        /// </remarks>
        public Task ApproveExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/approve", Method.Post, cancellationToken);
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
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/attachment", Method.Put);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task UploadAttachmentToExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/attachment", Method.Put, cancellationToken);
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
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/decline", reason, Method.Post);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the expense request with the specified ID. The request body should just be a string, enclosed in double quotes, for the Decline Reason. Do not encase in {}
        /// eg. "Not a valid expense request"
        /// </remarks>
        public Task DeclineExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, string reason, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expenserequest/{expenseRequestId}/decline", reason, Method.Post, cancellationToken);
        }
    }
}
