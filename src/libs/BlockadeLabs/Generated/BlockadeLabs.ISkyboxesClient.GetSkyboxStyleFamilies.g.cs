#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Get Skybox Style Families<br/>
        /// Returns the list of predefined styles that can influence the overall aesthetic of your skybox generation, sorted by style family. This route can be used in order to build a menu of styles sorted by family.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem>> GetSkyboxStyleFamiliesAsync(
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Skybox Style Families<br/>
        /// Returns the list of predefined styles that can influence the overall aesthetic of your skybox generation, sorted by style family. This route can be used in order to build a menu of styles sorted by family.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem>>> GetSkyboxStyleFamiliesAsResponseAsync(
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}