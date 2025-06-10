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
using KeyPayV2.Uk.Models.Subcontractor;

namespace KeyPayV2.Uk.Functions
{
    public interface ISubcontractorFunction
    {
        UkSubcontractorReadModel CreateSubcontractor(int businessId, UkSubcontractorCreateModel createModel);
        Task<UkSubcontractorReadModel> CreateSubcontractorAsync(int businessId, UkSubcontractorCreateModel createModel, CancellationToken cancellationToken = default);
        UkSubcontractorPaymentDetailsModel SaveSubcontractorPaymentDetails(int businessId, int subcontractorId, UkSaveSubcontractorPaymentDetailsModel model);
        Task<UkSubcontractorPaymentDetailsModel> SaveSubcontractorPaymentDetailsAsync(int businessId, int subcontractorId, UkSaveSubcontractorPaymentDetailsModel model, CancellationToken cancellationToken = default);
    }
    public class SubcontractorFunction : BaseFunction, ISubcontractorFunction
    {
        public SubcontractorFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Create subcontractor
        /// </summary>
        /// <remarks>
        /// Creates a new subcontractor
        /// </remarks>
        public UkSubcontractorReadModel CreateSubcontractor(int businessId, UkSubcontractorCreateModel createModel)
        {
            return ApiRequest<UkSubcontractorReadModel,UkSubcontractorCreateModel>($"/business/{businessId}/subcontractor", createModel, Method.Post);
        }

        /// <summary>
        /// Create subcontractor
        /// </summary>
        /// <remarks>
        /// Creates a new subcontractor
        /// </remarks>
        public Task<UkSubcontractorReadModel> CreateSubcontractorAsync(int businessId, UkSubcontractorCreateModel createModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSubcontractorReadModel,UkSubcontractorCreateModel>($"/business/{businessId}/subcontractor", createModel, Method.Post, cancellationToken);
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
