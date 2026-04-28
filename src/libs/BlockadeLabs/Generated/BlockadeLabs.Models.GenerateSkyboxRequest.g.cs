
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSkyboxRequest
    {
        /// <summary>
        /// Text prompt describing the skybox world you wish to create. Maximum number of characters: 550. If you are using skybox_style_id then the maximum number of characters is defined in the max-char response parameter defined for each style.<br/>
        /// Example: dark forest
        /// </summary>
        /// <example>dark forest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Describe things to avoid in the skybox world you wish to create. Maximum number of characters: 200. If you are using skybox_style_id then the maximum number of characters is defined in the negative-text-max-char response parameter defined for each style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_text")]
        public string? NegativeText { get; set; }

        /// <summary>
        /// Have an AI automatically improve your prompt to generate pro-level results every time (default: false)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// Send 0 for a random seed generation. Any other number (1-2147483647) set will be used to "freeze" the image generator and create similar images when run again with the same seed and settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Predefined styles that influence the overall aesthetic of your skybox generation (Fantasy landscape, Anime art style, etc...).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_style_id")]
        public int? SkyboxStyleId { get; set; }

        /// <summary>
        /// ID of a previously generated skybox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_imagine_id")]
        public int? RemixImagineId { get; set; }

        /// <summary>
        /// Control image used to influence the generation. The image needs to be exacly 1024 pixels wide and 512 pixels tall PNG equirectangular projection image of a scribble with black (#00000) background and white (#ffffff) brush strokes. For "scribble" effect you will also need to send control_model="scribble".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_image")]
        public byte[]? ControlImage { get; set; }

        /// <summary>
        /// Control image used to influence the generation. The image needs to be exacly 1024 pixels wide and 512 pixels tall PNG equirectangular projection image of a scribble with black (#00000) background and white (#ffffff) brush strokes. For "scribble" effect you will also need to send control_model="scribble".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_imagename")]
        public string? ControlImagename { get; set; }

        /// <summary>
        /// Model used for the control_image. Currently, the only option is: "scribble".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_model")]
        public string? ControlModel { get; set; }

        /// <summary>
        /// Image (Binary/Base64 string/Absolute URL) to be used as initial image for Skybox generation. Please use equirectangular 360° images. 2:1 aspect ratio recommended. Maximum file size is 50 megabytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image")]
        public byte[]? InitImage { get; set; }

        /// <summary>
        /// Image (Binary/Base64 string/Absolute URL) to be used as initial image for Skybox generation. Please use equirectangular 360° images. 2:1 aspect ratio recommended. Maximum file size is 50 megabytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_imagename")]
        public string? InitImagename { get; set; }

        /// <summary>
        /// Scale to be used as initial influence of the "Init Image" for Skybox generation. The default value is 0, allowed range is between 0 and 0.97, where 0 represents no influence and 0.97 represents lots of influence. Only has an effect when using an init_image parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_strength")]
        public double? InitStrength { get; set; }

        /// <summary>
        /// Request for high quality depth map. It will be returned in the depth_map_url parameter. (default: false)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_depth_hq")]
        public bool? ReturnDepthHq { get; set; }

        /// <summary>
        /// Optionally, you may specify a webhook url to specify the destination for progress updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSkyboxRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSkyboxRequest(
            string prompt,
            string? negativeText,
            bool? enhancePrompt,
            int? seed,
            int? skyboxStyleId,
            int? remixImagineId,
            byte[]? controlImage,
            string? controlImagename,
            string? controlModel,
            byte[]? initImage,
            string? initImagename,
            double? initStrength,
            bool? returnDepthHq,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativeText = negativeText;
            this.EnhancePrompt = enhancePrompt;
            this.Seed = seed;
            this.SkyboxStyleId = skyboxStyleId;
            this.RemixImagineId = remixImagineId;
            this.ControlImage = controlImage;
            this.ControlImagename = controlImagename;
            this.ControlModel = controlModel;
            this.InitImage = initImage;
            this.InitImagename = initImagename;
            this.InitStrength = initStrength;
            this.ReturnDepthHq = returnDepthHq;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSkyboxRequest" /> class.
        /// </summary>
        public GenerateSkyboxRequest()
        {
        }
    }
}