
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// Example: {"data":[{"id":8442285,"obfuscated_id":"f87f6a4b3784591795bfed30100a9ef6","user_id":1352,"title":"World #8442285","prompt":"dark forest","seed":32061051,"negative_text":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","username":"test","status":"complete","queue_position":0,"file_url":"https://blockade-platform-production.s3.amazonaws.com/images/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","thumb_url":"https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","depth_map_url":"https://blockade-platform-production.s3.amazonaws.com/depths/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_depth-map.jpg?ver=1","remix_imagine_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","remix_obfuscated_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","isMyFavorite":false,"created_at":"2023-08-23T08:51:55\u002B00:00","updated_at":"2023-08-23T08:52:10\u002B00:00","error_message":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","pusher_channel":"status_update_f87f6a4b3784591795bfed30100a9ef6","pusher_event":"status_update","type":"skybox","skybox_style_id":2,"skybox_id":2,"skybox_style_name":"Fantasy","skybox_name":"Fantasy","dispatched_at":"2023-08-23T08:51:56\u002B00:00","processing_at":"2023-08-23T08:51:56\u002B00:00","completed_at":"2023-08-23T08:52:10\u002B00:00"}],"totalCount":18,"has_more":true}
    /// </summary>
    public sealed partial class GetHistoryResponse
    {
        /// <summary>
        /// Example: [{"id":8442285,"obfuscated_id":"f87f6a4b3784591795bfed30100a9ef6","user_id":1352,"title":"World #8442285","prompt":"dark forest","seed":32061051,"negative_text":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","username":"test","status":"complete","queue_position":0,"file_url":"https://blockade-platform-production.s3.amazonaws.com/images/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","thumb_url":"https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","depth_map_url":"https://blockade-platform-production.s3.amazonaws.com/depths/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_depth-map.jpg?ver=1","remix_imagine_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","remix_obfuscated_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","isMyFavorite":false,"created_at":"2023-08-23T08:51:55\u002B00:00","updated_at":"2023-08-23T08:52:10\u002B00:00","error_message":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","pusher_channel":"status_update_f87f6a4b3784591795bfed30100a9ef6","pusher_event":"status_update","type":"skybox","skybox_style_id":2,"skybox_id":2,"skybox_style_name":"Fantasy","skybox_name":"Fantasy","dispatched_at":"2023-08-23T08:51:56\u002B00:00","processing_at":"2023-08-23T08:51:56\u002B00:00","completed_at":"2023-08-23T08:52:10\u002B00:00"}]
        /// </summary>
        /// <example>[{"id":8442285,"obfuscated_id":"f87f6a4b3784591795bfed30100a9ef6","user_id":1352,"title":"World #8442285","prompt":"dark forest","seed":32061051,"negative_text":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","username":"test","status":"complete","queue_position":0,"file_url":"https://blockade-platform-production.s3.amazonaws.com/images/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","thumb_url":"https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","depth_map_url":"https://blockade-platform-production.s3.amazonaws.com/depths/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_depth-map.jpg?ver=1","remix_imagine_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","remix_obfuscated_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","isMyFavorite":false,"created_at":"2023-08-23T08:51:55\u002B00:00","updated_at":"2023-08-23T08:52:10\u002B00:00","error_message":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","pusher_channel":"status_update_f87f6a4b3784591795bfed30100a9ef6","pusher_event":"status_update","type":"skybox","skybox_style_id":2,"skybox_id":2,"skybox_style_name":"Fantasy","skybox_name":"Fantasy","dispatched_at":"2023-08-23T08:51:56\u002B00:00","processing_at":"2023-08-23T08:51:56\u002B00:00","completed_at":"2023-08-23T08:52:10\u002B00:00"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetHistoryResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Example: 18
        /// </summary>
        /// <example>18</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistoryResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: [{"id":8442285,"obfuscated_id":"f87f6a4b3784591795bfed30100a9ef6","user_id":1352,"title":"World #8442285","prompt":"dark forest","seed":32061051,"negative_text":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","username":"test","status":"complete","queue_position":0,"file_url":"https://blockade-platform-production.s3.amazonaws.com/images/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","thumb_url":"https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285.jpg?ver=1","depth_map_url":"https://blockade-platform-production.s3.amazonaws.com/depths/imagine/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_depth-map.jpg?ver=1","remix_imagine_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","remix_obfuscated_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","isMyFavorite":false,"created_at":"2023-08-23T08:51:55\u002B00:00","updated_at":"2023-08-23T08:52:10\u002B00:00","error_message":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","pusher_channel":"status_update_f87f6a4b3784591795bfed30100a9ef6","pusher_event":"status_update","type":"skybox","skybox_style_id":2,"skybox_id":2,"skybox_style_name":"Fantasy","skybox_name":"Fantasy","dispatched_at":"2023-08-23T08:51:56\u002B00:00","processing_at":"2023-08-23T08:51:56\u002B00:00","completed_at":"2023-08-23T08:52:10\u002B00:00"}]
        /// </param>
        /// <param name="totalCount">
        /// Example: 18
        /// </param>
        /// <param name="hasMore">
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetHistoryResponse(
            global::System.Collections.Generic.IList<global::BlockadeLabs.GetHistoryResponseDataItem>? data,
            int? totalCount,
            bool? hasMore)
        {
            this.Data = data;
            this.TotalCount = totalCount;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistoryResponse" /> class.
        /// </summary>
        public GetHistoryResponse()
        {
        }
    }
}