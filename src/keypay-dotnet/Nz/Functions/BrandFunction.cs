using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.Brand;

namespace KeyPayV2.Nz.Functions
{
    public interface IBrandFunction
    {
        List<BrandModel> ListBrandLabels();
        Task<List<BrandModel>> ListBrandLabelsAsync(CancellationToken cancellationToken = default);
        void CancelBusiness(int businessId, string brandId);
        Task CancelBusinessAsync(int businessId, string brandId, CancellationToken cancellationToken = default);
        List<BusinessTemplateModel> ListBusinessTemplates(string brandId);
        Task<List<BusinessTemplateModel>> ListBusinessTemplatesAsync(string brandId, CancellationToken cancellationToken = default);
        List<CommonActiveEmployeesModel> ActiveEmployeesReport(int brandId);
        Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int brandId, CancellationToken cancellationToken = default);
        List<CommonActiveEmployeesModel> ActiveEmployeesReport(int brandId, ActiveEmployeesReportQueryModel request);
        Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int brandId, ActiveEmployeesReportQueryModel request, CancellationToken cancellationToken = default);
        List<SignupModel> SignupReport(int brandId);
        Task<List<SignupModel>> SignupReportAsync(int brandId, CancellationToken cancellationToken = default);
        List<SignupModel> SignupReport(int brandId, SignupReportQueryModel request);
        Task<List<SignupModel>> SignupReportAsync(int brandId, SignupReportQueryModel request, CancellationToken cancellationToken = default);
        BrandModel GetBrandLabelById(int id);
        Task<BrandModel> GetBrandLabelByIdAsync(int id, CancellationToken cancellationToken = default);
    }
    public class BrandFunction : BaseFunction, IBrandFunction
    {
        public BrandFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Brand Labels
        /// </summary>
        /// <remarks>
        /// Lists all the brand labels to which you have access.
        /// </remarks>
        public List<BrandModel> ListBrandLabels()
        {
            return ApiRequest<List<BrandModel>>($"/brand", Method.Get);
        }

        /// <summary>
        /// List Brand Labels
        /// </summary>
        /// <remarks>
        /// Lists all the brand labels to which you have access.
        /// </remarks>
        public Task<List<BrandModel>> ListBrandLabelsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BrandModel>>($"/brand", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Cancel Business
        /// </summary>
        /// <remarks>
        /// Delete all pay runs and employees. Disassociates users who have access to other businesses or brands. Deactivates users only associated with this business.
        /// This endpoint is for brand users only.
        /// </remarks>
        public void CancelBusiness(int businessId, string brandId)
        {
            ApiRequest($"/brand/{brandId}/business/{businessId}/cancel", Method.Delete);
        }

        /// <summary>
        /// Cancel Business
        /// </summary>
        /// <remarks>
        /// Delete all pay runs and employees. Disassociates users who have access to other businesses or brands. Deactivates users only associated with this business.
        /// This endpoint is for brand users only.
        /// </remarks>
        public Task CancelBusinessAsync(int businessId, string brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/brand/{brandId}/business/{businessId}/cancel", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Business Templates
        /// </summary>
        public List<BusinessTemplateModel> ListBusinessTemplates(string brandId)
        {
            return ApiRequest<List<BusinessTemplateModel>>($"/brand/{brandId}/business-templates", Method.Get);
        }

        /// <summary>
        /// List Business Templates
        /// </summary>
        public Task<List<BusinessTemplateModel>> ListBusinessTemplatesAsync(string brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BusinessTemplateModel>>($"/brand/{brandId}/business-templates", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public List<CommonActiveEmployeesModel> ActiveEmployeesReport(int brandId)
        {
            return ApiRequest<List<CommonActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees", Method.Get);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<CommonActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public List<CommonActiveEmployeesModel> ActiveEmployeesReport(int brandId, ActiveEmployeesReportQueryModel request)
        {
            return ApiRequest<List<CommonActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int brandId, ActiveEmployeesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<CommonActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int brandId)
        {
            return ApiRequest<List<SignupModel>>($"/brand/{brandId}/reports/signups", Method.Get);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/brand/{brandId}/reports/signups", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int brandId, SignupReportQueryModel request)
        {
            return ApiRequest<List<SignupModel>>($"/brand/{brandId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int brandId, SignupReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/brand/{brandId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Brand Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the brand label with the specified ID.
        /// </remarks>
        public BrandModel GetBrandLabelById(int id)
        {
            return ApiRequest<BrandModel>($"/brand/{id}", Method.Get);
        }

        /// <summary>
        /// Get Brand Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the brand label with the specified ID.
        /// </remarks>
        public Task<BrandModel> GetBrandLabelByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BrandModel>($"/brand/{id}", Method.Get, cancellationToken);
        }
    }
}
