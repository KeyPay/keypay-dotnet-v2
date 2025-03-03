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
using KeyPayV2.Uk.Models.PayeScheme;

namespace KeyPayV2.Uk.Functions
{
    public interface IPayeSchemeFunction
    {
        List<UkPayeSchemeResponseModel> ListsThePayeSchemes(int businessId);
        Task<List<UkPayeSchemeResponseModel>> ListsThePayeSchemesAsync(int businessId, CancellationToken cancellationToken = default);
    }
    public class PayeSchemeFunction : BaseFunction, IPayeSchemeFunction
    {
        public PayeSchemeFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Lists the PAYE Schemes
        /// </summary>
        /// <remarks>
        /// Lists the PAYE Schemes
        /// </remarks>
        public List<UkPayeSchemeResponseModel> ListsThePayeSchemes(int businessId)
        {
            return ApiRequest<List<UkPayeSchemeResponseModel>>($"/business/{businessId}/payeschemes", Method.Get);
        }

        /// <summary>
        /// Lists the PAYE Schemes
        /// </summary>
        /// <remarks>
        /// Lists the PAYE Schemes
        /// </remarks>
        public Task<List<UkPayeSchemeResponseModel>> ListsThePayeSchemesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayeSchemeResponseModel>>($"/business/{businessId}/payeschemes", Method.Get, cancellationToken);
        }
    }
}
