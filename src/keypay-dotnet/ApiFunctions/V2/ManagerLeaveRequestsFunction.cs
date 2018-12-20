using System;
using System.Collections.Generic;
using System.Text;
using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Business;
using KeyPay.DomainModels.V2.Employee;
using KeyPay.DomainModels.V2.Manager;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerLeaveRequestsFunction : BaseFunction
    {
        public ManagerLeaveRequestsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<ManagerLeaveRequestModel> List(int businessId, ManagerLeaveRequestFilterModel filter)
        {
            var queryString = new StringBuilder("?");
            if (filter.Status.HasValue) queryString.Append($"Status={filter.Status.ToString()}&");
            if (filter.FromDate.HasValue) queryString.Append($"FromDate={filter.FromDate.Value.ToString("yyyy-MM-dd")}&");
            if (filter.ToDate.HasValue) queryString.Append($"ToDate={filter.ToDate.Value.ToString("yyyy-MM-dd")}&");
            if (filter.LeaveCategoryId.HasValue) queryString.Append($"LeaveCategoryId={filter.LeaveCategoryId}&");
            if (filter.LocationId.HasValue) queryString.Append($"LocationId={filter.LocationId}&");
            if (filter.EmployeeId.HasValue) queryString.Append($"EmployeeId={filter.EmployeeId}&");

            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest{queryString}");
        }

        public List<ManagerLeaveRequestModel> Overlapping(int businessId, DateTime fromDate, DateTime toDate)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest/overlapping?fromDate={fromDate.ToString("yyyy-MM-dd")}&toDate={toDate.ToString("yyyy-MM-dd")}");
        }

        public List<ManagerLeaveRequestModel> Overlapping(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/overlapping");
        }

        public ManagerLeaveRequestModel Get(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}");
        }

        public ManagerLeaveRequestModel Create(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplicationModel)
        {
            return ApiRequest<ManagerLeaveRequestModel, ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest", leaveApplicationModel, Method.POST);
        }

        public ManagerLeaveRequestModel Update(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplicationModel)
        {
            return ApiRequest<ManagerLeaveRequestModel, ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", leaveApplicationModel, Method.POST);
        }

        public ManagerLeaveRequestModel Approve(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        public ManagerLeaveRequestModel Decline(int businessId, int employeeId, int leaveRequestId, string reason)
        {
            return ApiRequest<ManagerLeaveRequestModel, DeclineReason>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", new DeclineReason { Reason = reason }, Method.POST);
        }

        public ManagerLeaveRequestModel Cancel(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        public DocumentFile Attachment(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/attachment");
        }

        public List<LeaveBalanceModel> Balances(int businessId, int employeeId, DateTime? asAtDate)
        {
            var queryString = asAtDate.HasValue
                ? $"?asAtDate={asAtDate.Value.ToString("yyyy-MM-dd")}"
                : "";
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances{queryString}");
        }

        public ManagerLeaveEstimateModel Estimate(int businessId, int employeeId, DateTime fromDate, DateTime toDate, int leaveCategoryId)
        {
            return ApiRequest<ManagerLeaveEstimateModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/estimate?fromDate={fromDate.ToString("yyyy-MM-dd")}&toDate={toDate.ToString("yyyy-MM-dd")}&leaveCategoryId={leaveCategoryId}");
        }

        public List<ManagerLeaveCategoryModel> Categories(int businessId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/leaverequest/categories");
        }

        public List<ManagerLeaveEmployeeModel> Employees(int businessId)
        {
            return ApiRequest<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/leaverequest/employees");
        }

        public List<LocationModel> Locations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/leaverequest/locations");
        }

        public List<ManagerLeaveCategoryModel> Categories(int businessId, int employeeId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/categories");
        }


    }
}