using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.LookupData;

namespace KeyPayV2.Uk.Functions
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
            return ApiRequest<List<NameIdPair>>($"/business/{businessId}/lookupdata/timezones");
        }

        /// <summary>
        /// List Employee Group Permission Types
        /// </summary>
        /// <remarks>
        /// Lists all of the employee group permission types.
        /// </remarks>
        public List<NameIdPair> ListEmployeeGroupPermissionTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/employeegrouppermissions");
        }

        /// <summary>
        /// List Report Types
        /// </summary>
        /// <remarks>
        /// Lists all of the report types.
        /// </remarks>
        public List<NameIdPair> ListReportTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/reports");
        }

        /// <summary>
        /// List Time Zone Types
        /// </summary>
        /// <remarks>
        /// Lists all of the time zone types.
        /// </remarks>
        public List<NameIdPair> ListTimeZoneTypes()
        {
            return ApiRequest<List<NameIdPair>>($"/lookupdata/timezones");
        }
    }
}
