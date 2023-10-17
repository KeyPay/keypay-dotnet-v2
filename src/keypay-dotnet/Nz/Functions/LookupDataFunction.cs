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
using KeyPayV2.Nz.Models.LookupData;

namespace KeyPayV2.Nz.Functions
{
    public interface ILookupDataFunction
    {
        List<NameIdPair> ListTimeZoneTypes(int businessId);
        Task<List<NameIdPair>> ListTimeZoneTypesAsync(int businessId, CancellationToken cancellationToken = default);
        List<NameIdPair> ListCountries();
        Task<List<NameIdPair>> ListCountriesAsync(CancellationToken cancellationToken = default);
        List<NameIdPair> ListEmployeeGroupPermissionTypes();
        Task<List<NameIdPair>> ListEmployeeGroupPermissionTypesAsync(CancellationToken cancellationToken = default);
        List<string> ListGenderOptions();
        Task<List<string>> ListGenderOptionsAsync(CancellationToken cancellationToken = default);
        List<String> ListIndustryOptions();
        Task<List<String>> ListIndustryOptionsAsync(CancellationToken cancellationToken = default);
        List<NameIdPair> ListReportTypes();
        Task<List<NameIdPair>> ListReportTypesAsync(CancellationToken cancellationToken = default);
        List<NameIdPair> ListTimeZoneTypes();
        Task<List<NameIdPair>> ListTimeZoneTypesAsync(CancellationToken cancellationToken = default);
    }
    public class LookupDataFunction : BaseFunction, ILookupDataFunction
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
            return ApiRequest<List<NameIdPair>>($"/business/{businessId}/lookupdata/timezones", Method.Get);
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public Task<List<NameIdPair>> ListTimeZoneTypesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/business/{businessId}/lookupdata/timezones", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List countries
        /// </summary>
        public List<NameIdPair> ListCountries()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/countries", Method.Get);
        }

        /// <summary>
        /// List countries
        /// </summary>
        public Task<List<NameIdPair>> ListCountriesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/countries", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Employee Group Permission Types
        /// </summary>
        /// <remarks>
        /// Lists all of the employee group permission types.
        /// </remarks>
        public List<NameIdPair> ListEmployeeGroupPermissionTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/employeegrouppermissions", Method.Get);
        }

        /// <summary>
        /// List Employee Group Permission Types
        /// </summary>
        /// <remarks>
        /// Lists all of the employee group permission types.
        /// </remarks>
        public Task<List<NameIdPair>> ListEmployeeGroupPermissionTypesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/employeegrouppermissions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List gender options
        /// </summary>
        public List<string> ListGenderOptions()
        {
            return ApiRequest<List<string>>($"/lookupdata/genders", Method.Get);
        }

        /// <summary>
        /// List gender options
        /// </summary>
        public Task<List<string>> ListGenderOptionsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<string>>($"/lookupdata/genders", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List industry options
        /// </summary>
        public List<String> ListIndustryOptions()
        {
            return ApiRequest<List<String>>($"/lookupdata/industries", Method.Get);
        }

        /// <summary>
        /// List industry options
        /// </summary>
        public Task<List<String>> ListIndustryOptionsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<String>>($"/lookupdata/industries", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Report Types
        /// </summary>
        /// <remarks>
        /// Lists all of the report types.
        /// </remarks>
        public List<NameIdPair> ListReportTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/reports", Method.Get);
        }

        /// <summary>
        /// List Report Types
        /// </summary>
        /// <remarks>
        /// Lists all of the report types.
        /// </remarks>
        public Task<List<NameIdPair>> ListReportTypesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/reports", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public List<NameIdPair> ListTimeZoneTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/timezones", Method.Get);
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public Task<List<NameIdPair>> ListTimeZoneTypesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NameIdPair>>($"/lookupdata/timezones", Method.Get, cancellationToken);
        }
    }
}
