using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.PaymentSummary;

namespace KeyPayV2.Au.Functions
{
    public interface IPaymentSummaryFunction
    {
        List<PaygPaymentSummaryModel> ListPaymentSummaries(int businessId, int financialYearEnding, ODataQuery oDataQuery = null);
        Task<List<PaygPaymentSummaryModel>> ListPaymentSummariesAsync(int businessId, int financialYearEnding, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        PaygPaymentSummaryModel GeneratePaymentSummaries(int businessId, int financialYearEnding);
        Task<PaygPaymentSummaryModel> GeneratePaymentSummariesAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default);
        PaygPaymentSummaryModel GeneratePaymentSummaries(int businessId, int financialYearEnding, GeneratePaymentSummariesQueryModel request);
        Task<PaygPaymentSummaryModel> GeneratePaymentSummariesAsync(int businessId, int financialYearEnding, GeneratePaymentSummariesQueryModel request, CancellationToken cancellationToken = default);
        void PublishPaymentSummaries(int businessId, int financialYearEnding);
        Task PublishPaymentSummariesAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default);
        void PublishPaymentSummaries(int businessId, int financialYearEnding, PublishPaymentSummariesQueryModel request);
        Task PublishPaymentSummariesAsync(int businessId, int financialYearEnding, PublishPaymentSummariesQueryModel request, CancellationToken cancellationToken = default);
        void UnpublishPaymentSummaries(int businessId, int financialYearEnding);
        Task UnpublishPaymentSummariesAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default);
        void UnpublishPaymentSummaries(int businessId, int financialYearEnding, UnpublishPaymentSummariesQueryModel request);
        Task UnpublishPaymentSummariesAsync(int businessId, int financialYearEnding, UnpublishPaymentSummariesQueryModel request, CancellationToken cancellationToken = default);
    }
    public class PaymentSummaryFunction : BaseFunction, IPaymentSummaryFunction
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
            return ApiRequest<List<PaygPaymentSummaryModel>>($"/business/{businessId}/paymentsummary/{financialYearEnding}{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Payment Summaries
        /// </summary>
        /// <remarks>
        /// Lists all the payment summaries for the specified financial year.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PaygPaymentSummaryModel>> ListPaymentSummariesAsync(int businessId, int financialYearEnding, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PaygPaymentSummaryModel>>($"/business/{businessId}/paymentsummary/{financialYearEnding}{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Generate Payment Summaries
        /// </summary>
        /// <remarks>
        /// Generates (or regenerates) payment summaries for the specified financial year/business. Only unpublished payment summaries will be regenerated.
        /// </remarks>
        public PaygPaymentSummaryModel GeneratePaymentSummaries(int businessId, int financialYearEnding)
        {
            return ApiRequest<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Put);
        }

        /// <summary>
        /// Generate Payment Summaries
        /// </summary>
        /// <remarks>
        /// Generates (or regenerates) payment summaries for the specified financial year/business. Only unpublished payment summaries will be regenerated.
        /// </remarks>
        public Task<PaygPaymentSummaryModel> GeneratePaymentSummariesAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Generate Payment Summaries
        /// </summary>
        /// <remarks>
        /// Generates (or regenerates) payment summaries for the specified financial year/business. Only unpublished payment summaries will be regenerated.
        /// </remarks>
        public PaygPaymentSummaryModel GeneratePaymentSummaries(int businessId, int financialYearEnding, GeneratePaymentSummariesQueryModel request)
        {
            return ApiRequest<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Put);
        }

        /// <summary>
        /// Generate Payment Summaries
        /// </summary>
        /// <remarks>
        /// Generates (or regenerates) payment summaries for the specified financial year/business. Only unpublished payment summaries will be regenerated.
        /// </remarks>
        public Task<PaygPaymentSummaryModel> GeneratePaymentSummariesAsync(int businessId, int financialYearEnding, GeneratePaymentSummariesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Publish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Publish payment summaries for the specified financial year.
        /// </remarks>
        public void PublishPaymentSummaries(int businessId, int financialYearEnding)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Post);
        }

        /// <summary>
        /// Publish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Publish payment summaries for the specified financial year.
        /// </remarks>
        public Task PublishPaymentSummariesAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Publish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Publish payment summaries for the specified financial year.
        /// </remarks>
        public void PublishPaymentSummaries(int businessId, int financialYearEnding, PublishPaymentSummariesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Post);
        }

        /// <summary>
        /// Publish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Publish payment summaries for the specified financial year.
        /// </remarks>
        public Task PublishPaymentSummariesAsync(int businessId, int financialYearEnding, PublishPaymentSummariesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Unpublish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Unpublish payment summaries for the specified financial year.
        /// </remarks>
        public void UnpublishPaymentSummaries(int businessId, int financialYearEnding)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Delete);
        }

        /// <summary>
        /// Unpublish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Unpublish payment summaries for the specified financial year.
        /// </remarks>
        public Task UnpublishPaymentSummariesAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Unpublish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Unpublish payment summaries for the specified financial year.
        /// </remarks>
        public void UnpublishPaymentSummaries(int businessId, int financialYearEnding, UnpublishPaymentSummariesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Delete);
        }

        /// <summary>
        /// Unpublish Payment Summaries
        /// </summary>
        /// <remarks>
        /// Unpublish payment summaries for the specified financial year.
        /// </remarks>
        public Task UnpublishPaymentSummariesAsync(int businessId, int financialYearEnding, UnpublishPaymentSummariesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Delete, cancellationToken);
        }
    }
}
