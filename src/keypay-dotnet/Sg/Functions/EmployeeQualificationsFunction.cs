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
using KeyPayV2.Sg.Models.EmployeeQualifications;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeQualificationsFunction : BaseFunction
    {
        public EmployeeQualificationsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Qualifications for Employee
        /// </summary>
        /// <remarks>
        /// Retrieves the qualification details for a single employee.
        /// </remarks>
        public List<EmployeeQualificationModel> GetQualificationsForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeQualificationModel>>($"/business/{businessId}/employee/{employeeId}/qualification", Method.GET);
        }

        /// <summary>
        /// Get Qualifications for Employee
        /// </summary>
        /// <remarks>
        /// Retrieves the qualification details for a single employee.
        /// </remarks>
        public Task<List<EmployeeQualificationModel>> GetQualificationsForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeQualificationModel>>($"/business/{businessId}/employee/{employeeId}/qualification", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add/Update Employee Qualification
        /// </summary>
        /// <remarks>
        /// Adds or updates a qualification for an employee.
        /// </remarks>
        public void AddUpdateEmployeeQualification(int businessId, int employeeId, EmployeeQualificationModel qualification)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/qualification", qualification, Method.POST);
        }

        /// <summary>
        /// Add/Update Employee Qualification
        /// </summary>
        /// <remarks>
        /// Adds or updates a qualification for an employee.
        /// </remarks>
        public Task AddUpdateEmployeeQualificationAsync(int businessId, int employeeId, EmployeeQualificationModel qualification, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/qualification", qualification, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Qualification
        /// </summary>
        /// <remarks>
        /// Deletes an employee qualification. Denotes that the employee is no longer qualified for the specified qualification.
        /// </remarks>
        public void DeleteEmployeeQualification(int businessId, int employeeId, DeleteEmployeeQualificationQueryModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/qualification?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Qualification
        /// </summary>
        /// <remarks>
        /// Deletes an employee qualification. Denotes that the employee is no longer qualified for the specified qualification.
        /// </remarks>
        public Task DeleteEmployeeQualificationAsync(int businessId, int employeeId, DeleteEmployeeQualificationQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/qualification?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific ID.
        /// </remarks>
        public EmployeeQualificationModel GetQualificationDetails(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeQualificationModel>($"/business/{businessId}/employee/{employeeId}/qualification/{id}", Method.GET);
        }

        /// <summary>
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific ID.
        /// </remarks>
        public Task<EmployeeQualificationModel> GetQualificationDetailsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeQualificationModel>($"/business/{businessId}/employee/{employeeId}/qualification/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Documents for Employee Qualification
        /// </summary>
        /// <remarks>
        /// Lists all the documents associated with a specific employee qualification.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> ListDocumentsForEmployeeQualification(int businessId, int employeeId, int qualificationId)
        {
            return ApiRequest<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", Method.GET);
        }

        /// <summary>
        /// List Documents for Employee Qualification
        /// </summary>
        /// <remarks>
        /// Lists all the documents associated with a specific employee qualification.
        /// </remarks>
        public Task<List<EmployeeQualificationDocumentModel>> ListDocumentsForEmployeeQualificationAsync(int businessId, int employeeId, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId)
        {
            return ApiRequest<List<EmployeeQualificationDocumentModel>,FileUploadModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", file, Method.POST);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeQualificationDocumentModel>> CreateEmployeeQualificationDocumentAsync(int businessId, int employeeId, FileUploadModel file, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeQualificationDocumentModel>,FileUploadModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", file, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request)
        {
            return ApiFileRequest<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document?visible={request.Visible}", file, Method.POST);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeQualificationDocumentModel>> CreateEmployeeQualificationDocumentAsync(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document?visible={request.Visible}", file, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Document by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a qualification document by ID.
        /// </remarks>
        public EmployeeQualificationDocumentModel GetQualificationDocumentById(int businessId, int employeeId, int id, int qualificationId)
        {
            return ApiRequest<EmployeeQualificationDocumentModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.GET);
        }

        /// <summary>
        /// Get Qualification Document by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a qualification document by ID.
        /// </remarks>
        public Task<EmployeeQualificationDocumentModel> GetQualificationDocumentByIdAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeQualificationDocumentModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Deletes a specific employee qualification document.
        /// </remarks>
        public void DeleteEmployeeQualificationDocument(int businessId, int employeeId, int id, int qualificationId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Deletes a specific employee qualification document.
        /// </remarks>
        public Task DeleteEmployeeQualificationDocumentAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Document File
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee qualification document by ID.
        /// </remarks>
        public DocumentFile GetQualificationDocumentFile(int businessId, int employeeId, int id, int qualificationId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}/content", Method.GET);
        }

        /// <summary>
        /// Get Qualification Document File
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee qualification document by ID.
        /// </remarks>
        public Task<DocumentFile> GetQualificationDocumentFileAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}/content", Method.GET, cancellationToken);
        }
    }
}
