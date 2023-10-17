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
using KeyPayV2.Uk.Models.PayRateTemplate;

namespace KeyPayV2.Uk.Functions
{
    public interface IPayRateTemplateFunction
    {
        List<PayRateTemplateExportModel> ListPayRateTemplates(int businessId, ODataQuery oDataQuery = null);
        Task<List<PayRateTemplateExportModel>> ListPayRateTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        PayRateTemplateExportModel CreatePayRateTemplate(int businessId, PayRateTemplateExportModel payRateTemplate);
        Task<PayRateTemplateExportModel> CreatePayRateTemplateAsync(int businessId, PayRateTemplateExportModel payRateTemplate, CancellationToken cancellationToken = default);
        PayRateTemplateExportModel GetPayRateTemplateById(int businessId, int id);
        Task<PayRateTemplateExportModel> GetPayRateTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        PayRateTemplateExportModel UpdatePayRateTemplate(int businessId, int id, PayRateTemplateExportModel payRateTemplate);
        Task<PayRateTemplateExportModel> UpdatePayRateTemplateAsync(int businessId, int id, PayRateTemplateExportModel payRateTemplate, CancellationToken cancellationToken = default);
        void DeletePayRateTemplate(int businessId, int id);
        Task DeletePayRateTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class PayRateTemplateFunction : BaseFunction, IPayRateTemplateFunction
    {
        public PayRateTemplateFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Rate Templates
        /// </summary>
        /// <remarks>
        /// Lists all the pay rate templates for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PayRateTemplateExportModel> ListPayRateTemplates(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PayRateTemplateExportModel>>($"/business/{businessId}/payratetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Rate Templates
        /// </summary>
        /// <remarks>
        /// Lists all the pay rate templates for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PayRateTemplateExportModel>> ListPayRateTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRateTemplateExportModel>>($"/business/{businessId}/payratetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Creates a new pay rate template for the business.
        /// </remarks>
        public PayRateTemplateExportModel CreatePayRateTemplate(int businessId, PayRateTemplateExportModel payRateTemplate)
        {
            return ApiRequest<PayRateTemplateExportModel,PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate", payRateTemplate, Method.Post);
        }

        /// <summary>
        /// Create Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Creates a new pay rate template for the business.
        /// </remarks>
        public Task<PayRateTemplateExportModel> CreatePayRateTemplateAsync(int businessId, PayRateTemplateExportModel payRateTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRateTemplateExportModel,PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate", payRateTemplate, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Rate Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay rate template with the specified ID.
        /// </remarks>
        public PayRateTemplateExportModel GetPayRateTemplateById(int businessId, int id)
        {
            return ApiRequest<PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Rate Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay rate template with the specified ID.
        /// </remarks>
        public Task<PayRateTemplateExportModel> GetPayRateTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Updates the pay rate template with the specified ID.
        /// </remarks>
        public PayRateTemplateExportModel UpdatePayRateTemplate(int businessId, int id, PayRateTemplateExportModel payRateTemplate)
        {
            return ApiRequest<PayRateTemplateExportModel,PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate/{id}", payRateTemplate, Method.Put);
        }

        /// <summary>
        /// Update Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Updates the pay rate template with the specified ID.
        /// </remarks>
        public Task<PayRateTemplateExportModel> UpdatePayRateTemplateAsync(int businessId, int id, PayRateTemplateExportModel payRateTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRateTemplateExportModel,PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate/{id}", payRateTemplate, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Deletes the pay rate template with the specified ID.
        /// </remarks>
        public void DeletePayRateTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/payratetemplate/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Deletes the pay rate template with the specified ID.
        /// </remarks>
        public Task DeletePayRateTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payratetemplate/{id}", Method.Delete, cancellationToken);
        }
    }
}
