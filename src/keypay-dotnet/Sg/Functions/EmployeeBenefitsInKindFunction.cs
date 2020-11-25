using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeBenefitsInKind;

namespace KeyPayV2.Sg.Functions
{
    public class EmployeeBenefitsInKindFunction : BaseFunction
    {
        public EmployeeBenefitsInKindFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get benefits in kinds
        /// </summary>
        /// <remarks>
        /// Gets the benefits in kind for the specified employee
        /// </remarks>
        public List<SgBenefitsInKind> GetBenefitsInKinds(int businessId, int employeeId)
        {
            return ApiRequest<List<SgBenefitsInKind>>($"/business/{businessId}/employee/{employeeId}/benefitsinkind");
        }

        /// <summary>
        /// Create benefit in kind
        /// </summary>
        /// <remarks>
        /// Creates a new benefit in kind for the employee.
        /// </remarks>
        public void CreateBenefitInKind(int businessId, int employeeId, SgBenefitsInKind model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkind", model, Method.POST);
        }

        /// <summary>
        /// Get benefits in kind
        /// </summary>
        /// <remarks>
        /// Gets a specific gains or profits employee share plan for the specified employee
        /// </remarks>
        public SgBenefitsInKind GetBenefitsInKind(int businessId, int employeeId, int id)
        {
            return ApiRequest<SgBenefitsInKind>($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}");
        }

        /// <summary>
        /// Update an benefit in kind
        /// </summary>
        /// <remarks>
        /// Update an existing benefit in kind.
        /// </remarks>
        public void UpdateAnBenefitInKind(int businessId, int employeeId, int id, SgBenefitsInKind request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", request, Method.PUT);
        }

        /// <summary>
        /// Delete benefit in kind
        /// </summary>
        /// <remarks>
        /// Deletes the benefit in kind with the specified ID.
        /// </remarks>
        public void DeleteBenefitInKind(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/benefitsinkind/{id}", Method.DELETE);
        }
    }
}
