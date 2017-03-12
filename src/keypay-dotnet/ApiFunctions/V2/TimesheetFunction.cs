using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using KeyPay.DomainModels.V2.Custom;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class TimesheetFunction : BaseFunction
    {
        public TimesheetFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public IList<TimesheetModel> List(int businessId)
        {
            return ApiRequest<List<TimesheetModel>>(string.Format("/business/{0}/timesheet", businessId));
        }

        public IList<PayrollExport> GetByPayRunId(int businessId, int payRunId)
        {
            return ApiRequest<List<PayrollExport>>(string.Format("/business/{0}/payrun/{1}/timesheetlines", businessId, payRunId));
        }

        public void Create(int businessId, SubmitTimesheetRequest timesheetRequest)
        {
            ApiRequest("/business/" + businessId + "/timesheet/bulk/", timesheetRequest, Method.PUT);
        }
    }
}