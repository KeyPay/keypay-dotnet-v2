using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeIncomeFromOverseasSubjectToTaxRemission;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeIncomeFromOverseasSubjectToTaxRemissionFunction : BaseFunction
    {
        public EmployeeIncomeFromOverseasSubjectToTaxRemissionFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Income from overseas subject to tax remissions
        /// </summary>
        /// <remarks>
        /// Gets the income from overseas subject to tax remissions for the specified employee
        /// </remarks>
        public List<SgIncomeFromOverseasSubjectToTaxRemissionModel> GetIncomeFromOverseasSubjectToTaxRemissions(int businessId, int employeeId)
        {
            return ApiRequest<List<SgIncomeFromOverseasSubjectToTaxRemissionModel>>($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission");
        }

        /// <summary>
        /// Create Income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Creates a new income from overseas subject to tax remissions
        /// </remarks>
        public void CreateIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, SgIncomeFromOverseasSubjectToTaxRemissionModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission", model, Method.POST);
        }

        /// <summary>
        /// Get Income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Gets a specific income from overseas subject to tax remission for the specified employee
        /// </remarks>
        public SgIncomeFromOverseasSubjectToTaxRemissionModel GetIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgIncomeFromOverseasSubjectToTaxRemissionModel>($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}");
        }

        /// <summary>
        /// Update an existing income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Update an existing income from overseas subject to tax remission
        /// </remarks>
        public void UpdateAnExistingIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id, SgIncomeFromOverseasSubjectToTaxRemissionModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", request, Method.PUT);
        }

        /// <summary>
        /// Delete income from overseas subject to tax remission
        /// </summary>
        /// <remarks>
        /// Deletes the income from overseas subject to tax remission with the specified ID.
        /// </remarks>
        public void DeleteIncomeFromOverseasSubjectToTaxRemission(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/incomefromoverseassubjecttotaxremission/{id}", Method.DELETE);
        }
    }
}
