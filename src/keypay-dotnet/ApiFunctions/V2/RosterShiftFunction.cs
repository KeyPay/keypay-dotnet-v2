using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class RosterShiftFunction : BaseFunction
    {
        public RosterShiftFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<RosterShiftGenerateTimesheetModel> List(int businessId, RosterShiftFilterModel filter)
        {
            return ApiRequest<List<RosterShiftGenerateTimesheetModel>, RosterShiftFilterModel>($"/business/{businessId}/rostershift", filter);
        }

        public void Stub(int businessId, RosterShiftStubTimesheetModel model)
        {
            ApiRequest($"/business/{businessId}/rostershift/{model.RosterShiftId}/stub", model, Method.POST);
        }

        public List<EmployeeRosterShiftModel> Nearby(int businessId, int employeeId, DateTime localTime)
        {
            return ApiRequest<List<EmployeeRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={localTime.ToString("O")}");
        }

        public RosterShiftMatchingResultModel MatchingClockOn(int businessId, int employeeId, int kioskId, DateTime dateUtc)
        {
            return ApiRequest<RosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={kioskId}&dateUtc={dateUtc.ToString("O")}");
        }

        public RosterShiftMatchingResultModel MatchingClockOff(int businessId, int employeeId, int kioskId, DateTime dateUtc)
        {
            return ApiRequest<RosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={kioskId}&dateUtc={dateUtc.ToString("O")}");
        }
    }
}