using KeyPay.DomainModels.V2.PayRun;

namespace KeyPay.ApiFunctions.V2
{
    public class LeaveAccruedFunction : BaseFunction
    {
        public LeaveAccruedFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public LeaveAccrualResponse List(int businessId, int payRunId)
        {
            return ApiRequest<LeaveAccrualResponse>("/business/" + businessId + "/payrun/" + payRunId + "/leaveaccrued");
        }
    }
}