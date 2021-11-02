using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.Brand;

namespace KeyPayV2.Sg.Functions
{
    public class BrandFunction : BaseFunction
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
            return ApiRequest<List<BrandModel>>($"/brand", Method.GET);
        }

        /// <summary>
        /// List Brand Labels
        /// </summary>
        /// <remarks>
        /// Lists all the brand labels to which you have access.
        /// </remarks>
        public Task<List<BrandModel>> ListBrandLabelsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BrandModel>>($"/brand", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public List<CommonActiveEmployeesModel> ActiveEmployeesReport(int brandId, ActiveEmployeesReportQueryModel request)
        {
            return ApiRequest<List<CommonActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int brandId, ActiveEmployeesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<CommonActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int brandId, SignupReportQueryModel request)
        {
            return ApiRequest<List<SignupModel>>($"/brand/{brandId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int brandId, SignupReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/brand/{brandId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Brand Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the brand label with the specified ID.
        /// </remarks>
        public BrandModel GetBrandLabelById(int id)
        {
            return ApiRequest<BrandModel>($"/brand/{id}", Method.GET);
        }

        /// <summary>
        /// Get Brand Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the brand label with the specified ID.
        /// </remarks>
        public Task<BrandModel> GetBrandLabelByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BrandModel>($"/brand/{id}", Method.GET, cancellationToken);
        }
    }
}
