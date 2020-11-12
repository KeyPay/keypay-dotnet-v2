using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeeQualifications;

namespace KeyPayV2.Uk.Functions
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
            return ApiRequest<List<EmployeeQualificationModel>>($"/business/{businessId}/employee/{employeeId}/qualification");
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
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific ID.
        /// </remarks>
        public EmployeeQualificationModel GetQualificationDetails(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeQualificationModel>($"/business/{businessId}/employee/{employeeId}/qualification/{id}");
        }

        /// <summary>
        /// List Documents for Employee Qualification
        /// </summary>
        /// <remarks>
        /// Lists all the documents associated with a specific employee qualification.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> ListDocumentsForEmployeeQualification(int businessId, int employeeId, int qualificationId)
        {
            return ApiRequest<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document");
        }

        /// <summary>
        /// Create Employee Qualification Document
        /// </summary>
        /// <remarks>
        /// Uploads an employee qualification document. Note: the request should be a MIME multipart file upload request.
        /// </remarks>
        public List<EmployeeQualificationDocumentModel> CreateEmployeeQualificationDocument(int businessId, int employeeId, FileUploadModel file, int qualificationId, CreateEmployeeQualificationDocumentQueryModel request)
        {
            return ApiFileRequest<List<EmployeeQualificationDocumentModel>>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document?visible={request.Visible}", file);
        }

        /// <summary>
        /// Get Qualification Document by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a qualification document by ID.
        /// </remarks>
        public EmployeeQualificationDocumentModel GetQualificationDocumentById(int businessId, int employeeId, int id, int qualificationId)
        {
            return ApiRequest<EmployeeQualificationDocumentModel>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}");
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
        /// Get Qualification Document File
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee qualification document by ID.
        /// </remarks>
        public DocumentFile GetQualificationDocumentFile(int businessId, int employeeId, int id, int qualificationId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/employee/{employeeId}/qualification/{qualificationId}/document/{id}/content");
        }
    }
}
