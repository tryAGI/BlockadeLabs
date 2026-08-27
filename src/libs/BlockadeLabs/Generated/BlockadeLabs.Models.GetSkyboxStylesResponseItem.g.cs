
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSkyboxStylesResponseItem
    {
        /// <summary>
        /// To be used as 'skybox_style_id' parameter in the 'Generate skybox' endpoint to influence the overall aesthetic of your skybox generation<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the style<br/>
        /// Example: Fantasy
        /// </summary>
        /// <example>Fantasy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the style<br/>
        /// Example: Classic fantasy subject matter concept art renderings
        /// </summary>
        /// <example>Classic fantasy subject matter concept art renderings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Maximum number of characters that can be used for 'prompt' in the 'Generate skybox' endpoint<br/>
        /// Example: 370
        /// </summary>
        /// <example>370</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max-char")]
        public int? MaxChar { get; set; }

        /// <summary>
        /// Maximum number of characters that can be used for 'negative_text' in the 'Generate skybox' endpoint<br/>
        /// Example: 220
        /// </summary>
        /// <example>220</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative-text-max-char")]
        public int? NegativeTextMaxChar { get; set; }

        /// <summary>
        /// Webp image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/4R0ACI1zHpLoOT8gGGu0dEe4QEzoMelaWGavSqPk.webp
        /// </summary>
        /// <example>https://images.blockadelabs.com/images/skybox/4R0ACI1zHpLoOT8gGGu0dEe4QEzoMelaWGavSqPk.webp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// JPG image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/4R0ACI1zHpLoOT8gGGu0dEe4QEzoMelaWGavSqPk.jpg
        /// </summary>
        /// <example>https://images.blockadelabs.com/images/skybox/4R0ACI1zHpLoOT8gGGu0dEe4QEzoMelaWGavSqPk.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_jpg")]
        public string? ImageJpg { get; set; }

        /// <summary>
        /// Model name<br/>
        /// Example: Model 2
        /// </summary>
        /// <example>Model 2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Model version number<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Sorting order<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Shows if the style is premium<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium")]
        public int? Premium { get; set; }

        /// <summary>
        /// Shows if the style is new<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("new")]
        public int? New { get; set; }

        /// <summary>
        /// Shows if the style is experimental<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public int? Experimental { get; set; }

        /// <summary>
        /// ID of the family the style belongs to<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_style_families_id")]
        public int? SkyboxStyleFamiliesId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxStylesResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// To be used as 'skybox_style_id' parameter in the 'Generate skybox' endpoint to influence the overall aesthetic of your skybox generation<br/>
        /// Example: 2
        /// </param>
        /// <param name="name">
        /// Name of the style<br/>
        /// Example: Fantasy
        /// </param>
        /// <param name="description">
        /// Description of the style<br/>
        /// Example: Classic fantasy subject matter concept art renderings
        /// </param>
        /// <param name="maxChar">
        /// Maximum number of characters that can be used for 'prompt' in the 'Generate skybox' endpoint<br/>
        /// Example: 370
        /// </param>
        /// <param name="negativeTextMaxChar">
        /// Maximum number of characters that can be used for 'negative_text' in the 'Generate skybox' endpoint<br/>
        /// Example: 220
        /// </param>
        /// <param name="image">
        /// Webp image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/4R0ACI1zHpLoOT8gGGu0dEe4QEzoMelaWGavSqPk.webp
        /// </param>
        /// <param name="imageJpg">
        /// JPG image example of the style<br/>
        /// Example: https://images.blockadelabs.com/images/skybox/4R0ACI1zHpLoOT8gGGu0dEe4QEzoMelaWGavSqPk.jpg
        /// </param>
        /// <param name="model">
        /// Model name<br/>
        /// Example: Model 2
        /// </param>
        /// <param name="modelVersion">
        /// Model version number<br/>
        /// Example: 2
        /// </param>
        /// <param name="sortOrder">
        /// Sorting order<br/>
        /// Example: 20
        /// </param>
        /// <param name="premium">
        /// Shows if the style is premium<br/>
        /// Example: 0
        /// </param>
        /// <param name="new">
        /// Shows if the style is new<br/>
        /// Example: 0
        /// </param>
        /// <param name="experimental">
        /// Shows if the style is experimental<br/>
        /// Example: 0
        /// </param>
        /// <param name="skyboxStyleFamiliesId">
        /// ID of the family the style belongs to<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSkyboxStylesResponseItem(
            int? id,
            string? name,
            string? description,
            int? maxChar,
            int? negativeTextMaxChar,
            string? image,
            string? imageJpg,
            string? model,
            string? modelVersion,
            int? sortOrder,
            int? premium,
            int? @new,
            int? experimental,
            int? skyboxStyleFamiliesId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.MaxChar = maxChar;
            this.NegativeTextMaxChar = negativeTextMaxChar;
            this.Image = image;
            this.ImageJpg = imageJpg;
            this.Model = model;
            this.ModelVersion = modelVersion;
            this.SortOrder = sortOrder;
            this.Premium = premium;
            this.New = @new;
            this.Experimental = experimental;
            this.SkyboxStyleFamiliesId = skyboxStyleFamiliesId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxStylesResponseItem" /> class.
        /// </summary>
        public GetSkyboxStylesResponseItem()
        {
        }

    }
}