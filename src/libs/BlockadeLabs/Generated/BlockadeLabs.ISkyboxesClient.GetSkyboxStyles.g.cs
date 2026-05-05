#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Get Skybox Styles<br/>
        /// Returns the list of predefined styles that can influence the overall aesthetic of your skybox generation.
        /// </summary>
        /// <param name="modelVersion">
        /// Filter skybox styles by model version number (ie. "2" or "3")
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStylesResponseItem>> GetSkyboxStylesAsync(
            string? modelVersion = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Skybox Styles<br/>
        /// Returns the list of predefined styles that can influence the overall aesthetic of your skybox generation.
        /// </summary>
        /// <param name="modelVersion">
        /// Filter skybox styles by model version number (ie. "2" or "3")
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStylesResponseItem>>> GetSkyboxStylesAsResponseAsync(
            string? modelVersion = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}