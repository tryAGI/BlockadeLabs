
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExportTypesResponseItem
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: JPG
        /// </summary>
        /// <example>JPG</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: equirectangular-jpg
        /// </summary>
        /// <example>equirectangular-jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium_feature")]
        public bool? PremiumFeature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExportTypesResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="name">
        /// Example: JPG
        /// </param>
        /// <param name="key">
        /// Example: equirectangular-jpg
        /// </param>
        /// <param name="premiumFeature">
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExportTypesResponseItem(
            int? id,
            string? name,
            string? key,
            bool? premiumFeature)
        {
            this.Id = id;
            this.Name = name;
            this.Key = key;
            this.PremiumFeature = premiumFeature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExportTypesResponseItem" /> class.
        /// </summary>
        public GetExportTypesResponseItem()
        {
        }

    }
}