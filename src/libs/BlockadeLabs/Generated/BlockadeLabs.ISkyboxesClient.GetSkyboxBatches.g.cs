#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Get Skybox Batches<br/>
        /// Paginated list of batch requests for the account.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 18
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="order">
        /// Default Value: DESC
        /// </param>
        /// <param name="status"></param>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.GetSkyboxBatchesResponse> GetSkyboxBatchesAsync(
            int? limit = default,
            int? offset = default,
            global::BlockadeLabs.GetSkyboxBatchesOrder? order = default,
            global::BlockadeLabs.GetSkyboxBatchesStatus? status = default,
            int? batchId = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Skybox Batches<br/>
        /// Paginated list of batch requests for the account.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 18
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="order">
        /// Default Value: DESC
        /// </param>
        /// <param name="status"></param>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.GetSkyboxBatchesResponse>> GetSkyboxBatchesAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::BlockadeLabs.GetSkyboxBatchesOrder? order = default,
            global::BlockadeLabs.GetSkyboxBatchesStatus? status = default,
            int? batchId = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}