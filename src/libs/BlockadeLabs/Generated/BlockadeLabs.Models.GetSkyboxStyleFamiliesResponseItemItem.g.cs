
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSkyboxStyleFamiliesResponseItemItem
    {
        /// <summary>
        /// Refers to a skybox style type found within a specific family<br/>
        /// Example: style
        /// </summary>
        /// <example>style</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// To be used as 'skybox_style_id' parameter in the 'Generate skybox' endpoint to influence the overall aesthetic of your skybox generation<br/>
        /// Example: 119
        /// </summary>
        /// <example>119</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the style<br/>
        /// Example: M3 Photoreal (Featured)
        /// </summary>
        /// <example>M3 Photoreal (Featured)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Ascending order position inside a family<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// This is a description of this style (string/nullable)<br/>
        /// Example: Photographic realism with a high degree of flexibility and good visual fidelity
        /// </summary>
        /// <example>Photographic realism with a high degree of flexibility and good visual fidelity</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Maximum number of characters that can be used for 'prompt' in the 'Generate skybox' endpoint<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max-char")]
        public int? MaxChar { get; set; }

        /// <summary>
        /// Maximum number of characters that can be used for 'negative_text' in the 'Generate skybox' endpoint<br/>
        /// Example: 410
        /// </summary>
        /// <example>410</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative-text-max-char")]
        public int? NegativeTextMaxChar { get; set; }

        /// <summary>
        /// Webp image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.webp
        /// </summary>
        /// <example>https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.webp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// JPG image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.jpg
        /// </summary>
        /// <example>https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_jpg")]
        public string? ImageJpg { get; set; }

        /// <summary>
        /// Model name<br/>
        /// Example: Model 3
        /// </summary>
        /// <example>Model 3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Model version number<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxStyleFamiliesResponseItemItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Refers to a skybox style type found within a specific family<br/>
        /// Example: style
        /// </param>
        /// <param name="id">
        /// To be used as 'skybox_style_id' parameter in the 'Generate skybox' endpoint to influence the overall aesthetic of your skybox generation<br/>
        /// Example: 119
        /// </param>
        /// <param name="name">
        /// Name of the style<br/>
        /// Example: M3 Photoreal (Featured)
        /// </param>
        /// <param name="sortOrder">
        /// Ascending order position inside a family<br/>
        /// Example: 1
        /// </param>
        /// <param name="description">
        /// This is a description of this style (string/nullable)<br/>
        /// Example: Photographic realism with a high degree of flexibility and good visual fidelity
        /// </param>
        /// <param name="maxChar">
        /// Maximum number of characters that can be used for 'prompt' in the 'Generate skybox' endpoint<br/>
        /// Example: 600
        /// </param>
        /// <param name="negativeTextMaxChar">
        /// Maximum number of characters that can be used for 'negative_text' in the 'Generate skybox' endpoint<br/>
        /// Example: 410
        /// </param>
        /// <param name="image">
        /// Webp image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.webp
        /// </param>
        /// <param name="imageJpg">
        /// JPG image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.jpg
        /// </param>
        /// <param name="model">
        /// Model name<br/>
        /// Example: Model 3
        /// </param>
        /// <param name="modelVersion">
        /// Model version number<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSkyboxStyleFamiliesResponseItemItem(
            string? type,
            int? id,
            string? name,
            int? sortOrder,
            string? description,
            int? maxChar,
            int? negativeTextMaxChar,
            string? image,
            string? imageJpg,
            string? model,
            string? modelVersion)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.SortOrder = sortOrder;
            this.Description = description;
            this.MaxChar = maxChar;
            this.NegativeTextMaxChar = negativeTextMaxChar;
            this.Image = image;
            this.ImageJpg = imageJpg;
            this.Model = model;
            this.ModelVersion = modelVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxStyleFamiliesResponseItemItem" /> class.
        /// </summary>
        public GetSkyboxStyleFamiliesResponseItemItem()
        {
        }

    }
}