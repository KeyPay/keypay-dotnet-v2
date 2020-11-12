using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Reseller;

namespace KeyPayV2.Uk.Functions
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
            return ApiRequest<List<ResellerModel>>($"/reseller");
        }

        /// <summary>
        /// Get Reseller by ID
        /// </summary>
        /// <remarks>
        /// Gets the resellers with the specified ID.
        /// </remarks>
        public ResellerModel GetResellerById(int id)
        {
            return ApiRequest<ResellerModel>($"/reseller/{id}");
        }
    }
}
