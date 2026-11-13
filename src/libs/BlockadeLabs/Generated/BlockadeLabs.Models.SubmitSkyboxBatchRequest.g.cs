
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitSkyboxBatchRequest
    {
        /// <summary>
        /// Number of skyboxes to generate. Required. Total credit cost is quantity times credits per generation, and must fit the plan batch cap and the account balance.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Quantity { get; set; }

        /// <summary>
        /// Style id from Get Skybox Styles. Required.<br/>
        /// Example: 155
        /// </summary>
        /// <example>155</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_style_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkyboxStyleId { get; set; }

        /// <summary>
        /// Text prompt. Maximum 2000 characters, or the style max-char.<br/>
        /// Example: dark forest
        /// </summary>
        /// <example>dark forest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Things to avoid. Maximum 600 characters, or the style negative-text-max-char.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_text")]
        public string? NegativeText { get; set; }

        /// <summary>
        /// Automatically improve the prompt. Default: false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// Model 4 only. Not used for Model 3 generations. Default 0. Range -20 to 20.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizon_shift")]
        public int? HorizonShift { get; set; }

        /// <summary>
        /// Required for Model 4 batches. 1 is Balance, 2 is Detail, or another id from the style variants array.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant_id")]
        public int? VariantId { get; set; }

        /// <summary>
        /// Model 4 only. Default: false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_lines")]
        public bool? SoftLines { get; set; }

        /// <summary>
        /// 0 for a random seed. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Per-generation wait limit in seconds. Range 30-1800.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_wait")]
        public int? MaxWait { get; set; }

        /// <summary>
        /// Optional URL for batch-level status updates. The payload matches the batch object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSkyboxBatchRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitSkyboxBatchRequest(
            int quantity,
            int skyboxStyleId,
            string prompt,
            string? negativeText,
            bool? enhancePrompt,
            int? horizonShift,
            int? variantId,
            bool? softLines,
            int? seed,
            int? maxWait,
            string? webhookUrl)
        {
            this.Quantity = quantity;
            this.SkyboxStyleId = skyboxStyleId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativeText = negativeText;
            this.EnhancePrompt = enhancePrompt;
            this.HorizonShift = horizonShift;
            this.VariantId = variantId;
            this.SoftLines = softLines;
            this.Seed = seed;
            this.MaxWait = maxWait;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSkyboxBatchRequest" /> class.
        /// </summary>
        public SubmitSkyboxBatchRequest()
        {
        }

    }
}