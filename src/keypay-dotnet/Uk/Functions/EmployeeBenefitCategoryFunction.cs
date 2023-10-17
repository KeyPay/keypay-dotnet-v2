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
using KeyPayV2.Uk.Models.EmployeeBenefitCategory;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeeBenefitCategoryFunction
    {
        UkEmployeeBenefitCategories ListEmployeeBenefits(int businessId, int employeeId);
        Task<UkEmployeeBenefitCategories> ListEmployeeBenefitsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkEmployeeBenefitCategoryModel UpdateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryModel model);
        Task<UkEmployeeBenefitCategoryModel> UpdateEmployeeBenefitAsync(int businessId, int employeeId, UkEmployeeBenefitCategoryModel model, CancellationToken cancellationToken = default);
        UkEmployeeBenefitCategoryModel CreateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryEditModel model);
        Task<UkEmployeeBenefitCategoryModel> CreateEmployeeBenefitAsync(int businessId, int employeeId, UkEmployeeBenefitCategoryEditModel model, CancellationToken cancellationToken = default);
        UkEmployeeBenefitCategoryModel GetEmployeeBenefit(int businessId, int employeeId, int benefitCategoryId);
        Task<UkEmployeeBenefitCategoryModel> GetEmployeeBenefitAsync(int businessId, int employeeId, int benefitCategoryId, CancellationToken cancellationToken = default);
    }
    public class EmployeeBenefitCategoryFunction : BaseFunction, IEmployeeBenefitCategoryFunction
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
            return ApiRequest<UkEmployeeBenefitCategories>($"/business/{businessId}/employee/{employeeId}/benefit", Method.Get);
        }

        /// <summary>
        /// List employee benefits
        /// </summary>
        /// <remarks>
        /// Lists all the benefits that are assigned to an employee
        /// </remarks>
        public Task<UkEmployeeBenefitCategories> ListEmployeeBenefitsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeBenefitCategories>($"/business/{businessId}/employee/{employeeId}/benefit", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update employee benefit
        /// </summary>
        /// <remarks>
        /// Updates an existing employee benefit
        /// </remarks>
        public UkEmployeeBenefitCategoryModel UpdateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryModel model)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.Put);
        }

        /// <summary>
        /// Update employee benefit
        /// </summary>
        /// <remarks>
        /// Updates an existing employee benefit
        /// </remarks>
        public Task<UkEmployeeBenefitCategoryModel> UpdateEmployeeBenefitAsync(int businessId, int employeeId, UkEmployeeBenefitCategoryModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create employee benefit
        /// </summary>
        /// <remarks>
        /// Creates a new employee benefit
        /// </remarks>
        public UkEmployeeBenefitCategoryModel CreateEmployeeBenefit(int businessId, int employeeId, UkEmployeeBenefitCategoryEditModel model)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryEditModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.Post);
        }

        /// <summary>
        /// Create employee benefit
        /// </summary>
        /// <remarks>
        /// Creates a new employee benefit
        /// </remarks>
        public Task<UkEmployeeBenefitCategoryModel> CreateEmployeeBenefitAsync(int businessId, int employeeId, UkEmployeeBenefitCategoryEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeBenefitCategoryModel,UkEmployeeBenefitCategoryEditModel>($"/business/{businessId}/employee/{employeeId}/benefit", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get employee benefit
        /// </summary>
        /// <remarks>
        /// Get the benefit assigned to an employee for a particular benefit category
        /// </remarks>
        public UkEmployeeBenefitCategoryModel GetEmployeeBenefit(int businessId, int employeeId, int benefitCategoryId)
        {
            return ApiRequest<UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit/{benefitCategoryId}", Method.Get);
        }

        /// <summary>
        /// Get employee benefit
        /// </summary>
        /// <remarks>
        /// Get the benefit assigned to an employee for a particular benefit category
        /// </remarks>
        public Task<UkEmployeeBenefitCategoryModel> GetEmployeeBenefitAsync(int businessId, int employeeId, int benefitCategoryId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeBenefitCategoryModel>($"/business/{businessId}/employee/{employeeId}/benefit/{benefitCategoryId}", Method.Get, cancellationToken);
        }
    }
}
