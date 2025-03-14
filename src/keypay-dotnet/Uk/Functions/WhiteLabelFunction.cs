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
using KeyPayV2.Uk.Models.WhiteLabel;

namespace KeyPayV2.Uk.Functions
{
    public interface IWhiteLabelFunction
    {
        List<SignupModel> SignupReport(int whitelabelId);
        Task<List<SignupModel>> SignupReportAsync(int whitelabelId, CancellationToken cancellationToken = default);
        List<SignupModel> SignupReport(int whitelabelId, SignupReportQueryModel request);
        Task<List<SignupModel>> SignupReportAsync(int whitelabelId, SignupReportQueryModel request, CancellationToken cancellationToken = default);
        List<WhiteLabelModel> ListWhiteLabels();
        Task<List<WhiteLabelModel>> ListWhiteLabelsAsync(CancellationToken cancellationToken = default);
        WhiteLabelModel GetWhiteLabelById(int id);
        Task<WhiteLabelModel> GetWhiteLabelByIdAsync(int id, CancellationToken cancellationToken = default);
        List<CommonActiveEmployeesModel> ActiveEmployeesReport(int whiteLabelId);
        Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int whiteLabelId, CancellationToken cancellationToken = default);
        List<CommonActiveEmployeesModel> ActiveEmployeesReport(int whiteLabelId, ActiveEmployeesReportQueryModel request);
        Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int whiteLabelId, ActiveEmployeesReportQueryModel request, CancellationToken cancellationToken = default);
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

        /// <summary>
        /// List White Labels
        /// </summary>
        /// <remarks>
        /// Lists all the white labels to which you have access.
        /// </remarks>
        public List<WhiteLabelModel> ListWhiteLabels()
        {
            return ApiRequest<List<WhiteLabelModel>>($"/whitelabel", Method.Get);
        }

        /// <summary>
        /// List White Labels
        /// </summary>
        /// <remarks>
        /// Lists all the white labels to which you have access.
        /// </remarks>
        public Task<List<WhiteLabelModel>> ListWhiteLabelsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<WhiteLabelModel>>($"/whitelabel", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get White Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the white label with the specified ID.
        /// </remarks>
        public WhiteLabelModel GetWhiteLabelById(int id)
        {
            return ApiRequest<WhiteLabelModel>($"/whitelabel/{id}", Method.Get);
        }

        /// <summary>
        /// Get White Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the white label with the specified ID.
        /// </remarks>
        public Task<WhiteLabelModel> GetWhiteLabelByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<WhiteLabelModel>($"/whitelabel/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public List<CommonActiveEmployeesModel> ActiveEmployeesReport(int whiteLabelId)
        {
            return ApiRequest<List<CommonActiveEmployeesModel>>($"/whitelabel/{whiteLabelId}/reports/activeemployees", Method.Get);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int whiteLabelId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<CommonActiveEmployeesModel>>($"/whitelabel/{whiteLabelId}/reports/activeemployees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public List<CommonActiveEmployeesModel> ActiveEmployeesReport(int whiteLabelId, ActiveEmployeesReportQueryModel request)
        {
            return ApiRequest<List<CommonActiveEmployeesModel>>($"/whitelabel/{whiteLabelId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int whiteLabelId, ActiveEmployeesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<CommonActiveEmployeesModel>>($"/whitelabel/{whiteLabelId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
