using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.WhiteLabel;

namespace KeyPayV2.Sg.Functions
{
    public interface IWhiteLabelFunction
    {
        List<SignupModel> SignupReport(int whitelabelId);
        Task<List<SignupModel>> SignupReportAsync(int whitelabelId, CancellationToken cancellationToken = default);
        List<SignupModel> SignupReport(int whitelabelId, SignupReportQueryModel request);
        Task<List<SignupModel>> SignupReportAsync(int whitelabelId, SignupReportQueryModel request, CancellationToken cancellationToken = default);
    }
    public class WhiteLabelFunction : BaseFunction, IWhiteLabelFunction
    {
        public WhiteLabelFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int whitelabelId)
        {
            return ApiRequest<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups", Method.Get);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int whitelabelId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int whitelabelId, SignupReportQueryModel request)
        {
            return ApiRequest<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups?EmailAddresses={request.EmailAddresses}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int whitelabelId, SignupReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups?EmailAddresses={request.EmailAddresses}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
