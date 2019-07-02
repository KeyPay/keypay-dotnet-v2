using KeyPay.DomainModels.V2.Business;
using KeyPay.DomainModels.V2.Manager;
using RestSharp;
using System.Collections.Generic;
using System.Text;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerRosterShiftFunction : BaseFunction
    {
        public ManagerRosterShiftFunction(ApiRequestExecutor api) : base(api)
        {

        }

        public ManagerRosterDataModel Manage(int businessId, ManagerRosterShiftFilterModel filter)
        {
            var queryString = new StringBuilder("?");          
            queryString.Append($"Date={filter.Date.ToString("yyyy-MM-dd")}&");
            if (filter.EmployeeId.HasValue) queryString.Append($"EmployeeId={filter.EmployeeId.Value}&");
            if (filter.LocationId.HasValue) queryString.Append($"LocationId={filter.LocationId.Value}&");
            if (filter.RoleId.HasValue) queryString.Append($"RoleId={filter.RoleId.Value}&");
            if (filter.IncludeCosts.HasValue) queryString.Append($"IncludeCosts={filter.IncludeCosts.Value}&");
            if (filter.IncludeSubLocations.HasValue) queryString.Append($"RoleId={filter.IncludeSubLocations.Value}&");

            return ApiRequest<ManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage{queryString}", Method.GET);
        }
    }
}