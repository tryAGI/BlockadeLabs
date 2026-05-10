
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestExportRequest
    {
        /// <summary>
        /// Skybox obfuscated_id (needs to have status=complete)<br/>
        /// Example: f87f6a4b3784591795bfed30100a9ef6
        /// </summary>
        /// <example>f87f6a4b3784591795bfed30100a9ef6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkyboxId { get; set; }

        /// <summary>
        /// Export type id.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TypeId { get; set; }

        /// <summary>
        /// Optionally, you may specify a webhook url to specify the destination for progress updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestExportRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestExportRequest(
            string skyboxId,
            int typeId,
            string? webhookUrl)
        {
            this.SkyboxId = skyboxId ?? throw new global::System.ArgumentNullException(nameof(skyboxId));
            this.TypeId = typeId;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestExportRequest" /> class.
        /// </summary>
        public RequestExportRequest()
        {
        }

    }
}