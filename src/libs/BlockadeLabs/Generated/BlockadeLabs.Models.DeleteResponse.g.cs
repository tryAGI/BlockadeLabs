
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// Example: {"success":"Item deleted successfully","id":"46"}
    /// </summary>
    public sealed partial class DeleteResponse
    {
        /// <summary>
        /// Example: Item deleted successfully
        /// </summary>
        /// <example>Item deleted successfully</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public string? Success { get; set; }

        /// <summary>
        /// Example: 46
        /// </summary>
        /// <example>46</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: Item deleted successfully
        /// </param>
        /// <param name="id">
        /// Example: 46
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteResponse(
            string? success,
            string? id)
        {
            this.Success = success;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponse" /> class.
        /// </summary>
        public DeleteResponse()
        {
        }

    }
}