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
using KeyPayV2.Uk.Models.EmployeeDocument;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeeDocumentFunction
    {
        List<EmployeeDocumentModel> ListEmployeeDocuments(int businessId, int employeeId);
        Task<List<EmployeeDocumentModel>> ListEmployeeDocumentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        EmployeeDocumentModel UpdateEmployeeDocumentPermissions(int businessId, int employeeId, UpdateEmployeeDocumentPermissionsModel model);
        Task<EmployeeDocumentModel> UpdateEmployeeDocumentPermissionsAsync(int businessId, int employeeId, UpdateEmployeeDocumentPermissionsModel model, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> CreateEmployeeDocument(int businessId, int employeeId, FileUploadModel file);
        Task<List<EmployeeDocumentModel>> CreateEmployeeDocumentAsync(int businessId, int employeeId, FileUploadModel file, CancellationToken cancellationToken = default);
        List<EmployeeDocumentModel> CreateEmployeeDocument(int businessId, int employeeId, FileUploadModel file, CreateEmployeeDocumentQueryModel request);
        Task<List<EmployeeDocumentModel>> CreateEmployeeDocumentAsync(int businessId, int employeeId, FileUploadModel file, CreateEmployeeDocumentQueryModel request, CancellationToken cancellationToken = default);
        void LinkEmployeeDocumentToExpenseRequest(int businessId, int employeeId, int id, int documentId);
        Task LinkEmployeeDocumentToExpenseRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnlinkEmployeeDocumentFromExpenseRequest(int businessId, int employeeId, int id, int documentId);
        Task UnlinkEmployeeDocumentFromExpenseRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void LinkEmployeeDocumentToLeaveRequest(int businessId, int employeeId, int id, int documentId);
        Task LinkEmployeeDocumentToLeaveRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnlinkEmployeeDocumentFromLeaveRequest(int businessId, int employeeId, int id, int documentId);
        Task UnlinkEmployeeDocumentFromLeaveRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void LinkEmployeeDocumentToTimesheet(int businessId, int employeeId, int id, int documentId);
        Task LinkEmployeeDocumentToTimesheetAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        void UnlinkEmployeeDocumentFromTimesheet(int businessId, int employeeId, int id, int documentId);
        Task UnlinkEmployeeDocumentFromTimesheetAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default);
        EmployeeDocumentModel GetEmployeeDocumentDetails(int businessId, int employeeId, int id);
        Task<EmployeeDocumentModel> GetEmployeeDocumentDetailsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void DeleteEmployeeDocument(int businessId, int employeeId, int id);
        Task DeleteEmployeeDocumentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        DocumentFile GetEmployeeDocumentContent(int businessId, int employeeId, int id);
        Task<DocumentFile> GetEmployeeDocumentContentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployeeDocumentFunction : BaseFunction, IEmployeeDocumentFunction
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
            return ApiRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", Method.Get);
        }

        /// <summary>
        /// List Employee Documents
        /// </summary>
        /// <remarks>
        /// Lists all the documents for this employee.
        /// </remarks>
        public Task<List<EmployeeDocumentModel>> ListEmployeeDocumentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the employee document with the specified ID.
        /// </remarks>
        public EmployeeDocumentModel UpdateEmployeeDocumentPermissions(int businessId, int employeeId, UpdateEmployeeDocumentPermissionsModel model)
        {
            return ApiRequest<EmployeeDocumentModel,UpdateEmployeeDocumentPermissionsModel>($"/business/{businessId}/employee/{employeeId}/document", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the employee document with the specified ID.
        /// </remarks>
        public Task<EmployeeDocumentModel> UpdateEmployeeDocumentPermissionsAsync(int businessId, int employeeId, UpdateEmployeeDocumentPermissionsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel,UpdateEmployeeDocumentPermissionsModel>($"/business/{businessId}/employee/{employeeId}/document", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeDocumentModel> CreateEmployeeDocument(int businessId, int employeeId, FileUploadModel file)
        {
            return ApiFileRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", file, Method.Post);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeDocumentModel>> CreateEmployeeDocumentAsync(int businessId, int employeeId, FileUploadModel file, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeDocumentModel> CreateEmployeeDocument(int businessId, int employeeId, FileUploadModel file, CreateEmployeeDocumentQueryModel request)
        {
            return ApiFileRequest<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document?visible={request.Visible}", file, Method.Post);
        }

        /// <summary>
        /// Create Employee Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for this employee. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeDocumentModel>> CreateEmployeeDocumentAsync(int businessId, int employeeId, FileUploadModel file, CreateEmployeeDocumentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<List<EmployeeDocumentModel>>($"/business/{businessId}/employee/{employeeId}/document?visible={request.Visible}", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Link Employee Document to Expense Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the expense request with the specified ID.
        /// </remarks>
        public void LinkEmployeeDocumentToExpenseRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.Post);
        }

        /// <summary>
        /// Link Employee Document to Expense Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the expense request with the specified ID.
        /// </remarks>
        public Task LinkEmployeeDocumentToExpenseRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Unlink Employee Document from Expense Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified expense request, unattach it.
        /// </remarks>
        public void UnlinkEmployeeDocumentFromExpenseRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.Delete);
        }

        /// <summary>
        /// Unlink Employee Document from Expense Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified expense request, unattach it.
        /// </remarks>
        public Task UnlinkEmployeeDocumentFromExpenseRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/expense/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Link Employee Document to Leave Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the leave request with the specified ID.
        /// </remarks>
        public void LinkEmployeeDocumentToLeaveRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.Post);
        }

        /// <summary>
        /// Link Employee Document to Leave Request
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the leave request with the specified ID.
        /// </remarks>
        public Task LinkEmployeeDocumentToLeaveRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Unlink Employee Document from Leave Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified leave request, unattach it.
        /// </remarks>
        public void UnlinkEmployeeDocumentFromLeaveRequest(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.Delete);
        }

        /// <summary>
        /// Unlink Employee Document from Leave Request
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified leave request, unattach it.
        /// </remarks>
        public Task UnlinkEmployeeDocumentFromLeaveRequestAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/leave/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Link Employee Document to Timesheet
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the timesheet with the specified ID.
        /// </remarks>
        public void LinkEmployeeDocumentToTimesheet(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.Post);
        }

        /// <summary>
        /// Link Employee Document to Timesheet
        /// </summary>
        /// <remarks>
        /// Takes the specified employee document and adds it as an attachment to the timesheet with the specified ID.
        /// </remarks>
        public Task LinkEmployeeDocumentToTimesheetAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Unlink Employee Document from Timesheet
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified timesheet, unattach it.
        /// </remarks>
        public void UnlinkEmployeeDocumentFromTimesheet(int businessId, int employeeId, int id, int documentId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.Delete);
        }

        /// <summary>
        /// Unlink Employee Document from Timesheet
        /// </summary>
        /// <remarks>
        /// If the specified employee document is attached to the specified timesheet, unattach it.
        /// </remarks>
        public Task UnlinkEmployeeDocumentFromTimesheetAsync(int businessId, int employeeId, int id, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{documentId}/timesheet/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Employee Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the employee document with the specified ID.
        /// </remarks>
        public EmployeeDocumentModel GetEmployeeDocumentDetails(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the employee document with the specified ID.
        /// </remarks>
        public Task<EmployeeDocumentModel> GetEmployeeDocumentDetailsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeDocumentModel>($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Document
        /// </summary>
        /// <remarks>
        /// Deletes the employee document with the specified ID.
        /// </remarks>
        public void DeleteEmployeeDocument(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Document
        /// </summary>
        /// <remarks>
        /// Deletes the employee document with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeDocumentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/document/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Employee Document Content
        /// </summary>
        /// <remarks>
        /// Get the file content for the employee document with the specified ID.
        /// </remarks>
        public DocumentFile GetEmployeeDocumentContent(int businessId, int employeeId, int id)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/employee/{employeeId}/document/{id}/content", Method.Get);
        }

        /// <summary>
        /// Get Employee Document Content
        /// </summary>
        /// <remarks>
        /// Get the file content for the employee document with the specified ID.
        /// </remarks>
        public Task<DocumentFile> GetEmployeeDocumentContentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/employee/{employeeId}/document/{id}/content", Method.Get, cancellationToken);
        }
    }
}
