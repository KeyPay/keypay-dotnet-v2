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
        public UkSubcontractorReadModel CreateSubcontractor(int businessId, UkSubcontractorCreateModel model)
        {
            return ApiRequest<UkSubcontractorReadModel,UkSubcontractorCreateModel>($"/business/{businessId}/subcontractor", model, Method.POST);
        }

        /// <summary>
        /// Create subcontractor
        /// </summary>
        /// <remarks>
        /// Creates a new subcontractor
        /// </remarks>
        public Task<UkSubcontractorReadModel> CreateSubcontractorAsync(int businessId, UkSubcontractorCreateModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSubcontractorReadModel,UkSubcontractorCreateModel>($"/business/{businessId}/subcontractor", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Save subcontractor payment details
        /// </summary>
        /// <remarks>
        /// Creates or updates payment details for a subcontractor
        /// </remarks>
        public UkSubcontractorPaymentDetailsModel SaveSubcontractorPaymentDetails(int businessId, int subcontractorId, UkSaveSubcontractorPaymentDetailsModel model)
        {
            return ApiRequest<UkSubcontractorPaymentDetailsModel,UkSaveSubcontractorPaymentDetailsModel>($"/business/{businessId}/subcontractor/{subcontractorId}/paymentdetails", model, Method.POST);
        }

        /// <summary>
        /// Save subcontractor payment details
        /// </summary>
        /// <remarks>
        /// Creates or updates payment details for a subcontractor
        /// </remarks>
        public Task<UkSubcontractorPaymentDetailsModel> SaveSubcontractorPaymentDetailsAsync(int businessId, int subcontractorId, UkSaveSubcontractorPaymentDetailsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSubcontractorPaymentDetailsModel,UkSaveSubcontractorPaymentDetailsModel>($"/business/{businessId}/subcontractor/{subcontractorId}/paymentdetails", model, Method.POST, cancellationToken);
        }
    }
}
