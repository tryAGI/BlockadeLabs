
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// Example: {"request":{"id":46,"obfuscated_id":"c60354672339614111cee85d21253244","user_id":8,"title":"World #46","prompt":"dark forest","seed":50702979,"negative_text":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","username":"test","status":"complete","queue_position":0,"file_url":"https://blockade-platform-production.s3.amazonaws.com/images/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1","thumb_url":"https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1","depth_map_url":"https://blockade-platform-production.s3.amazonaws.com/depths/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1","remix_imagine_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","remix_obfuscated_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","isMyFavorite":false,"created_at":"2023-08-21T13:35:14\u002B00:00","updated_at":"2023-08-22T06:46:00\u002B00:00","error_message":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","pusher_channel":"status_update_c60354672339614111cee85d21253244","pusher_event":"status_update","type":"skybox","skybox_style_id":2,"skybox_id":2,"skybox_style_name":"V2 Fantasy Lands","skybox_name":"V2 Fantasy Lands","dispatched_at":"2023-08-22T06:45:28\u002B00:00","processing_at":"2023-08-22T06:45:55\u002B00:00","completed_at":"2023-08-22T06:46:00\u002B00:00"}}
    /// </summary>
    public sealed partial class GetSkyboxByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::BlockadeLabs.GetSkyboxByIdResponseRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxByIdResponse" /> class.
        /// </summary>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSkyboxByIdResponse(
            global::BlockadeLabs.GetSkyboxByIdResponseRequest? request)
        {
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxByIdResponse" /> class.
        /// </summary>
        public GetSkyboxByIdResponse()
        {
        }
    }
}