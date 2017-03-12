using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class PaygAdjustmentsFunction : BaseFunction
    {
        public PaygAdjustmentsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public PaygAdjustmentResponse List(int businessId, int payRunId)
        {
            return ApiRequest<PaygAdjustmentResponse>("/business/" + businessId + "/payrun/" + payRunId + "/paygadjustments");
        }
    }
}