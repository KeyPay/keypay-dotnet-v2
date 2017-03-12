using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class PayRunDetailsFunction : BaseFunction
    {
        public PayRunDetailsFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public PayRunTotalSummaryModel Get(int businessId, int payRunId)
        {
            return ApiRequest<PayRunTotalSummaryModel>("/business/" + businessId + "/payrun/" + payRunId + "/details");
        }
    }
}