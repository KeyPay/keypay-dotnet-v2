using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.TieredLeaveAllowance;

namespace KeyPayV2.Sg.Functions
{
    public class TieredLeaveAllowanceFunction : BaseFunction
    {
        public TieredLeaveAllowanceFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Tiered Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the Tiered Leave Allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<TieredLeaveAllowanceTemplateApiModel> ListTieredLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<TieredLeaveAllowanceTemplateApiModel>>($"/business/{businessId}/tieredleaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new Tiered Leave Allowance template for the business.
        /// </remarks>
        public TieredLeaveAllowanceTemplateApiModel CreateTieredLeaveAllowanceTemplate(int businessId, TieredLeaveAllowanceTemplateApiModel tieredLeaveAllowanceTemplate)
        {
            return ApiRequest<TieredLeaveAllowanceTemplateApiModel,TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate", tieredLeaveAllowanceTemplate, Method.POST);
        }

        /// <summary>
        /// Get Tiered Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public TieredLeaveAllowanceTemplateApiModel GetTieredLeaveAllowanceTemplateById(int businessId, int id)
        {
            return ApiRequest<TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate/{id}");
        }

        /// <summary>
        /// Update Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public TieredLeaveAllowanceTemplateApiModel UpdateTieredLeaveAllowanceTemplate(int businessId, int id, TieredLeaveAllowanceTemplateApiModel tieredLeaveAllowanceTemplate)
        {
            return ApiRequest<TieredLeaveAllowanceTemplateApiModel,TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate/{id}", tieredLeaveAllowanceTemplate, Method.PUT);
        }

        /// <summary>
        /// Delete Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Deletes the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public void DeleteTieredLeaveAllowanceTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/tieredleaveallowancetemplate/{id}", Method.DELETE);
        }
    }
}
