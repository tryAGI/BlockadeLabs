
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateSkyboxRequest
    {
        /// <summary>
        /// Style id from Get Skybox Styles. Chooses the model version and the aesthetic. Required.<br/>
        /// Example: 155
        /// </summary>
        /// <example>155</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_style_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkyboxStyleId { get; set; }

        /// <summary>
        /// Text prompt describing the skybox world you wish to create. Maximum number of characters: 2000, or the max-char value returned for the chosen style.<br/>
        /// Example: dark forest
        /// </summary>
        /// <example>dark forest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Things to avoid. Maximum number of characters: 600, or the negative-text-max-char value returned for the chosen style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_text")]
        public string? NegativeText { get; set; }

        /// <summary>
        /// Have an AI automatically improve the prompt (default: false).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// Model 4 only. Not used for Model 3 generations. Defaults to 0. Negative shifts the horizon down, positive shifts it up. Accepted range: -20 to 20.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizon_shift")]
        public int? HorizonShift { get; set; }

        /// <summary>
        /// Model 4 quality variant from the variants array on Get Skybox Styles. 1 is Balance (3 credits, about 60s). 2 is Detail (6 credits, about 120s). If omitted, the style default is used. Required for Model 4 batches. Model 4 variants require a Standard or Business plan.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant_id")]
        public int? VariantId { get; set; }

        /// <summary>
        /// Model 4 only. Softer line rendering while preserving structural geometry. Default: false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_lines")]
        public bool? SoftLines { get; set; }

        /// <summary>
        /// Send 0 for a random seed. Any other number freezes the generator for a similar result with the same settings. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional URL for generation progress updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Maximum seconds to wait for the generation. If it does not finish in time, status is set to error and credits are refunded. Accepted range: 30-1800. Model 3 and Model 4.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_wait")]
        public int? MaxWait { get; set; }

        /// <summary>
        /// Model 3. ID of a previously generated skybox to remix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_imagine_id")]
        public int? RemixImagineId { get; set; }

        /// <summary>
        /// Model 3. ID of a project created in the web app. A random skybox from that project is used as the remix starting point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_collection_id")]
        public int? RemixCollectionId { get; set; }

        /// <summary>
        /// Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_image")]
        public byte[]? ControlImage { get; set; }

        /// <summary>
        /// Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_imagename")]
        public string? ControlImagename { get; set; }

        /// <summary>
        /// Model 3. obfuscated_id of an existing skybox whose control image should be reused, instead of uploading control_image again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_image_hash")]
        public string? ControlImageHash { get; set; }

        /// <summary>
        /// Model 3. Model used for control_image. The only option is "remix".<br/>
        /// Example: remix
        /// </summary>
        /// <example>remix</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_model")]
        public string? ControlModel { get; set; }

        /// <summary>
        /// Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image")]
        public byte[]? InitImage { get; set; }

        /// <summary>
        /// Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_imagename")]
        public string? InitImagename { get; set; }

        /// <summary>
        /// Model 3. obfuscated_id of an existing skybox whose init image should be reused, instead of uploading init_image again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image_hash")]
        public string? InitImageHash { get; set; }

        /// <summary>
        /// Model 3. Inverted influence of init_image. 0.11 is lots of influence, 0.9 is no influence. Only applies when init_image is sent.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_strength")]
        public double? InitStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSkyboxRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSkyboxRequest(
            int skyboxStyleId,
            string prompt,
            string? negativeText,
            bool? enhancePrompt,
            int? horizonShift,
            int? variantId,
            bool? softLines,
            int? seed,
            string? webhookUrl,
            int? maxWait,
            int? remixImagineId,
            int? remixCollectionId,
            byte[]? controlImage,
            string? controlImagename,
            string? controlImageHash,
            string? controlModel,
            byte[]? initImage,
            string? initImagename,
            string? initImageHash,
            double? initStrength)
        {
            this.SkyboxStyleId = skyboxStyleId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativeText = negativeText;
            this.EnhancePrompt = enhancePrompt;
            this.HorizonShift = horizonShift;
            this.VariantId = variantId;
            this.SoftLines = softLines;
            this.Seed = seed;
            this.WebhookUrl = webhookUrl;
            this.MaxWait = maxWait;
            this.RemixImagineId = remixImagineId;
            this.RemixCollectionId = remixCollectionId;
            this.ControlImage = controlImage;
            this.ControlImagename = controlImagename;
            this.ControlImageHash = controlImageHash;
            this.ControlModel = controlModel;
            this.InitImage = initImage;
            this.InitImagename = initImagename;
            this.InitImageHash = initImageHash;
            this.InitStrength = initStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSkyboxRequest" /> class.
        /// </summary>
        public GenerateSkyboxRequest()
        {
        }

    }
}