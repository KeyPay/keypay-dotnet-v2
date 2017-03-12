using System.Collections.Generic;
using System.Linq;
using KeyPay.DomainModels.V2.Report;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class PaymentSummaryFunction : BaseFunction
    {
        public PaymentSummaryFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public List<PaygPaymentSummaryModel> Get(int businessId, int financialYearEnding, int? employeeId = null, int? employingEntityId = 0, int? locationId = null)
        {
            var url = string.Format("/business/{0}/paymentsummary/{1}?$filter=", businessId, financialYearEnding);
            var hasFilter = false;
            if (employeeId.HasValue)
            {
                hasFilter = true;
                url += string.Format("EmployeeId eq {0}", employeeId.Value);
            }
            if (employingEntityId != 0)
            {
                url += string.Format("{0} EmployingEntityId eq {1}", hasFilter? " and " : "", employingEntityId == null ? "null" : employingEntityId.ToString());
                hasFilter = true;
            }
            if (locationId.HasValue)
            {
                url += string.Format("{0} LocationId eq {1}", hasFilter ? " and " : "", locationId.Value);
            }
            return ApiRequest<List<PaygPaymentSummaryModel>>(url);
        }

        public PaygPaymentSummaryModel Get(int businessId, int financialYearEnding, int employeeId)
        {
            return ApiRequest<List<PaygPaymentSummaryModel>>(string.Format("/business/{0}/paymentsummary/{1}?$filter=EmployeeId eq {2}", businessId, financialYearEnding, employeeId)).FirstOrDefault();
        }

        public void Generate(int businessId, int financialYearEnding, int? employeeId = null, int? employingEntityId = null, int? locationId = null)
        {
            ApiRequest(FormatUrl(businessId, financialYearEnding, employeeId, employingEntityId, locationId), Method.PUT);
        }

        private string FormatUrl(int businessId, int financialYearEnding, int? employeeId = null, int? employingEntityId = null, int? locationId = null)
        {
            var url = string.Format("/business/{0}/paymentsummary/{1}?x=1", businessId, financialYearEnding);
            if (employeeId.HasValue)
            {
                url += string.Format("&employeeId={0}", employeeId.Value);
            }
            if (employingEntityId.HasValue)
            {
                url += string.Format("&employingEntityId={0}", employingEntityId.Value);
            }
            if (locationId.HasValue)
            {
                url += string.Format("&locationId={0}", locationId.Value);
            }
            return url;
        }

        public void Publish(int businessId, int financialYearEnding, int? employeeId = null, int? employingEntityId = null, int? locationId = null)
        {
            ApiRequest(FormatUrl(businessId, financialYearEnding, employeeId, employingEntityId, locationId), Method.POST);
        }
        public void Unpublish(int businessId, int financialYearEnding, int? employeeId = null, int? employingEntityId = null, int? locationId = null)
        {
            ApiRequest(FormatUrl(businessId, financialYearEnding, employeeId, employingEntityId, locationId), Method.DELETE);
        }
    }
}