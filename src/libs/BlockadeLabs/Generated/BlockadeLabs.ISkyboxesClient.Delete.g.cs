#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Delete<br/>
        /// This request deletes skybox.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.DeleteResponse> DeleteAsync(
            string id,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}