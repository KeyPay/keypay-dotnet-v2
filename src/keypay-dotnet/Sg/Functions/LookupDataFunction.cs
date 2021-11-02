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
using KeyPayV2.Sg.Models.LookupData;

namespace KeyPayV2.Sg.Functions
{
    public class LookupDataFunction : BaseFunction
    {
        public LookupDataFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public List<NameIdPair> ListTimeZoneTypes(int businessId)
        {
            return ApiRequest<List<NameIdPair>>($"/business/{businessId}/lookupdata/timezones", Method.GET);
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public Task<List<NameIdPair>> ListTimeZoneTypesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/business/{businessId}/lookupdata/timezones", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List countries
        /// </summary>
        public List<NameIdPair> ListCountries()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/countries", Method.GET);
        }

        /// <summary>
        /// List countries
        /// </summary>
        public Task<List<NameIdPair>> ListCountriesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/countries", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Employee Group Permission Types
        /// </summary>
        /// <remarks>
        /// Lists all of the employee group permission types.
        /// </remarks>
        public List<NameIdPair> ListEmployeeGroupPermissionTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/employeegrouppermissions", Method.GET);
        }

        /// <summary>
        /// List Employee Group Permission Types
        /// </summary>
        /// <remarks>
        /// Lists all of the employee group permission types.
        /// </remarks>
        public Task<List<NameIdPair>> ListEmployeeGroupPermissionTypesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/employeegrouppermissions", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List gender options
        /// </summary>
        public List<string> ListGenderOptions()
        {
            return ApiRequest<List<string>>($"/lookupdata/genders", Method.GET);
        }

        /// <summary>
        /// List gender options
        /// </summary>
        public Task<List<string>> ListGenderOptionsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<string>>($"/lookupdata/genders", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Report Types
        /// </summary>
        /// <remarks>
        /// Lists all of the report types.
        /// </remarks>
        public List<NameIdPair> ListReportTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/reports", Method.GET);
        }

        /// <summary>
        /// List Report Types
        /// </summary>
        /// <remarks>
        /// Lists all of the report types.
        /// </remarks>
        public Task<List<NameIdPair>> ListReportTypesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/reports", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public List<NameIdPair> ListTimeZoneTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/timezones", Method.GET);
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public Task<List<NameIdPair>> ListTimeZoneTypesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/timezones", Method.GET, cancellationToken);
        }
    }
}
