using KeyPay.DomainModels.V2.PayRun;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class EarningsLineFunction : BaseFunction
    {
        public EarningsLineFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public EarningsLineResponse List(int businessId, int payRunId)
        {
            return ApiRequest<EarningsLineResponse>("/business/" + businessId + "/payrun/" + payRunId + "/earningslines");
        }

        public EarningsLineResponse List(int businessId, int payRunId, int employeeId)
        {
            return ApiRequest<EarningsLineResponse>(string.Format("/business/{0}/payrun/{1}/earningslines/{2}", businessId, payRunId, employeeId));
        }

        public void Submit(int businessId, EarningsLineRequest earningsLines)
        {
            ApiRequest("/business/" + businessId + "/payrun/" + earningsLines.PayRunId + "/earningslines", earningsLines, Method.POST);
        }
    }
}