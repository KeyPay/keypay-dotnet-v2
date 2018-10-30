using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Business;
using KeyPay.DomainModels.V2.Manager;
using System.Text;
using RestSharp;
using System.Collections.Generic;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerTimesheetFunction : BaseFunction
    {
        public ManagerTimesheetFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<ManagerTimesheetEmployeeModel> Employees(int businessId)
        {
            return ApiRequest<List<ManagerTimesheetEmployeeModel>>($"/business/{businessId}/manager/timesheet/employees");
        }

        public List<LocationModel> Locations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/timesheet/locations");
        }

        public List<ManagerEmployeeGroup> EmployeeGroups(int businessId)
        {
            return ApiRequest<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/timesheet/employeegroups");
        }

        public ManagerTimesheetReferenceDataModel ReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<ManagerTimesheetReferenceDataModel>($"/business/{businessId}/manager/{employeeId}/timesheet/reference");
        }

        public PagedResultModel<ManagerTimesheetModel> List(int businessId, ManagerTimesheetRequestFilterModel filter)
        {
            var queryString = new StringBuilder("?");
            queryString.Append($"FromDate={filter.FromDate.ToString("yyyy-MM-dd")}&");
            queryString.Append($"ToDate={filter.ToDate.ToString("yyyy-MM-dd")}&");
            if (filter.Status.HasValue) queryString.Append($"Status={filter.Status.ToString()}&");
            if (filter.EmployeeId.HasValue) queryString.Append($"EmployeeId={filter.EmployeeId.ToString()}&");
            if (filter.EmployeeGroupId.HasValue) queryString.Append($"EmployeeGroupId={filter.EmployeeGroupId.ToString()}&");
            if (filter.LocationId.HasValue) queryString.Append($"LocationId={filter.LocationId.ToString()}&");
            if (filter.CurrentPage.HasValue) queryString.Append($"CurrentPage={filter.CurrentPage.ToString()}&");
            if (filter.PageSize.HasValue) queryString.Append($"PageSize={filter.PageSize.ToString()}&");
            if (filter.IncludeCosts.HasValue) queryString.Append($"IncludeCosts={filter.IncludeCosts.ToString()}&");

            return ApiRequest<PagedResultModel<ManagerTimesheetModel>>($"/business/{businessId}/manager/timesheet{queryString}");
        }

        public ManagerTimesheetModel Get(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}");
        }

        public ManagerTimesheetModel Update(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel managerTimesheetSubmitModel)
        {
            return ApiRequest<ManagerTimesheetModel, ManagerTimesheetSubmitModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", managerTimesheetSubmitModel, Method.POST);
        }

        public ManagerTimesheetModel Approve(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/approve", Method.POST);
        }

        public ManagerTimesheetModel Reject(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/reject", Method.POST);
        }

        public ManagerTimesheetModel Delete(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/delete", Method.DELETE);
        }

    }
}
