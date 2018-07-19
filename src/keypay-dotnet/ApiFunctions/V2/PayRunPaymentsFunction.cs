using System.Collections.Generic;
using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class PayRunPaymentsFunction : BaseFunction
    {
        public PayRunPaymentsFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public List<PayRunBankPaymentModel> Get(int businessId, int payRunId)
        {
            return ApiRequest<List<PayRunBankPaymentModel>>("/business/" + businessId + "/payrun/" + payRunId + "/payments");
        }
    }
}