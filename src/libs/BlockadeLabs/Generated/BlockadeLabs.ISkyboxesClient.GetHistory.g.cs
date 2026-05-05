#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Get History
        /// </summary>
        /// <param name="status">
        /// Filter by status. Options: all, pending, dispatched, processing, complete, abort, error (default: all)
        /// </param>
        /// <param name="limit">
        /// Number of items to be returned per page (default: 18, max-value: 100)
        /// </param>
        /// <param name="offset">
        /// Page number (default: 0)
        /// </param>
        /// <param name="order">
        /// Sort order. Options: ASC, DESC (default: DESC)
        /// </param>
        /// <param name="imagineId">
        /// Filter by skybox ID
        /// </param>
        /// <param name="query">
        /// Filter by title or prompt
        /// </param>
        /// <param name="generator">
        /// Filter by generator
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.GetHistoryResponse> GetHistoryAsync(
            string? status = default,
            int? limit = default,
            int? offset = default,
            string? order = default,
            int? imagineId = default,
            string? query = default,
            string? generator = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get History
        /// </summary>
        /// <param name="status">
        /// Filter by status. Options: all, pending, dispatched, processing, complete, abort, error (default: all)
        /// </param>
        /// <param name="limit">
        /// Number of items to be returned per page (default: 18, max-value: 100)
        /// </param>
        /// <param name="offset">
        /// Page number (default: 0)
        /// </param>
        /// <param name="order">
        /// Sort order. Options: ASC, DESC (default: DESC)
        /// </param>
        /// <param name="imagineId">
        /// Filter by skybox ID
        /// </param>
        /// <param name="query">
        /// Filter by title or prompt
        /// </param>
        /// <param name="generator">
        /// Filter by generator
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.GetHistoryResponse>> GetHistoryAsResponseAsync(
            string? status = default,
            int? limit = default,
            int? offset = default,
            string? order = default,
            int? imagineId = default,
            string? query = default,
            string? generator = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}