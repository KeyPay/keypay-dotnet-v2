using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeGainsOrProfitsEmployeeSharePlan;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeGainsOrProfitsEmployeeSharePlanFunction : BaseFunction
    {
        public EmployeeGainsOrProfitsEmployeeSharePlanFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Gains or profits employee share plans
        /// </summary>
        /// <remarks>
        /// Gets the gains or profits employee share plans for the specified employee
        /// </remarks>
        public List<SgGainsOrProfitsEmployeeSharePlanModel> GetGainsOrProfitsEmployeeSharePlans(int businessId, int employeeId)
        {
            return ApiRequest<List<SgGainsOrProfitsEmployeeSharePlanModel>>($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan");
        }

        /// <summary>
        /// Create Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Creates a new gains or profits employee share plan
        /// </remarks>
        public void CreateGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, SgGainsOrProfitsEmployeeSharePlanModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan", model, Method.POST);
        }

        /// <summary>
        /// Get Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Gets a specific gains or profits employee share plan for the specified employee
        /// </remarks>
        public SgGainsOrProfitsEmployeeSharePlanModel GetGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgGainsOrProfitsEmployeeSharePlanModel>($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}");
        }

        /// <summary>
        /// Update an existing Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Update an existing gains or profits employee share plan.
        /// </remarks>
        public void UpdateAnExistingGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id, SgGainsOrProfitsEmployeeSharePlanModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", request, Method.PUT);
        }

        /// <summary>
        /// Delete Gains or profits employee share plan
        /// </summary>
        /// <remarks>
        /// Deletes the Gains or profits employee share plan with the specified ID.
        /// </remarks>
        public void DeleteGainsOrProfitsEmployeeSharePlan(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/gainsorprofitsemployeeshareplan/{id}", Method.DELETE);
        }
    }
}
