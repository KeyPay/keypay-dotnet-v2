using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Other;

namespace KeyPayV2.Uk.Functions
{
    public interface IOtherFunction
    {
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        void MockedLodgedPayRunTest_CreateMockedLodgedPayRun(int businessId, int payRunId);
        Task MockedLodgedPayRunTest_CreateMockedLodgedPayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        Boolean UkBusinessPensionTest_SetProviderId(int businessId, int pensionSchemeId, string providerId);
        Task<Boolean> UkBusinessPensionTest_SetProviderIdAsync(int businessId, int pensionSchemeId, string providerId, CancellationToken cancellationToken = default);
        List<P11ReportDataModel> UkGetP11ReportDataTest_Generate(int businessId, P11GenerationModel request);
        Task<List<P11ReportDataModel>> UkGetP11ReportDataTest_GenerateAsync(int businessId, P11GenerationModel request, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}", Method.Get);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}", Method.Get, cancellationToken);
        }

        public void MockedLodgedPayRunTest_CreateMockedLodgedPayRun(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/test/payrun/{payRunId}/createmockedlodgedpayrun", Method.Post);
        }

        public Task MockedLodgedPayRunTest_CreateMockedLodgedPayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/test/payrun/{payRunId}/createmockedlodgedpayrun", Method.Post, cancellationToken);
        }

        public Boolean UkBusinessPensionTest_SetProviderId(int businessId, int pensionSchemeId, string providerId)
        {
            return ApiRequest<Boolean>($"/business/{businessId}/test/pension/pensionscheme/{pensionSchemeId}/setproviderid/{providerId}", Method.Post);
        }

        public Task<Boolean> UkBusinessPensionTest_SetProviderIdAsync(int businessId, int pensionSchemeId, string providerId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Boolean>($"/business/{businessId}/test/pension/pensionscheme/{pensionSchemeId}/setproviderid/{providerId}", Method.Post, cancellationToken);
        }

        public List<P11ReportDataModel> UkGetP11ReportDataTest_Generate(int businessId, P11GenerationModel request)
        {
            return ApiRequest<List<P11ReportDataModel>,P11GenerationModel>($"/business/{businessId}/test/report/p11tests/Generate", request, Method.Post);
        }

        public Task<List<P11ReportDataModel>> UkGetP11ReportDataTest_GenerateAsync(int businessId, P11GenerationModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<P11ReportDataModel>,P11GenerationModel>($"/business/{businessId}/test/report/p11tests/Generate", request, Method.Post, cancellationToken);
        }
    }
}
