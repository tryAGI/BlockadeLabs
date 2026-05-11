#nullable enable

namespace BlockadeLabs
{
    public partial interface ISkyboxesClient
    {
        /// <summary>
        /// Generate Skybox<br/>
        /// Used for generating skyboxes, skybox remixes and depth maps.
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
        /// Used for generating skyboxes, skybox remixes and depth maps.
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
        /// Used for generating skyboxes, skybox remixes and depth maps.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt describing the skybox world you wish to create. Maximum number of characters: 550. If you are using skybox_style_id then the maximum number of characters is defined in the max-char response parameter defined for each style.<br/>
        /// Example: dark forest
        /// </param>
        /// <param name="negativeText">
        /// Describe things to avoid in the skybox world you wish to create. Maximum number of characters: 200. If you are using skybox_style_id then the maximum number of characters is defined in the negative-text-max-char response parameter defined for each style.
        /// </param>
        /// <param name="enhancePrompt">
        /// Have an AI automatically improve your prompt to generate pro-level results every time (default: false)
        /// </param>
        /// <param name="seed">
        /// Send 0 for a random seed generation. Any other number (1-2147483647) set will be used to "freeze" the image generator and create similar images when run again with the same seed and settings.
        /// </param>
        /// <param name="skyboxStyleId">
        /// Predefined styles that influence the overall aesthetic of your skybox generation (Fantasy landscape, Anime art style, etc...).
        /// </param>
        /// <param name="remixImagineId">
        /// ID of a previously generated skybox
        /// </param>
        /// <param name="controlImage">
        /// Control image used to influence the generation. The image needs to be exacly 1024 pixels wide and 512 pixels tall PNG equirectangular projection image of a scribble with black (#00000) background and white (#ffffff) brush strokes. For "scribble" effect you will also need to send control_model="scribble".
        /// </param>
        /// <param name="controlImagename">
        /// Control image used to influence the generation. The image needs to be exacly 1024 pixels wide and 512 pixels tall PNG equirectangular projection image of a scribble with black (#00000) background and white (#ffffff) brush strokes. For "scribble" effect you will also need to send control_model="scribble".
        /// </param>
        /// <param name="controlModel">
        /// Model used for the control_image. Currently, the only option is: "scribble".
        /// </param>
        /// <param name="initImage">
        /// Image (Binary/Base64 string/Absolute URL) to be used as initial image for Skybox generation. Please use equirectangular 360° images. 2:1 aspect ratio recommended. Maximum file size is 50 megabytes.
        /// </param>
        /// <param name="initImagename">
        /// Image (Binary/Base64 string/Absolute URL) to be used as initial image for Skybox generation. Please use equirectangular 360° images. 2:1 aspect ratio recommended. Maximum file size is 50 megabytes.
        /// </param>
        /// <param name="initStrength">
        /// Scale to be used as initial influence of the "Init Image" for Skybox generation. The default value is 0, allowed range is between 0 and 0.97, where 0 represents no influence and 0.97 represents lots of influence. Only has an effect when using an init_image parameter.
        /// </param>
        /// <param name="returnDepthHq">
        /// Request for high quality depth map. It will be returned in the depth_map_url parameter. (default: false)
        /// </param>
        /// <param name="webhookUrl">
        /// Optionally, you may specify a webhook url to specify the destination for progress updates
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlockadeLabs.GenerateSkyboxResponse> GenerateSkyboxAsync(
            string prompt,
            string? negativeText = default,
            bool? enhancePrompt = default,
            int? seed = default,
            int? skyboxStyleId = default,
            int? remixImagineId = default,
            byte[]? controlImage = default,
            string? controlImagename = default,
            string? controlModel = default,
            byte[]? initImage = default,
            string? initImagename = default,
            double? initStrength = default,
            bool? returnDepthHq = default,
            string? webhookUrl = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}