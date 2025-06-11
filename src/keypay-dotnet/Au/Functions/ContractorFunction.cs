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
using KeyPayV2.Au.Models.Contractor;

namespace KeyPayV2.Au.Functions
{
    public interface IContractorFunction
    {
        List<ContractorSimpleModel> ListContractors(int businessId);
        Task<List<ContractorSimpleModel>> ListContractorsAsync(int businessId, CancellationToken cancellationToken = default);
    }
    public class ContractorFunction : BaseFunction, IContractorFunction
    {
        public ContractorFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List contractors
        /// </summary>
        /// <remarks>
        /// List active contractors for the business.
        /// </remarks>
        public List<ContractorSimpleModel> ListContractors(int businessId)
        {
            return ApiRequest<List<ContractorSimpleModel>>($"/business/{businessId}/contractor", Method.Get);
        }

        /// <summary>
        /// List contractors
        /// </summary>
        /// <remarks>
        /// List active contractors for the business.
        /// </remarks>
        public Task<List<ContractorSimpleModel>> ListContractorsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ContractorSimpleModel>>($"/business/{businessId}/contractor", Method.Get, cancellationToken);
        }
    }
}
