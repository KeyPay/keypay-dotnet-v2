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
using KeyPayV2.Au.Models.EmployeeQualifications;

namespace KeyPayV2.Au.Functions
{
    public interface IEmployeeQualificationsFunction
    {
        List<EmployeeQualificationModel> GetQualificationsForEmployee(int businessId, int employeeId);
        Task<List<EmployeeQualificationModel>> GetQualificationsForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void AddUpdateEmployeeQualification(int businessId, int employeeId, EmployeeQualificationModel qualification);
        Task AddUpdateEmployeeQualificationAsync(int businessId, int employeeId, EmployeeQualificationModel qualification, CancellationToken cancellationToken = default);
        void DeleteEmployeeQualification(int businessId, int employeeId, DeleteEmployeeQualificationQueryModel request);
        Task DeleteEmployeeQualificationAsync(int businessId, int employeeId, DeleteEmployeeQualificationQueryModel request, CancellationToken cancellationToken = default);
        EmployeeQualificationModel GetQualificationDetails(int businessId, int employeeId, int id);
        Task<EmployeeQualificationModel> GetQualificationDetailsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<EmployeeQualificationDocumentModel> ListDocumentsForEmployeeQualification(int businessId, int employeeId, int qualificationId);
        Task<List<EmployeeQualificationDocumentModel>> ListDocumentsForEmployeeQualificationAsync(int businessId, int employeeId, int qualificationId, CancellationToken cancellationToken = default);
        List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId);
        Task<List<EmployeeQualificationDocumentModel>> CreateEmployeeQualificationDocumentAsync(int businessId, int employeeId, FileUploadModel file, int qualificationId, CancellationToken cancellationToken = default);
        List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request);
        Task<List<EmployeeQualificationDocumentModel>> CreateEmployeeQualificationDocumentAsync(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request, CancellationToken cancellationToken = default);
        EmployeeQualificationDocumentModel GetQualificationDocumentById(int businessId, int employeeId, int id, int qualificationId);
        Task<EmployeeQualificationDocumentModel> GetQualificationDocumentByIdAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default);
        void DeleteEmployeeQualificationDocument(int businessId, int employeeId, int id, int qualificationId);
        Task DeleteEmployeeQualificationDocumentAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default);
        DocumentFile GetQualificationDocumentFile(int businessId, int employeeId, int id, int qualificationId);
        Task<DocumentFile> GetQualificationDocumentFileAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default);
    }
    public class EmployeeQualificationsFunction : BaseFunction, IEmployeeQualificationsFunction
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
            return ApiRequest<List<EmployeeQualificationModel>>($"/business/{businessId}/employee/{employeeId}/qualification", Method.Get);
        }

        /// <summary>
        /// Get Qualifications for Employee
        /// </summary>
        /// <remarks>
        /// Retrieves the qualification details for a single employee.
        /// </remarks>
        public Task<List<EmployeeQualificationModel>> GetQualificationsForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeQualificationModel>>($"/business/{businessId}/employee/{employeeId}/qualification", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Add/Update Employee Qualification
        /// </summary>
        /// <remarks>
        /// Adds or updates a qualification for an employee.
        /// </remarks>
        public void AddUpdateEmployeeQualification(int businessId, int employeeId, EmployeeQualificationModel qualification)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/qualification", qualification, Method.Post);
        }

        /// <summary>
        /// Add/Update Employee Qualification
        /// </summary>
        /// <remarks>
        /// Adds or updates a qualification for an employee.
        /// </remarks>
        public Task AddUpdateEmployeeQualificationAsync(int businessId, int employeeId, EmployeeQualificationModel qualification, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/qualification", qualification, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Qualification
        /// </summary>
        /// <remarks>
        /// Deletes an employee qualification. Denotes that the employee is no longer qualified for the specified qualification.
        /// </remarks>
        public void DeleteEmployeeQualification(int businessId, int employeeId, DeleteEmployeeQualificationQueryModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/qualification?id={request.Id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Qualification
        /// </summary>
        /// <remarks>
        /// Deletes an employee qualification. Denotes that the employee is no longer qualified for the specified qualification.
        /// </remarks>
        public Task DeleteEmployeeQualificationAsync(int businessId, int employeeId, DeleteEmployeeQualificationQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/qualification?id={request.Id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific ID.
        /// </remarks>
        public EmployeeQualificationModel GetQualificationDetails(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeQualificationModel>($"/business/{businessId}/employee/{employeeId}/qualification/{id}", Method.Get);
        }

        /// <summary>
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific ID.
        /// </remarks>
        public Task<EmployeeQualificationModel> GetQualificationDetailsAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeQualificationModel>($"/business/{businessId}/employee/{employeeId}/qualification/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Documents for Employee Qualification
        /// </summary>
        /// <remarks>
        /// Lists all the documents associated with a specific employee qualification.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> ListDocumentsForEmployeeQualification(int businessId, int employeeId, int qualificationId)
        {
            return ApiRequest<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", Method.Get);
        }

        /// <summary>
        /// List Documents for Employee Qualification
        /// </summary>
        /// <remarks>
        /// Lists all the documents associated with a specific employee qualification.
        /// </remarks>
        public Task<List<EmployeeQualificationDocumentModel>> ListDocumentsForEmployeeQualificationAsync(int businessId, int employeeId, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId)
        {
            return ApiRequest<List<EmployeeQualificationDocumentModel>,FileUploadModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", file, Method.Post);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeQualificationDocumentModel>> CreateEmployeeQualificationDocumentAsync(int businessId, int employeeId, FileUploadModel file, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeQualificationDocumentModel>,FileUploadModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request)
        {
            return ApiFileRequest<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document?visible={request.Visible}", file, Method.Post);
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<EmployeeQualificationDocumentModel>> CreateEmployeeQualificationDocumentAsync(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document?visible={request.Visible}", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Document by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a qualification document by ID.
        /// </remarks>
        public EmployeeQualificationDocumentModel GetQualificationDocumentById(int businessId, int employeeId, int id, int qualificationId)
        {
            return ApiRequest<EmployeeQualificationDocumentModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.Get);
        }

        /// <summary>
        /// Get Qualification Document by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a qualification document by ID.
        /// </remarks>
        public Task<EmployeeQualificationDocumentModel> GetQualificationDocumentByIdAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeQualificationDocumentModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Deletes a specific employee qualification document.
        /// </remarks>
        public void DeleteEmployeeQualificationDocument(int businessId, int employeeId, int id, int qualificationId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Deletes a specific employee qualification document.
        /// </remarks>
        public Task DeleteEmployeeQualificationDocumentAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Document File
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee qualification document by ID.
        /// </remarks>
        public DocumentFile GetQualificationDocumentFile(int businessId, int employeeId, int id, int qualificationId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}/content", Method.Get);
        }

        /// <summary>
        /// Get Qualification Document File
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee qualification document by ID.
        /// </remarks>
        public Task<DocumentFile> GetQualificationDocumentFileAsync(int businessId, int employeeId, int id, int qualificationId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}/content", Method.Get, cancellationToken);
        }
    }
}
