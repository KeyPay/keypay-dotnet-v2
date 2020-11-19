using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PayRateTemplate;

namespace KeyPayV2.Uk.Functions
{
    public class PayRateTemplateFunction : BaseFunction
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
            return ApiRequest<List<PayRateTemplateExportModel>>($"/business/{businessId}/payratetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Creates a new pay rate template for the business.
        /// </remarks>
        public PayRateTemplateExportModel CreatePayRateTemplate(int businessId, PayRateTemplateExportModel payRateTemplate)
        {
            return ApiRequest<PayRateTemplateExportModel,PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate", payRateTemplate, Method.POST);
        }

        /// <summary>
        /// Get Pay Rate Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay rate template with the specified ID.
        /// </remarks>
        public PayRateTemplateExportModel GetPayRateTemplateById(int businessId, int id)
        {
            return ApiRequest<PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate/{id}");
        }

        /// <summary>
        /// Update Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Updates the pay rate template with the specified ID.
        /// </remarks>
        public PayRateTemplateExportModel UpdatePayRateTemplate(int businessId, int id, PayRateTemplateExportModel payRateTemplate)
        {
            return ApiRequest<PayRateTemplateExportModel,PayRateTemplateExportModel>($"/business/{businessId}/payratetemplate/{id}", payRateTemplate, Method.PUT);
        }

        /// <summary>
        /// Delete Pay Rate Template
        /// </summary>
        /// <remarks>
        /// Deletes the pay rate template with the specified ID.
        /// </remarks>
        public void DeletePayRateTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/payratetemplate/{id}", Method.DELETE);
        }
    }
}
