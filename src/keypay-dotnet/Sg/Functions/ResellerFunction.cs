using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.Reseller;

namespace KeyPayV2.Sg.Functions
{
    public class ResellerFunction : BaseFunction
    {
        public ResellerFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Resellers
        /// </summary>
        /// <remarks>
        /// Lists all the resellers to which you have access.
        /// </remarks>
        public List<ResellerModel> ListResellers()
        {
            return ApiRequest<List<ResellerModel>>($"/reseller", Method.GET);
        }

        /// <summary>
        /// List Resellers
        /// </summary>
        /// <remarks>
        /// Lists all the resellers to which you have access.
        /// </remarks>
        public Task<List<ResellerModel>> ListResellersAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ResellerModel>>($"/reseller", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Reseller by ID
        /// </summary>
        /// <remarks>
        /// Gets the resellers with the specified ID.
        /// </remarks>
        public ResellerModel GetResellerById(int id)
        {
            return ApiRequest<ResellerModel>($"/reseller/{id}", Method.GET);
        }

        /// <summary>
        /// Get Reseller by ID
        /// </summary>
        /// <remarks>
        /// Gets the resellers with the specified ID.
        /// </remarks>
        public Task<ResellerModel> GetResellerByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ResellerModel>($"/reseller/{id}", Method.GET, cancellationToken);
        }
    }
}
