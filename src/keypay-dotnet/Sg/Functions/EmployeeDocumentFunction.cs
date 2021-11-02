using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeDocument;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeDocumentFunction : BaseFunction
    {
        public EmployeeDocumentFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Documents
        /// </summary>
        /// <remarks>
        /// Lists all the documents for this employee.
        /// </remarks>
        public List<EmployeeDocumentModel> ListEmployeeDocuments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", Method.GET);
        }

        /// <summary>
        /// List Employee Documents
        /// </summary>
        /// <remarks>
        /// Lists all the documents for this employee.
        /// </remarks>
        public Task<List<EmployeeDocumentModel>> ListEmployeeDocumentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employee Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the employee document with the specified ID.
        /// </remarks>
        public EmployeeDocumentModel UpdateEmployeeDocumentPermissions(int businessId, int employeeId, UpdateEmployeeDocumentPermissionsModel model)
        {
            return ApiRequest<EmployeeDocumentModel,UpdateEmployeeDocumentPermissionsModel>($"/business/{businessId}/employee/{employeeId}/document", model, Method.PUT);
        }

        /// <summary>
        /// Update Employee Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the employee document with the specified ID.
        /// </remarks>
        public Task<EmployeeDocumentModel> UpdateEmployeeDocumentPermissionsAsync(int businessId, int employeeId, UpdateEmployeeDocumentPermissionsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel,UpdateEmployeeDocumentPermissionsModel>($"/business/{businessId}/employee/{employeeId}/document", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeDocumentModel> CreateEmployeeDocument(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", Method.POST);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeDocumentModel>> CreateEmployeeDocumentAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeDocumentModel> CreateEmployeeDocument(int businessId, int employeeId, CreateEmployeeDocumentQueryModel request)
        {
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document?visible={request.Visible}", Method.POST);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeDocumentModel>> CreateEmployeeDocumentAsync(int businessId, int employeeId, CreateEmployeeDocumentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document?visible={request.Visible}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Link Employee Document to Expense Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the expense request with the specified ID.
        /// </remarks>
        public void LinkEmployeeDocumentToExpenseRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.POST);
        }

        /// <summary>
        /// Link Employee Document to Expense Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the expense request with the specified ID.
        /// </remarks>
        public Task LinkEmployeeDocumentToExpenseRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Unlink Employee Document from Expense Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified expense request, unattach it.
        /// </remarks>
        public void UnlinkEmployeeDocumentFromExpenseRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.DELETE);
        }

        /// <summary>
        /// Unlink Employee Document from Expense Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified expense request, unattach it.
        /// </remarks>
        public Task UnlinkEmployeeDocumentFromExpenseRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Link Employee Document to Leave Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the leave request with the specified ID.
        /// </remarks>
        public void LinkEmployeeDocumentToLeaveRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.POST);
        }

        /// <summary>
        /// Link Employee Document to Leave Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the leave request with the specified ID.
        /// </remarks>
        public Task LinkEmployeeDocumentToLeaveRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Unlink Employee Document from Leave Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified leave request, unattach it.
        /// </remarks>
        public void UnlinkEmployeeDocumentFromLeaveRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.DELETE);
        }

        /// <summary>
        /// Unlink Employee Document from Leave Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified leave request, unattach it.
        /// </remarks>
        public Task UnlinkEmployeeDocumentFromLeaveRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Link Employee Document to Timesheet
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the timesheet with the specified ID.
        /// </remarks>
        public void LinkEmployeeDocumentToTimesheet(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.POST);
        }

        /// <summary>
        /// Link Employee Document to Timesheet
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the timesheet with the specified ID.
        /// </remarks>
        public Task LinkEmployeeDocumentToTimesheetAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Unlink Employee Document from Timesheet
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified timesheet, unattach it.
        /// </remarks>
        public void UnlinkEmployeeDocumentFromTimesheet(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.DELETE);
        }

        /// <summary>
        /// Unlink Employee Document from Timesheet
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified timesheet, unattach it.
        /// </remarks>
        public Task UnlinkEmployeeDocumentFromTimesheetAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Employee Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the employee document with the specified ID.
        /// </remarks>
        public EmployeeDocumentModel GetEmployeeDocumentDetails(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employee Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the employee document with the specified ID.
        /// </remarks>
        public Task<EmployeeDocumentModel> GetEmployeeDocumentDetailsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Document
        /// </summary>
        /// <remarks>
        /// Deletes the employee document with the specified ID.
        /// </remarks>
        public void DeleteEmployeeDocument(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Document
        /// </summary>
        /// <remarks>
        /// Deletes the employee document with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeDocumentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Employee Document Content
        /// </summary>
        /// <remarks>
        /// Get the file content for the employee document with the specified ID.
        /// </remarks>
        public DocumentFile GetEmployeeDocumentContent(int businessId, int employeeId, int id)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/employee/{employeeId}/document/{id}/content", Method.GET);
        }

        /// <summary>
        /// Get Employee Document Content
        /// </summary>
        /// <remarks>
        /// Get the file content for the employee document with the specified ID.
        /// </remarks>
        public Task<DocumentFile> GetEmployeeDocumentContentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/employee/{employeeId}/document/{id}/content", Method.GET, cancellationToken);
        }
    }
}
