using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PaymentSummary;

namespace KeyPayV2.Uk.Functions
{
    public class PaymentSummaryFunction : BaseFunction
    {
        public PaymentSummaryFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Payment Summaries
        /// </summary>
        /// <remarks>
        /// Lists all the payment summaries for the specified financial year.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PaygPaymentSummaryModel> ListPaymentSummaries(int businessId, int financialYearEnding, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PaygPaymentSummaryModel>>($"/business/{businessId}/paymentsummary/{financialYearEnding}{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Generate Payment Summaries
        /// </summary>
        /// <remarks>
        /// Generates (or regenerates) payment summaries for the specified financial year/business. Only unpublished payment summaries will be regenerated.
        /// </remarks>
        public void GeneratePaymentSummaries(int businessId, int financialYearEnding, GeneratePaymentSummariesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.PUT);
        }

        /// <summary>
        /// Publish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Publish payment summaries for the specified financial year.
        /// </remarks>
        public void PublishPaymentSummaries(int businessId, int financialYearEnding, PublishPaymentSummariesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.POST);
        }

        /// <summary>
        /// Unpublish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Unpublish payment summaries for the specified financial year.
        /// </remarks>
        public void UnpublishPaymentSummaries(int businessId, int financialYearEnding, UnpublishPaymentSummariesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.DELETE);
        }
    }
}
