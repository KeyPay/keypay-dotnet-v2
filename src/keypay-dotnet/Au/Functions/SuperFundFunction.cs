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
using KeyPayV2.Au.Models.SuperFund;

namespace KeyPayV2.Au.Functions
{
    public interface ISuperFundFunction
    {
        List<SelfManagedSuperFundModel> ListSelfManagedSuperFunds(int businessId, ODataQuery oDataQuery = null);
        Task<List<SelfManagedSuperFundModel>> ListSelfManagedSuperFundsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateSelfManagedSuperFund(int businessId, SelfManagedSuperFundModel fund);
        Task CreateSelfManagedSuperFundAsync(int businessId, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default);
        SelfManagedSuperFundModel GetSelfManagedSuperFundById(int businessId, int id);
        Task<SelfManagedSuperFundModel> GetSelfManagedSuperFundByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateSelfManagedSuperFund(int businessId, int id, SelfManagedSuperFundModel fund);
        Task UpdateSelfManagedSuperFundAsync(int businessId, int id, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default);
        List<AuSmsfElectronicServiceAddressModel> ListElectronicServiceAddresses(int businessId);
        Task<List<AuSmsfElectronicServiceAddressModel>> ListElectronicServiceAddressesAsync(int businessId, CancellationToken cancellationToken = default);
        List<SuperProductEditModel> SearchSuperFunds(int businessId, SearchSuperFundsQueryModel request);
        Task<List<SuperProductEditModel>> SearchSuperFundsAsync(int businessId, SearchSuperFundsQueryModel request, CancellationToken cancellationToken = default);
    }
    public class SuperFundFunction : BaseFunction, ISuperFundFunction
    {
        public SuperFundFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Self Managed Super Funds
        /// </summary>
        /// <remarks>
        /// Lists all the self managed super funds for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<SelfManagedSuperFundModel> ListSelfManagedSuperFunds(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SelfManagedSuperFundModel>>($"/business/{businessId}/selfmanagedsuperfund{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Self Managed Super Funds
        /// </summary>
        /// <remarks>
        /// Lists all the self managed super funds for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SelfManagedSuperFundModel>> ListSelfManagedSuperFundsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SelfManagedSuperFundModel>>($"/business/{businessId}/selfmanagedsuperfund{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new self managed super fund for the business.
        /// </remarks>
        public void CreateSelfManagedSuperFund(int businessId, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/selfmanagedsuperfund", fund, Method.Post);
        }

        /// <summary>
        /// Create Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new self managed super fund for the business.
        /// </remarks>
        public Task CreateSelfManagedSuperFundAsync(int businessId, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/selfmanagedsuperfund", fund, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Self Managed Super Fund by ID
        /// </summary>
        /// <remarks>
        /// Gets the self managed super fund with the specified ID.
        /// </remarks>
        public SelfManagedSuperFundModel GetSelfManagedSuperFundById(int businessId, int id)
        {
            return ApiRequest<SelfManagedSuperFundModel>($"/business/{businessId}/selfmanagedsuperfund/{id}", Method.Get);
        }

        /// <summary>
        /// Get Self Managed Super Fund by ID
        /// </summary>
        /// <remarks>
        /// Gets the self managed super fund with the specified ID.
        /// </remarks>
        public Task<SelfManagedSuperFundModel> GetSelfManagedSuperFundByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SelfManagedSuperFundModel>($"/business/{businessId}/selfmanagedsuperfund/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the Self Managed Super Fund by the specified ID
        /// </remarks>
        public void UpdateSelfManagedSuperFund(int businessId, int id, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/selfmanagedsuperfund/{id}", fund, Method.Put);
        }

        /// <summary>
        /// Update Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the Self Managed Super Fund by the specified ID
        /// </remarks>
        public Task UpdateSelfManagedSuperFundAsync(int businessId, int id, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/selfmanagedsuperfund/{id}", fund, Method.Put, cancellationToken);
        }

        /// <summary>
        /// List Electronic Service Addresses
        /// </summary>
        /// <remarks>
        /// Electronic Service Addresses for Self Managed Super Funds
        /// </remarks>
        public List<AuSmsfElectronicServiceAddressModel> ListElectronicServiceAddresses(int businessId)
        {
            return ApiRequest<List<AuSmsfElectronicServiceAddressModel>>($"/business/{businessId}/superfund/electronicserviceaddress", Method.Get);
        }

        /// <summary>
        /// List Electronic Service Addresses
        /// </summary>
        /// <remarks>
        /// Electronic Service Addresses for Self Managed Super Funds
        /// </remarks>
        public Task<List<AuSmsfElectronicServiceAddressModel>> ListElectronicServiceAddressesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuSmsfElectronicServiceAddressModel>>($"/business/{businessId}/superfund/electronicserviceaddress", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Search Super Funds
        /// </summary>
        /// <remarks>
        /// Search for super funds based on a string, search by defaults to All
        /// </remarks>
        public List<SuperProductEditModel> SearchSuperFunds(int businessId, SearchSuperFundsQueryModel request)
        {
            return ApiRequest<List<SuperProductEditModel>>($"/business/{businessId}/superfund/productsearch?term={request.Term}&searchBy={request.SearchBy}", Method.Get);
        }

        /// <summary>
        /// Search Super Funds
        /// </summary>
        /// <remarks>
        /// Search for super funds based on a string, search by defaults to All
        /// </remarks>
        public Task<List<SuperProductEditModel>> SearchSuperFundsAsync(int businessId, SearchSuperFundsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SuperProductEditModel>>($"/business/{businessId}/superfund/productsearch?term={request.Term}&searchBy={request.SearchBy}", Method.Get, cancellationToken);
        }
    }
}
