#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Submit Skybox Batch<br/>
        /// Queue multiple skyboxes in one request. Accepts the same parameters as Generate Skybox, plus quantity. Essential and Standard allow batches up to 3 credits. Business allows up to 30. Free cannot use batches. Model 4 batches also require a Standard or Business plan and variant_id. Only one batch can be in progress per account (409).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.SubmitSkyboxBatchResponse> SubmitSkyboxBatchAsync(

            global::BlockadeLabs.SubmitSkyboxBatchRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Skybox Batch<br/>
        /// Queue multiple skyboxes in one request. Accepts the same parameters as Generate Skybox, plus quantity. Essential and Standard allow batches up to 3 credits. Business allows up to 30. Free cannot use batches. Model 4 batches also require a Standard or Business plan and variant_id. Only one batch can be in progress per account (409).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.SubmitSkyboxBatchResponse>> SubmitSkyboxBatchAsResponseAsync(

            global::BlockadeLabs.SubmitSkyboxBatchRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Skybox Batch<br/>
        /// Queue multiple skyboxes in one request. Accepts the same parameters as Generate Skybox, plus quantity. Essential and Standard allow batches up to 3 credits. Business allows up to 30. Free cannot use batches. Model 4 batches also require a Standard or Business plan and variant_id. Only one batch can be in progress per account (409).
        /// </summary>
        /// <param name="quantity">
        /// Number of skyboxes to generate. Required. Total credit cost is quantity times credits per generation, and must fit the plan batch cap and the account balance.<br/>
        /// Example: 3
        /// </param>
        /// <param name="skyboxStyleId">
        /// Style id from Get Skybox Styles. Required.<br/>
        /// Example: 155
        /// </param>
        /// <param name="prompt">
        /// Text prompt. Maximum 2000 characters, or the style max-char.<br/>
        /// Example: dark forest
        /// </param>
        /// <param name="negativeText">
        /// Things to avoid. Maximum 600 characters, or the style negative-text-max-char.
        /// </param>
        /// <param name="enhancePrompt">
        /// Automatically improve the prompt. Default: false.<br/>
        /// Example: false
        /// </param>
        /// <param name="horizonShift">
        /// Model 4 only. Not used for Model 3 generations. Default 0. Range -20 to 20.<br/>
        /// Example: 0
        /// </param>
        /// <param name="variantId">
        /// Required for Model 4 batches. 1 is Balance, 2 is Detail, or another id from the style variants array.<br/>
        /// Example: 1
        /// </param>
        /// <param name="softLines">
        /// Model 4 only. Default: false.<br/>
        /// Example: false
        /// </param>
        /// <param name="seed">
        /// 0 for a random seed. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxWait">
        /// Per-generation wait limit in seconds. Range 30-1800.<br/>
        /// Example: 120
        /// </param>
        /// <param name="webhookUrl">
        /// Optional URL for batch-level status updates. The payload matches the batch object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.SubmitSkyboxBatchResponse> SubmitSkyboxBatchAsync(
            int quantity,
            int skyboxStyleId,
            string prompt,
            string? negativeText = default,
            bool? enhancePrompt = default,
            int? horizonShift = default,
            int? variantId = default,
            bool? softLines = default,
            int? seed = default,
            int? maxWait = default,
            string? webhookUrl = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}