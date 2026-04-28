#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxExportsClient
    {
        /// <summary>
        /// Get Export Types<br/>
        /// Returns the list of all available export types.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::BlockadeLabs.GetExportTypesResponseItem>> GetExportTypesAsync(
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}