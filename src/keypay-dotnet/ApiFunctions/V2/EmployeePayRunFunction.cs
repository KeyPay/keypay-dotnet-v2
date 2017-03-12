using System.Collections.Generic;
using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployeePayRunFunction : BaseFunction
    {
        public EmployeePayRunFunction(ApiRequestExecutor api) : base(api)
        {
        }
        public IList<PayRunTotalModel> List(int businessId, int employeeId)
        {
            return ApiRequest<List<PayRunTotalModel>>(string.Format("/business/{0}/employee/{1}/payruntotals", businessId, employeeId));
        }
    }
}