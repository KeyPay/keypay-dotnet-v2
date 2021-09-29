using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.SuperFund;

namespace KeyPayV2.Au.Functions
{
    public class SuperFundFunction : BaseFunction
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
            return ApiRequest<List<SelfManagedSuperFundModel>>($"/business/{businessId}/selfmanagedsuperfund{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new self managed super fund for the business.
        /// </remarks>
        public void CreateSelfManagedSuperFund(int businessId, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/selfmanagedsuperfund", fund, Method.POST);
        }

        /// <summary>
        /// Get Self Managed Super Fund by ID
        /// </summary>
        /// <remarks>
        /// Gets the self managed super fund with the specified ID.
        /// </remarks>
        public SelfManagedSuperFundModel GetSelfManagedSuperFundById(int businessId, int id)
        {
            return ApiRequest<SelfManagedSuperFundModel>($"/business/{businessId}/selfmanagedsuperfund/{id}");
        }

        /// <summary>
        /// Update Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the Self Managed Super Fund by the specified ID
        /// </remarks>
        public void UpdateSelfManagedSuperFund(int businessId, int id, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/selfmanagedsuperfund/{id}", fund, Method.PUT);
        }

        /// <summary>
        /// List Electronic Service Addresses
        /// </summary>
        /// <remarks>
        /// Electronic Service Addresses for Self Managed Super Funds
        /// </remarks>
        public List<AuSmsfElectronicServiceAddressModel> ListElectronicServiceAddresses(int businessId)
        {
            return ApiRequest<List<AuSmsfElectronicServiceAddressModel>>($"/business/{businessId}/superfund/electronicserviceaddress");
        }

        /// <summary>
        /// Search Super Funds
        /// </summary>
        /// <remarks>
        /// Search for super funds based on a string, search by defaults to All
        /// </remarks>
        public List<SuperProductEditModel> SearchSuperFunds(int businessId, SearchSuperFundsQueryModel request)
        {
            return ApiRequest<List<SuperProductEditModel>>($"/business/{businessId}/superfund/productsearch?term={request.Term}&searchBy={request.SearchBy}");
        }
    }
}
