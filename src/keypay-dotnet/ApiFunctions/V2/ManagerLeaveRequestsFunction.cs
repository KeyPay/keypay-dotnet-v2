using System;
using System.Collections.Generic;
using System.Text;
using KeyPay.DomainModels.V2;
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

        public ManagerLeaveRequestModel Approve(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        public ManagerLeaveRequestModel Decline(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", Method.POST);
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
    }
}