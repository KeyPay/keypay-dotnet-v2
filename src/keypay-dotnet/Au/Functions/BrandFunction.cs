using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Brand;

namespace KeyPayV2.Au.Functions
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
            return ApiRequest<List<BrandModel>>($"/brand");
        }

        /// <summary>
        /// Active Employees Report
        /// </summary>
        /// <remarks>
        /// Brand Active Employees Report
        /// </remarks>
        public List<AuActiveEmployeesModel> ActiveEmployeesReport(int brandId, ActiveEmployeesReportQueryModel request)
        {
            return ApiRequest<List<AuActiveEmployeesModel>>($"/brand/{brandId}/reports/activeemployees?emailAddresses={request.EmailAddresses}&includeInactiveBusinesses={request.IncludeInactiveBusinesses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Signup Report
        /// </summary>
        /// <remarks>
        /// Brand sign up report
        /// </remarks>
        public List<SignupModel> SignupReport(int brandId, SignupReportQueryModel request)
        {
            return ApiRequest<List<SignupModel>>($"/brand/{brandId}/reports/signups?emailAddresses={request.EmailAddresses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Get Brand Label by ID
        /// </summary>
        /// <remarks>
        /// Gets the brand label with the specified ID.
        /// </remarks>
        public BrandModel GetBrandLabelById(int id)
        {
            return ApiRequest<BrandModel>($"/brand/{id}");
        }
    }
}
