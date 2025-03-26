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
        List<PaygPaymentSummaryModel> AuPaymentSummary_Get(int businessId, int financialYearEnding, ODataQuery oDataQuery = null);
        Task<List<PaygPaymentSummaryModel>> AuPaymentSummary_GetAsync(int businessId, int financialYearEnding, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void AuPaymentSummary_Post(int businessId, int financialYearEnding);
        Task AuPaymentSummary_PostAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default);
        void AuPaymentSummary_Post(int businessId, int financialYearEnding, AuPaymentSummary_PostQueryModel request);
        Task AuPaymentSummary_PostAsync(int businessId, int financialYearEnding, AuPaymentSummary_PostQueryModel request, CancellationToken cancellationToken = default);
        void AuPaymentSummary_Delete(int businessId, int financialYearEnding);
        Task AuPaymentSummary_DeleteAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default);
        void AuPaymentSummary_Delete(int businessId, int financialYearEnding, AuPaymentSummary_DeleteQueryModel request);
        Task AuPaymentSummary_DeleteAsync(int businessId, int financialYearEnding, AuPaymentSummary_DeleteQueryModel request, CancellationToken cancellationToken = default);
        PaygPaymentSummaryModel AuPaymentSummary_Put(int businessId, int financialYearEnding);
        Task<PaygPaymentSummaryModel> AuPaymentSummary_PutAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default);
        PaygPaymentSummaryModel AuPaymentSummary_Put(int businessId, int financialYearEnding, AuPaymentSummary_PutQueryModel request);
        Task<PaygPaymentSummaryModel> AuPaymentSummary_PutAsync(int businessId, int financialYearEnding, AuPaymentSummary_PutQueryModel request, CancellationToken cancellationToken = default);
    }
    public class PaymentSummaryFunction : BaseFunction, IPaymentSummaryFunction
    {
        public PaymentSummaryFunction(ApiRequestExecutor api) : base(api) {}

        /// <remarks>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PaygPaymentSummaryModel> AuPaymentSummary_Get(int businessId, int financialYearEnding, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PaygPaymentSummaryModel>>($"/business/{businessId}/paymentsummary/{financialYearEnding}{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <remarks>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PaygPaymentSummaryModel>> AuPaymentSummary_GetAsync(int businessId, int financialYearEnding, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PaygPaymentSummaryModel>>($"/business/{businessId}/paymentsummary/{financialYearEnding}{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        public void AuPaymentSummary_Post(int businessId, int financialYearEnding)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Post);
        }

        public Task AuPaymentSummary_PostAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Post, cancellationToken);
        }

        public void AuPaymentSummary_Post(int businessId, int financialYearEnding, AuPaymentSummary_PostQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Post);
        }

        public Task AuPaymentSummary_PostAsync(int businessId, int financialYearEnding, AuPaymentSummary_PostQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Post, cancellationToken);
        }

        public void AuPaymentSummary_Delete(int businessId, int financialYearEnding)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Delete);
        }

        public Task AuPaymentSummary_DeleteAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Delete, cancellationToken);
        }

        public void AuPaymentSummary_Delete(int businessId, int financialYearEnding, AuPaymentSummary_DeleteQueryModel request)
        {
            ApiRequest($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Delete);
        }

        public Task AuPaymentSummary_DeleteAsync(int businessId, int financialYearEnding, AuPaymentSummary_DeleteQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Delete, cancellationToken);
        }

        public PaygPaymentSummaryModel AuPaymentSummary_Put(int businessId, int financialYearEnding)
        {
            return ApiRequest<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Put);
        }

        public Task<PaygPaymentSummaryModel> AuPaymentSummary_PutAsync(int businessId, int financialYearEnding, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}", Method.Put, cancellationToken);
        }

        public PaygPaymentSummaryModel AuPaymentSummary_Put(int businessId, int financialYearEnding, AuPaymentSummary_PutQueryModel request)
        {
            return ApiRequest<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Put);
        }

        public Task<PaygPaymentSummaryModel> AuPaymentSummary_PutAsync(int businessId, int financialYearEnding, AuPaymentSummary_PutQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PaygPaymentSummaryModel>($"/business/{businessId}/paymentsummary/{financialYearEnding}?employeeId={request.EmployeeId}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Put, cancellationToken);
        }
    }
}
