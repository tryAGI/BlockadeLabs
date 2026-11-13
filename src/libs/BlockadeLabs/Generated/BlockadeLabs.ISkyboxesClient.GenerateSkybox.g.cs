#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Generate Skybox<br/>
        /// Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.GenerateSkyboxResponse> GenerateSkyboxAsync(

            global::BlockadeLabs.GenerateSkyboxRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Skybox<br/>
        /// Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.GenerateSkyboxResponse>> GenerateSkyboxAsResponseAsync(

            global::BlockadeLabs.GenerateSkyboxRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Skybox<br/>
        /// Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.
        /// </summary>
        /// <param name="skyboxStyleId">
        /// Style id from Get Skybox Styles. Chooses the model version and the aesthetic. Required.<br/>
        /// Example: 155
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the skybox world you wish to create. Maximum number of characters: 2000, or the max-char value returned for the chosen style.<br/>
        /// Example: dark forest
        /// </param>
        /// <param name="negativeText">
        /// Things to avoid. Maximum number of characters: 600, or the negative-text-max-char value returned for the chosen style.
        /// </param>
        /// <param name="enhancePrompt">
        /// Have an AI automatically improve the prompt (default: false).<br/>
        /// Example: false
        /// </param>
        /// <param name="horizonShift">
        /// Model 4 only. Not used for Model 3 generations. Defaults to 0. Negative shifts the horizon down, positive shifts it up. Accepted range: -20 to 20.<br/>
        /// Example: 0
        /// </param>
        /// <param name="variantId">
        /// Model 4 quality variant from the variants array on Get Skybox Styles. 1 is Balance (3 credits, about 60s). 2 is Detail (6 credits, about 120s). If omitted, the style default is used. Required for Model 4 batches. Model 4 variants require a Standard or Business plan.<br/>
        /// Example: 1
        /// </param>
        /// <param name="softLines">
        /// Model 4 only. Softer line rendering while preserving structural geometry. Default: false.<br/>
        /// Example: false
        /// </param>
        /// <param name="seed">
        /// Send 0 for a random seed. Any other number freezes the generator for a similar result with the same settings. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.<br/>
        /// Example: 0
        /// </param>
        /// <param name="webhookUrl">
        /// Optional URL for generation progress updates.
        /// </param>
        /// <param name="maxWait">
        /// Maximum seconds to wait for the generation. If it does not finish in time, status is set to error and credits are refunded. Accepted range: 30-1800. Model 3 and Model 4.<br/>
        /// Example: 120
        /// </param>
        /// <param name="remixImagineId">
        /// Model 3. ID of a previously generated skybox to remix.
        /// </param>
        /// <param name="remixCollectionId">
        /// Model 3. ID of a project created in the web app. A random skybox from that project is used as the remix starting point.
        /// </param>
        /// <param name="controlImage">
        /// Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.
        /// </param>
        /// <param name="controlImagename">
        /// Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.
        /// </param>
        /// <param name="controlImageHash">
        /// Model 3. obfuscated_id of an existing skybox whose control image should be reused, instead of uploading control_image again.
        /// </param>
        /// <param name="controlModel">
        /// Model 3. Model used for control_image. The only option is "remix".<br/>
        /// Example: remix
        /// </param>
        /// <param name="initImage">
        /// Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.
        /// </param>
        /// <param name="initImagename">
        /// Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.
        /// </param>
        /// <param name="initImageHash">
        /// Model 3. obfuscated_id of an existing skybox whose init image should be reused, instead of uploading init_image again.
        /// </param>
        /// <param name="initStrength">
        /// Model 3. Inverted influence of init_image. 0.11 is lots of influence, 0.9 is no influence. Only applies when init_image is sent.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.GenerateSkyboxResponse> GenerateSkyboxAsync(
            int skyboxStyleId,
            string prompt,
            string? negativeText = default,
            bool? enhancePrompt = default,
            int? horizonShift = default,
            int? variantId = default,
            bool? softLines = default,
            int? seed = default,
            string? webhookUrl = default,
            int? maxWait = default,
            int? remixImagineId = default,
            int? remixCollectionId = default,
            byte[]? controlImage = default,
            string? controlImagename = default,
            string? controlImageHash = default,
            string? controlModel = default,
            byte[]? initImage = default,
            string? initImagename = default,
            string? initImageHash = default,
            double? initStrength = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}