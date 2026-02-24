using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Reseller;

namespace KeyPayV2.My.Functions
{
    public interface IResellerFunction
    {
        List<ResellerModel> ListResellers();
        Task<List<ResellerModel>> ListResellersAsync(CancellationToken cancellationToken = default);
        ResellerModel GetResellerById(int id);
        Task<ResellerModel> GetResellerByIdAsync(int id, CancellationToken cancellationToken = default);
    }
    public class ResellerFunction : BaseFunction, IResellerFunction
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
            return ApiRequest<List<ResellerModel>>($"/reseller", Method.Get);
        }

        /// <summary>
        /// List Resellers
        /// </summary>
        /// <remarks>
        /// Lists all the resellers to which you have access.
        /// </remarks>
        public Task<List<ResellerModel>> ListResellersAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ResellerModel>>($"/reseller", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Reseller by ID
        /// </summary>
        /// <remarks>
        /// Gets the resellers with the specified ID.
        /// </remarks>
        public ResellerModel GetResellerById(int id)
        {
            return ApiRequest<ResellerModel>($"/reseller/{id}", Method.Get);
        }

        /// <summary>
        /// Get Reseller by ID
        /// </summary>
        /// <remarks>
        /// Gets the resellers with the specified ID.
        /// </remarks>
        public Task<ResellerModel> GetResellerByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ResellerModel>($"/reseller/{id}", Method.Get, cancellationToken);
        }
    }
}
