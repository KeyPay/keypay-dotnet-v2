using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.WhiteLabel;

namespace KeyPayV2.Au.Functions
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
            return ApiRequest<List<WhiteLabelModel>>($"/whitelabel");
        }

        /// <summary>
        /// Get White Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the white label with the specified ID.
        /// </remarks>
        public WhiteLabelModel GetWhiteLabelById(int id)
        {
            return ApiRequest<WhiteLabelModel>($"/whitelabel/{id}");
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// White Label Active Employees Report
        /// </remarks>
        public List<AuActiveEmployeesModel> ActiveEmployeesReport(int whitelabelId, ActiveEmployeesReportQueryModel request)
        {
            return ApiRequest<List<AuActiveEmployeesModel>>($"/whitelabel/{whitelabelId}/reports/activeemployees?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// White Label sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int whitelabelId, SignupReportQueryModel request)
        {
            return ApiRequest<List<SignupModel>>($"/whitelabel/{whitelabelId}/reports/signups?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&emailAddresses={request.EmailAddresses}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }
    }
}
