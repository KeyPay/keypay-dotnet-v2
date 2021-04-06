using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeeBenefitCategory;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeBenefitCategoryFunction : BaseFunction
    {
        public EmployeeBenefitCategoryFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List employee benefits
        /// </summary>
        /// <remarks>
        /// Lists all the benefits that are assigned to an employee
        /// </remarks>
        public UkEmployeeBenefitCategories ListEmployeeBenefits(int businessId, int employeeId)
        {
            return ApiRequest<UkEmployeeBenefitCategories>($"/business/{businessId}/employee/{employeeId}/benefit");
        }

        /// <summary>
        /// Update employee benefit
        /// </summary>
        /// <remarks>
        /// Updates an existing employee benefit
        /// </remarks>
        public UkEmployeeBenefitCategoryModel UpdateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryModel model)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.PUT);
        }

        /// <summary>
        /// Create employee benefit
        /// </summary>
        /// <remarks>
        /// Creates a new employee benefit
        /// </remarks>
        public UkEmployeeBenefitCategoryModel CreateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryEditModel model)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryEditModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.POST);
        }

        /// <summary>
        /// Get employee benefit
        /// </summary>
        /// <remarks>
        /// Get the benefit assigned to an employee for a particular benefit category
        /// </remarks>
        public UkEmployeeBenefitCategoryModel GetEmployeeBenefit(int businessId, int employeeId, int benefitCategoryId)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit/{benefitCategoryId}");
        }
    }
}
