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
using KeyPayV2.Uk.Models.Subcontractor;

namespace KeyPayV2.Uk.Functions
{
    public class SubcontractorFunction : BaseFunction
    {
        public SubcontractorFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Create subcontractor
        /// </summary>
        /// <remarks>
        /// Creates a new subcontractor
        /// </remarks>
        public void CreateSubcontractor(int businessId, UkSubcontractorCreateModel createModel)
        {
            ApiRequest($"/business/{businessId}/subcontractor", createModel, Method.Post);
        }

        /// <summary>
        /// Create subcontractor
        /// </summary>
        /// <remarks>
        /// Creates a new subcontractor
        /// </remarks>
        public Task CreateSubcontractorAsync(int businessId, UkSubcontractorCreateModel createModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/subcontractor", createModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Save subcontractor payment details
        /// </summary>
        /// <remarks>
        /// Creates or updates payment details for a subcontractor
        /// </remarks>
        public UkSubcontractorPaymentDetailsModel SaveSubcontractorPaymentDetails(int businessId, int subcontractorId, UkSaveSubcontractorPaymentDetailsModel model)
        {
            return ApiRequest<UkSubcontractorPaymentDetailsModel,UkSaveSubcontractorPaymentDetailsModel>($"/business/{businessId}/subcontractor/{subcontractorId}/paymentdetails", model, Method.Post);
        }

        /// <summary>
        /// Save subcontractor payment details
        /// </summary>
        /// <remarks>
        /// Creates or updates payment details for a subcontractor
        /// </remarks>
        public Task<UkSubcontractorPaymentDetailsModel> SaveSubcontractorPaymentDetailsAsync(int businessId, int subcontractorId, UkSaveSubcontractorPaymentDetailsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSubcontractorPaymentDetailsModel,UkSaveSubcontractorPaymentDetailsModel>($"/business/{businessId}/subcontractor/{subcontractorId}/paymentdetails", model, Method.Post, cancellationToken);
        }
    }
}
