using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.WhiteLabel;

namespace KeyPayV2.My.Functions
{
    public class WhiteLabelFunction : BaseFunction
    {
        public WhiteLabelFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List White Labels
        /// </summary>
        /// <remarks>
        /// Lists all the white labels to which you have access.
        /// </remarks>
        public List<WhiteLabelModel> ListWhiteLabels()
        {
            return ApiRequest<List<WhiteLabelModel>>($"/whitelabel", Method.GET);
        }

        /// <summary>
        /// List White Labels
        /// </summary>
        /// <remarks>
        /// Lists all the white labels to which you have access.
        /// </remarks>
        public Task<List<WhiteLabelModel>> ListWhiteLabelsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<WhiteLabelModel>>($"/whitelabel", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get White Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the white label with the specified ID.
        /// </remarks>
        public WhiteLabelModel GetWhiteLabelById(int id)
        {
            return ApiRequest<WhiteLabelModel>($"/whitelabel/{id}", Method.GET);
        }

        /// <summary>
        /// Get White Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the white label with the specified ID.
        /// </remarks>
        public Task<WhiteLabelModel> GetWhiteLabelByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<WhiteLabelModel>($"/whitelabel/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public List<CommonActiveEmployeesModel> ActiveEmployeesReport(int whiteLabelId, ActiveEmployeesReportQueryModel request)
        {
            return ApiRequest<List<CommonActiveEmployeesModel>>($"/whitelabel/{whiteLabelId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET);
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public Task<List<CommonActiveEmployeesModel>> ActiveEmployeesReportAsync(int whiteLabelId, ActiveEmployeesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<CommonActiveEmployeesModel>>($"/whitelabel/{whiteLabelId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int whitelabelId, SignupReportQueryModel request)
        {
            return ApiRequest<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET);
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public Task<List<SignupModel>> SignupReportAsync(int whitelabelId, SignupReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.GET, cancellationToken);
        }
    }
}
