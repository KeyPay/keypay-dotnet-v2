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
using KeyPayV2.Au.Models.TieredLongServiceLeave;

namespace KeyPayV2.Au.Functions
{
    public interface ITieredLongServiceLeaveFunction
    {
        List<AuTieredLongServiceLeaveTemplateApiModel> ListTieredLongServiceLeaveTemplates(int businessId);
        Task<List<AuTieredLongServiceLeaveTemplateApiModel>> ListTieredLongServiceLeaveTemplatesAsync(int businessId, CancellationToken cancellationToken = default);
        AuTieredLongServiceLeaveTemplateApiModel GetTieredLongServiceLeaveTemplateById(int businessId, int id);
        Task<AuTieredLongServiceLeaveTemplateApiModel> GetTieredLongServiceLeaveTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class TieredLongServiceLeaveFunction : BaseFunction, ITieredLongServiceLeaveFunction
    {
        public TieredLongServiceLeaveFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Tiered Long Service Leave Templates
        /// </summary>
        /// <remarks>
        /// Returns the list of Tiered Long Service Leave templates (basic details) for the business.
        /// </remarks>
        public List<AuTieredLongServiceLeaveTemplateApiModel> ListTieredLongServiceLeaveTemplates(int businessId)
        {
            return ApiRequest<List<AuTieredLongServiceLeaveTemplateApiModel>>($"/business/{businessId}/tieredlongserviceleavetemplate", Method.Get);
        }

        /// <summary>
        /// List Tiered Long Service Leave Templates
        /// </summary>
        /// <remarks>
        /// Returns the list of Tiered Long Service Leave templates (basic details) for the business.
        /// </remarks>
        public Task<List<AuTieredLongServiceLeaveTemplateApiModel>> ListTieredLongServiceLeaveTemplatesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuTieredLongServiceLeaveTemplateApiModel>>($"/business/{businessId}/tieredlongserviceleavetemplate", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Tiered Long Service Leave Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the tiered long service leave template with the specified ID.
        /// </remarks>
        public AuTieredLongServiceLeaveTemplateApiModel GetTieredLongServiceLeaveTemplateById(int businessId, int id)
        {
            return ApiRequest<AuTieredLongServiceLeaveTemplateApiModel>($"/business/{businessId}/tieredlongserviceleavetemplate/{id}", Method.Get);
        }

        /// <summary>
        /// Get Tiered Long Service Leave Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the tiered long service leave template with the specified ID.
        /// </remarks>
        public Task<AuTieredLongServiceLeaveTemplateApiModel> GetTieredLongServiceLeaveTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuTieredLongServiceLeaveTemplateApiModel>($"/business/{businessId}/tieredlongserviceleavetemplate/{id}", Method.Get, cancellationToken);
        }
    }
}
