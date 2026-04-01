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
        AwardInstallResponse InstallAward(int businessId, int awardId, AwardInstallRequest request);
        Task<AwardInstallResponse> InstallAwardAsync(int businessId, int awardId, AwardInstallRequest request, CancellationToken cancellationToken = default);
    }
    public class AwardFunction : BaseFunction, IAwardFunction
    {
        public AwardFunction(ApiRequestExecutor api) : base(api) {}

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
