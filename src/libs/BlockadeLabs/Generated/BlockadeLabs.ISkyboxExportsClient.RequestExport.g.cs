#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxExportsClient
    {
        /// <summary>
        /// Request Export<br/>
        /// Process for tracking export progress is identical to tracking skybox generation by using Pusher, Webhook or API Data pooling.<br/>
        /// If the export request has already been completed you will immediately get a response with status=complete and file_url in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.RequestExportResponse> RequestExportAsync(

            global::BlockadeLabs.RequestExportRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Export<br/>
        /// Process for tracking export progress is identical to tracking skybox generation by using Pusher, Webhook or API Data pooling.<br/>
        /// If the export request has already been completed you will immediately get a response with status=complete and file_url in the response.
        /// </summary>
        /// <param name="skyboxId">
        /// Skybox obfuscated_id (needs to have status=complete)<br/>
        /// Example: f87f6a4b3784591795bfed30100a9ef6
        /// </param>
        /// <param name="typeId">
        /// Export type id.<br/>
        /// Example: 2
        /// </param>
        /// <param name="webhookUrl">
        /// Optionally, you may specify a webhook url to specify the destination for progress updates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.RequestExportResponse> RequestExportAsync(
            string skyboxId,
            int typeId,
            string? webhookUrl = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}