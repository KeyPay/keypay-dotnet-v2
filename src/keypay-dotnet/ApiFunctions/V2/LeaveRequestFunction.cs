using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Employee;
using KeyPay.DomainModels.V2.Manager;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class LeaveRequestFunction : BaseFunction
    {
        public LeaveRequestFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public List<LeaveRequestResponseModel> List(int businessId, int employeeId)
        {
            return ApiRequest<List<LeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest");
        }

        public LeaveRequestResponseModel Get(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<LeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}");
        }

        public LeaveRequestResponseModel Create(int businessId, int employeeId, CreateLeaveRequestModel leaveRequest)
        {
            return ApiRequest<LeaveRequestResponseModel, CreateLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", leaveRequest, Method.POST);
        }

        public LeaveRequestResponseModel Update(int businessId, int employeeId, UpdateLeaveRequestModel leaveRequest)
        {
            ApiRequest<LeaveRequestResponseModel, UpdateLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequest.Id}", leaveRequest, Method.PUT);
            return Get(businessId, employeeId, leaveRequest.Id);
        }

        public LeaveRequestResponseModel Cancel(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<LeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        public LeaveRequestResponseModel Approve(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<LeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        public LeaveRequestResponseModel Decline(int businessId, int employeeId, int leaveRequestId, string reason = null)
        {
            return ApiRequest<LeaveRequestResponseModel, string>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", reason, Method.POST);
        }

        public LeaveEstimateModel Estimate(int businessId, int employeeId, DateTime fromDate, DateTime toDate, int? leaveCategoryId)
        {
            return ApiRequest<LeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={fromDate.ToString("yyyy-MM-dd")}&toDate={toDate.ToString("yyyy-MM-dd")}&leaveCategoryId={leaveCategoryId}");
        }

        // Unit base leave request functions follow
        public List<LeaveRequestUnitResponseModel> ListUnit(int businessId, int employeeId)
        {
            return ApiRequest<List<LeaveRequestUnitResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest");
        }

        public LeaveRequestUnitResponseModel GetUnit(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<LeaveRequestUnitResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}");
        }

        public LeaveRequestUnitResponseModel CreateUnit(int businessId, int employeeId, CreateLeaveRequestUnitModel leaveRequest)
        {
            return ApiRequest<LeaveRequestUnitResponseModel, CreateLeaveRequestUnitModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", leaveRequest, Method.POST);
        }

        public LeaveRequestUnitResponseModel UpdateUnit(int businessId, int employeeId, UpdateLeaveRequestUnitModel leaveRequest)
        {
            ApiRequest<LeaveRequestUnitResponseModel, UpdateLeaveRequestUnitModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequest.Id}", leaveRequest, Method.PUT);
            return GetUnit(businessId, employeeId, leaveRequest.Id);
        }

        public LeaveRequestUnitResponseModel CancelUnit(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<LeaveRequestUnitResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        public LeaveRequestUnitResponseModel ApproveUnit(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<LeaveRequestUnitResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        public LeaveRequestUnitResponseModel DeclineUnit(int businessId, int employeeId, int leaveRequestId, string reason = null)
        {
            return ApiRequest<LeaveRequestUnitResponseModel, string>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", reason, Method.POST);
        }

        public LeaveEstimateUnitModel EstimateUnit(int businessId, int employeeId, DateTime fromDate, DateTime toDate, int? leaveCategoryId)
        {
            return ApiRequest<LeaveEstimateUnitModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={fromDate.ToString("yyyy-MM-dd")}&toDate={toDate.ToString("yyyy-MM-dd")}&leaveCategoryId={leaveCategoryId}");
        }

    }
}