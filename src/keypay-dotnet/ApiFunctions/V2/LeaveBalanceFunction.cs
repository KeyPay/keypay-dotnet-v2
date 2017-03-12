using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Employee;

namespace KeyPay.ApiFunctions.V2
{
    public class LeaveBalanceFunction : BaseFunction
    {
        public LeaveBalanceFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public List<LeaveBalanceModel> List(int businessId, int employeeId, DateTime? asAtDate = null)
        {
            var url = string.Format("/business/{0}/employee/{1}/leavebalances", businessId, employeeId);
            if (asAtDate.HasValue)
                url = string.Format(url + "?asatdate{0}", asAtDate.Value.ToString("yyyy-MM-dd"));

            return
                ApiRequest<List<LeaveBalanceModel>>(url);
        }
    }
}