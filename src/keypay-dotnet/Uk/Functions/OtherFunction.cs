using System;
using System.Collections.Generic;
using System.Linq;
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
        void BulkActionHmrc_HmrcSettings(int businessId, BulkActionRequest model);
        Task BulkActionHmrc_HmrcSettingsAsync(int businessId, BulkActionRequest model, CancellationToken cancellationToken = default);
        void BulkActionHmrc_Metadata(int businessId, BulkActionMetadataRequest model);
        Task BulkActionHmrc_MetadataAsync(int businessId, BulkActionMetadataRequest model, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        public void BulkActionHmrc_HmrcSettings(int businessId, BulkActionRequest model)
        {
            ApiRequest($"/admin/business/{businessId}/bulkaction/hmrc", model, Method.Post);
        }

        public Task BulkActionHmrc_HmrcSettingsAsync(int businessId, BulkActionRequest model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/business/{businessId}/bulkaction/hmrc", model, Method.Post, cancellationToken);
        }

        public void BulkActionHmrc_Metadata(int businessId, BulkActionMetadataRequest model)
        {
            ApiRequest($"/admin/business/{businessId}/bulkaction/hmrc/metadata", model, Method.Post);
        }

        public Task BulkActionHmrc_MetadataAsync(int businessId, BulkActionMetadataRequest model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/business/{businessId}/bulkaction/hmrc/metadata", model, Method.Post, cancellationToken);
        }

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
    }
}
