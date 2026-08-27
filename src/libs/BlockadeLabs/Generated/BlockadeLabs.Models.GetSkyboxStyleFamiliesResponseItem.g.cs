
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSkyboxStyleFamiliesResponseItem
    {
        /// <summary>
        /// Can be of type 'family' or 'style' if the style doesn't belong to any families<br/>
        /// Example: family
        /// </summary>
        /// <example>family</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of a type<br/>
        /// Example: 17
        /// </summary>
        /// <example>17</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the menu item<br/>
        /// Example: Model 3 Realistic
        /// </summary>
        /// <example>Model 3 Realistic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Ascending order position in the menu<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Collection of styles that belong to a family<br/>
        /// Example: [{"type":"style","id":119,"name":"M3 Photoreal (Featured)","sort_order":1,"description":"Photographic realism with a high degree of flexibility and good visual fidelity","max-char":600,"negative-text-max-char":410,"image":"https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.webp","image_jpg":"https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.jpg","model":"Model 3","model_version":"3"}, {"type":"style","id":102,"name":"M3 Cinematic Realism","sort_order":2,"description":"Photographic realism with dramatic, dark color grading and filmic mood","max-char":600,"negative-text-max-char":430,"image":"https://images.blockadelabs.com/images/skybox/gGfOHzfOiAgvkVxHVtg6TDNwWa22SvTluHoRJNTK.webp","image_jpg":"https://images.blockadelabs.com/images/skybox/gGfOHzfOiAgvkVxHVtg6TDNwWa22SvTluHoRJNTK.jpg","model":"Model 3","model_version":"3"}]
        /// </summary>
        /// <example>[{"type":"style","id":119,"name":"M3 Photoreal (Featured)","sort_order":1,"description":"Photographic realism with a high degree of flexibility and good visual fidelity","max-char":600,"negative-text-max-char":410,"image":"https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.webp","image_jpg":"https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.jpg","model":"Model 3","model_version":"3"}, {"type":"style","id":102,"name":"M3 Cinematic Realism","sort_order":2,"description":"Photographic realism with dramatic, dark color grading and filmic mood","max-char":600,"negative-text-max-char":430,"image":"https://images.blockadelabs.com/images/skybox/gGfOHzfOiAgvkVxHVtg6TDNwWa22SvTluHoRJNTK.webp","image_jpg":"https://images.blockadelabs.com/images/skybox/gGfOHzfOiAgvkVxHVtg6TDNwWa22SvTluHoRJNTK.jpg","model":"Model 3","model_version":"3"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxStyleFamiliesResponseItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Can be of type 'family' or 'style' if the style doesn't belong to any families<br/>
        /// Example: family
        /// </param>
        /// <param name="id">
        /// ID of a type<br/>
        /// Example: 17
        /// </param>
        /// <param name="name">
        /// Name of the menu item<br/>
        /// Example: Model 3 Realistic
        /// </param>
        /// <param name="sortOrder">
        /// Ascending order position in the menu<br/>
        /// Example: 1
        /// </param>
        /// <param name="items">
        /// Collection of styles that belong to a family<br/>
        /// Example: [{"type":"style","id":119,"name":"M3 Photoreal (Featured)","sort_order":1,"description":"Photographic realism with a high degree of flexibility and good visual fidelity","max-char":600,"negative-text-max-char":410,"image":"https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.webp","image_jpg":"https://images.blockadelabs.com/images/skybox/WJgTolgUIXCDZM5LOTeUR2T8IOfZHnq2OQzozqH0.jpg","model":"Model 3","model_version":"3"}, {"type":"style","id":102,"name":"M3 Cinematic Realism","sort_order":2,"description":"Photographic realism with dramatic, dark color grading and filmic mood","max-char":600,"negative-text-max-char":430,"image":"https://images.blockadelabs.com/images/skybox/gGfOHzfOiAgvkVxHVtg6TDNwWa22SvTluHoRJNTK.webp","image_jpg":"https://images.blockadelabs.com/images/skybox/gGfOHzfOiAgvkVxHVtg6TDNwWa22SvTluHoRJNTK.jpg","model":"Model 3","model_version":"3"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSkyboxStyleFamiliesResponseItem(
            string? type,
            int? id,
            string? name,
            int? sortOrder,
            global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem>? items)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.SortOrder = sortOrder;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxStyleFamiliesResponseItem" /> class.
        /// </summary>
        public GetSkyboxStyleFamiliesResponseItem()
        {
        }

    }
}