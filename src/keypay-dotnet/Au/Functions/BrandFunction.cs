using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Brand;

namespace KeyPayV2.Au.Functions
{
    public interface IBrandFunction
    {
        List<SignupModel> SignupReport(int brandId);
        Task<List<SignupModel>> SignupReportAsync(int brandId, CancellationToken cancellationToken = default);
        List<SignupModel> SignupReport(int brandId, SignupReportQueryModel request);
        Task<List<SignupModel>> SignupReportAsync(int brandId, SignupReportQueryModel request, CancellationToken cancellationToken = default);
    }
    public class BrandFunction : BaseFunction, IBrandFunction
    {
        public BrandFunction(ApiRequestExecutor api) : base(api) {}

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
            return ApiRequest<List<SignupModel>>($"/brand/{brandId}/reports/signups?EmailAddresses={request.EmailAddresses}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int brandId, SignupReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/brand/{brandId}/reports/signups?EmailAddresses={request.EmailAddresses}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
