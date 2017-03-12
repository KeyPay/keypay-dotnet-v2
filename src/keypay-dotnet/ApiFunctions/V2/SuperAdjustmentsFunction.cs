using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class SuperAdjustmentsFunction : BaseFunction
    {
        public SuperAdjustmentsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public SuperAdjustmentResponse List(int businessId, int payRunId)
        {
            return ApiRequest<SuperAdjustmentResponse>("/business/" + businessId + "/payrun/" + payRunId + "/superadjustments");
        }
    }
}