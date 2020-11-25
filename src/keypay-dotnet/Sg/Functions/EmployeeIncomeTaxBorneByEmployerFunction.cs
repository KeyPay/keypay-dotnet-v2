using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeIncomeTaxBorneByEmployer;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeIncomeTaxBorneByEmployerFunction : BaseFunction
    {
        public EmployeeIncomeTaxBorneByEmployerFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Gets the income tax borne by employer for the specified employee
        /// </remarks>
        public List<SgIncomeTaxBorneByEmployerModel> GetIncomeTaxBorneByEmployer(int businessId, int employeeId)
        {
            return ApiRequest<List<SgIncomeTaxBorneByEmployerModel>>($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer");
        }

        /// <summary>
        /// Create income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Creates a new income tax borne by employer
        /// </remarks>
        public void CreateIncomeTaxBorneByEmployer(int businessId, int employeeId, SgIncomeTaxBorneByEmployerModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer", model, Method.POST);
        }

        /// <summary>
        /// Get income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Gets a specific income tax borne by employer for the specified employee
        /// </remarks>
        public SgIncomeTaxBorneByEmployerModel GetIncomeTaxBorneByEmployer(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgIncomeTaxBorneByEmployerModel>($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}");
        }

        /// <summary>
        /// Update an existing income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Update an existing income tax borne by employer
        /// </remarks>
        public void UpdateAnExistingIncomeTaxBorneByEmployer(int businessId, int employeeId, int id, SgIncomeTaxBorneByEmployerModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", request, Method.PUT);
        }

        /// <summary>
        /// Delete income tax borne by employer
        /// </summary>
        /// <remarks>
        /// Deletes the income tax borne by employer with the specified ID.
        /// </remarks>
        public void DeleteIncomeTaxBorneByEmployer(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incometaxbornebyemployer/{id}", Method.DELETE);
        }
    }
}
