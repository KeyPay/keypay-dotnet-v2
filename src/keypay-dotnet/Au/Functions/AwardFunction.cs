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
using KeyPayV2.Au.Models.Award;

namespace KeyPayV2.Au.Functions
{
    public interface IAwardFunction
    {
        List<AwardStatusModel> ListAwards(int businessId);
        Task<List<AwardStatusModel>> ListAwardsAsync(int businessId, CancellationToken cancellationToken = default);
        List<AwardStatusModel> ListAwards(int businessId, ListAwardsQueryModel request);
        Task<List<AwardStatusModel>> ListAwardsAsync(int businessId, ListAwardsQueryModel request, CancellationToken cancellationToken = default);
        List<InstalledAwardModel> ListInstalledAwards(int businessId);
        Task<List<InstalledAwardModel>> ListInstalledAwardsAsync(int businessId, CancellationToken cancellationToken = default);
        AwardInstallResponse InstallAward(int businessId, int awardId, AwardInstallRequest request);
        Task<AwardInstallResponse> InstallAwardAsync(int businessId, int awardId, AwardInstallRequest request, CancellationToken cancellationToken = default);
    }
    public class AwardFunction : BaseFunction, IAwardFunction
    {
        public AwardFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Awards
        /// </summary>
        /// <remarks>
        /// Returns all awards available to the business with their current status.
        /// Use the optional status filter to narrow results (e.g. OutOfDate).
        /// </remarks>
        public List<AwardStatusModel> ListAwards(int businessId)
        {
            return ApiRequest<List<AwardStatusModel>>($"/business/{businessId}/award", Method.Get);
        }

        /// <summary>
        /// List Awards
        /// </summary>
        /// <remarks>
        /// Returns all awards available to the business with their current status.
        /// Use the optional status filter to narrow results (e.g. OutOfDate).
        /// </remarks>
        public Task<List<AwardStatusModel>> ListAwardsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AwardStatusModel>>($"/business/{businessId}/award", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Awards
        /// </summary>
        /// <remarks>
        /// Returns all awards available to the business with their current status.
        /// Use the optional status filter to narrow results (e.g. OutOfDate).
        /// </remarks>
        public List<AwardStatusModel> ListAwards(int businessId, ListAwardsQueryModel request)
        {
            return ApiRequest<List<AwardStatusModel>>($"/business/{businessId}/award?status={request.Status}", Method.Get);
        }

        /// <summary>
        /// List Awards
        /// </summary>
        /// <remarks>
        /// Returns all awards available to the business with their current status.
        /// Use the optional status filter to narrow results (e.g. OutOfDate).
        /// </remarks>
        public Task<List<AwardStatusModel>> ListAwardsAsync(int businessId, ListAwardsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AwardStatusModel>>($"/business/{businessId}/award?status={request.Status}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Installed Awards
        /// </summary>
        /// <remarks>
        /// Returns the awards currently installed on the business.
        /// </remarks>
        public List<InstalledAwardModel> ListInstalledAwards(int businessId)
        {
            return ApiRequest<List<InstalledAwardModel>>($"/business/{businessId}/award/installed", Method.Get);
        }

        /// <summary>
        /// List Installed Awards
        /// </summary>
        /// <remarks>
        /// Returns the awards currently installed on the business.
        /// </remarks>
        public Task<List<InstalledAwardModel>> ListInstalledAwardsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InstalledAwardModel>>($"/business/{businessId}/award/installed", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Install Award
        /// </summary>
        /// <remarks>
        /// Installs an award for the specified business. This operation is asynchronous and returns a job ID that can be used to track the installation progress.
        /// </remarks>
        public AwardInstallResponse InstallAward(int businessId, int awardId, AwardInstallRequest request)
        {
            return ApiRequest<AwardInstallResponse,AwardInstallRequest>($"/business/{businessId}/award/{awardId}/install", request, Method.Put);
        }

        /// <summary>
        /// Install Award
        /// </summary>
        /// <remarks>
        /// Installs an award for the specified business. This operation is asynchronous and returns a job ID that can be used to track the installation progress.
        /// </remarks>
        public Task<AwardInstallResponse> InstallAwardAsync(int businessId, int awardId, AwardInstallRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AwardInstallResponse,AwardInstallRequest>($"/business/{businessId}/award/{awardId}/install", request, Method.Put, cancellationToken);
        }
    }
}
