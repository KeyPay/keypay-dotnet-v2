using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class PayRunTotalFunction : BaseFunction
    {
        public PayRunTotalFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public PayRunTotalResponse List(int businessId, int payRunId)
        {
            return ApiRequest<PayRunTotalResponse>("/business/" + businessId + "/payrun/" + payRunId + "/totals");
        }
    }
}