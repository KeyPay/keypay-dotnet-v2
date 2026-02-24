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
        void GetContractorByIdentifier(int businessId, int contractorId);
        Task GetContractorByIdentifierAsync(int businessId, int contractorId, CancellationToken cancellationToken = default);
        void UpdateContractor(int businessId, int contractorId, AuContractorUnstructuredModel model);
        Task UpdateContractorAsync(int businessId, int contractorId, AuContractorUnstructuredModel model, CancellationToken cancellationToken = default);
        void CreateOrUpdateContractor(int businessId, AuContractorUnstructuredModel model);
        Task CreateOrUpdateContractorAsync(int businessId, AuContractorUnstructuredModel model, CancellationToken cancellationToken = default);
        List<ContractorSimpleModel> ListContractors(int businessId);
        Task<List<ContractorSimpleModel>> ListContractorsAsync(int businessId, CancellationToken cancellationToken = default);
        void DeactivateContractor(int businessId, int contractorId, DeactivateContractorModel deactivateContractorModel);
        Task DeactivateContractorAsync(int businessId, int contractorId, DeactivateContractorModel deactivateContractorModel, CancellationToken cancellationToken = default);
    }
    public class ContractorFunction : BaseFunction, IContractorFunction
    {
        public ContractorFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get contractor by identifier
        /// </summary>
        /// <remarks>
        /// Gets contractor details with the specified identifier
        /// </remarks>
        public void GetContractorByIdentifier(int businessId, int contractorId)
        {
            ApiRequest($"/business/{businessId}/contractor/{contractorId}", Method.Get);
        }

        /// <summary>
        /// Get contractor by identifier
        /// </summary>
        /// <remarks>
        /// Gets contractor details with the specified identifier
        /// </remarks>
        public Task GetContractorByIdentifierAsync(int businessId, int contractorId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/contractor/{contractorId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update contractor
        /// </summary>
        public void UpdateContractor(int businessId, int contractorId, AuContractorUnstructuredModel model)
        {
            ApiRequest($"/business/{businessId}/contractor/{contractorId}", model, Method.Put);
        }

        /// <summary>
        /// Update contractor
        /// </summary>
        public Task UpdateContractorAsync(int businessId, int contractorId, AuContractorUnstructuredModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/contractor/{contractorId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create or update contractor
        /// </summary>
        /// <remarks>
        /// <p>If an ID is passed or an existing contractor is matched, it will
        ///             be updated. Otherwise a new record will be created. 
        ///             </p>
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// </remarks>
        public void CreateOrUpdateContractor(int businessId, AuContractorUnstructuredModel model)
        {
            ApiRequest($"/business/{businessId}/contractor", model, Method.Post);
        }

        /// <summary>
        /// Create or update contractor
        /// </summary>
        /// <remarks>
        /// <p>If an ID is passed or an existing contractor is matched, it will
        ///             be updated. Otherwise a new record will be created. 
        ///             </p>
        /// <p>
        ///             If reporting dimensions are enabled for the business, add primary reporting dimension values using "|" as a separator between values.
        ///             </p>
        /// </remarks>
        public Task CreateOrUpdateContractorAsync(int businessId, AuContractorUnstructuredModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/contractor", model, Method.Post, cancellationToken);
        }

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

        /// <summary>
        /// Deactivate contractor
        /// </summary>
        /// <remarks>
        /// Deactivates contractor with the specified identifier.
        /// </remarks>
        public void DeactivateContractor(int businessId, int contractorId, DeactivateContractorModel deactivateContractorModel)
        {
            ApiRequest($"/business/{businessId}/contractor/{contractorId}/deactivate", deactivateContractorModel, Method.Post);
        }

        /// <summary>
        /// Deactivate contractor
        /// </summary>
        /// <remarks>
        /// Deactivates contractor with the specified identifier.
        /// </remarks>
        public Task DeactivateContractorAsync(int businessId, int contractorId, DeactivateContractorModel deactivateContractorModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/contractor/{contractorId}/deactivate", deactivateContractorModel, Method.Post, cancellationToken);
        }
    }
}
