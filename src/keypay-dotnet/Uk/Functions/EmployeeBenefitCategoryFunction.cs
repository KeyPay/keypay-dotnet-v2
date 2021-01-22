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
        /// Create employee benefit
        /// </summary>
        /// <remarks>
        /// Creates a new employee benefit
        /// </remarks>
        public UkEmployeeBenefitCategoryModel CreateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryEditModel model)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryEditModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.PUT);
        }

        /// <summary>
        /// Update employee benefit
        /// </summary>
        /// <remarks>
        /// Updates an existing employee benefit
        /// </remarks>
        public UkEmployeeBenefitCategoryModel UpdateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryModel model)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.POST);
        }
    }
}
