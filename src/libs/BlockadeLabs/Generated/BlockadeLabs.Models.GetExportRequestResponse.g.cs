
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// Example: {"file_url":"https://blockade-platform-production.s3.amazonaws.com/exports/equirectangular-png/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_equirectangular-png.png","id":"b26584eb869cdebeecdf009b7c17c73b","skybox_obfuscated_id":"08ccb4947d546dec0ce454538ebb51a8","type":"equirectangular-png","type_id":2,"status":"complete","queue_position":0,"error_message":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","pusher_channel":"export_status_update_b26584eb869cdebeecdf009b7c17c73b","pusher_event":"status_update","webhook_url":"test_weebhook","created_at":"2023-08-23T13:52:59.000000Z"}
    /// </summary>
    public sealed partial class GetExportRequestResponse
    {
        /// <summary>
        /// URL for the exported file<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/exports/equirectangular-png/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_equirectangular-png.png
        /// </summary>
        /// <example>https://blockade-platform-production.s3.amazonaws.com/exports/equirectangular-png/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_equirectangular-png.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// ID of your export request. It can be used to track progress or cancel the request<br/>
        /// Example: b26584eb869cdebeecdf009b7c17c73b
        /// </summary>
        /// <example>b26584eb869cdebeecdf009b7c17c73b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Obfuscated ID of the skybox for which the export was requested<br/>
        /// Example: 08ccb4947d546dec0ce454538ebb51a8
        /// </summary>
        /// <example>08ccb4947d546dec0ce454538ebb51a8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_obfuscated_id")]
        public string? SkyboxObfuscatedId { get; set; }

        /// <summary>
        /// Requested export type<br/>
        /// Example: equirectangular-png
        /// </summary>
        /// <example>equirectangular-png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Requested export type ID<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Initially status is set as 'pending' after you send the export request. Status will change from one state to another and you will get updates for each one if you are using pusher or webhook: pending -&gt; dispatched -&gt; processing -&gt; complete. Also you can get abort or error and in some cases (ie. for JPG and Depth Map export) this will be immediately set to 'complete'.<br/>
        /// Example: complete
        /// </summary>
        /// <example>complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Position of your request in a export generation queue<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        public int? QueuePosition { get; set; }

        /// <summary>
        /// If status=error here you should see the error message<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Pusher channel name used to track export generation progress<br/>
        /// Example: export_status_update_b26584eb869cdebeecdf009b7c17c73b
        /// </summary>
        /// <example>export_status_update_b26584eb869cdebeecdf009b7c17c73b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_channel")]
        public string? PusherChannel { get; set; }

        /// <summary>
        /// Pusher channel event used to track generation<br/>
        /// Example: status_update
        /// </summary>
        /// <example>status_update</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_event")]
        public string? PusherEvent { get; set; }

        /// <summary>
        /// Example: test_weebhook
        /// </summary>
        /// <example>test_weebhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Time created<br/>
        /// Example: 2023-08-23T13:52:59.000000Z
        /// </summary>
        /// <example>2023-08-23T13:52:59.000000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExportRequestResponse" /> class.
        /// </summary>
        /// <param name="fileUrl">
        /// URL for the exported file<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/exports/equirectangular-png/vr360-intricate-fantasy-art-dark-forest-vr360-c4d-computer-r_8442285_equirectangular-png.png
        /// </param>
        /// <param name="id">
        /// ID of your export request. It can be used to track progress or cancel the request<br/>
        /// Example: b26584eb869cdebeecdf009b7c17c73b
        /// </param>
        /// <param name="skyboxObfuscatedId">
        /// Obfuscated ID of the skybox for which the export was requested<br/>
        /// Example: 08ccb4947d546dec0ce454538ebb51a8
        /// </param>
        /// <param name="type">
        /// Requested export type<br/>
        /// Example: equirectangular-png
        /// </param>
        /// <param name="typeId">
        /// Requested export type ID<br/>
        /// Example: 2
        /// </param>
        /// <param name="status">
        /// Initially status is set as 'pending' after you send the export request. Status will change from one state to another and you will get updates for each one if you are using pusher or webhook: pending -&gt; dispatched -&gt; processing -&gt; complete. Also you can get abort or error and in some cases (ie. for JPG and Depth Map export) this will be immediately set to 'complete'.<br/>
        /// Example: complete
        /// </param>
        /// <param name="queuePosition">
        /// Position of your request in a export generation queue<br/>
        /// Example: 0
        /// </param>
        /// <param name="errorMessage">
        /// If status=error here you should see the error message<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pusherChannel">
        /// Pusher channel name used to track export generation progress<br/>
        /// Example: export_status_update_b26584eb869cdebeecdf009b7c17c73b
        /// </param>
        /// <param name="pusherEvent">
        /// Pusher channel event used to track generation<br/>
        /// Example: status_update
        /// </param>
        /// <param name="webhookUrl">
        /// Example: test_weebhook
        /// </param>
        /// <param name="createdAt">
        /// Time created<br/>
        /// Example: 2023-08-23T13:52:59.000000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExportRequestResponse(
            string? fileUrl,
            string? id,
            string? skyboxObfuscatedId,
            string? type,
            int? typeId,
            string? status,
            int? queuePosition,
            string? errorMessage,
            string? pusherChannel,
            string? pusherEvent,
            string? webhookUrl,
            string? createdAt)
        {
            this.FileUrl = fileUrl;
            this.Id = id;
            this.SkyboxObfuscatedId = skyboxObfuscatedId;
            this.Type = type;
            this.TypeId = typeId;
            this.Status = status;
            this.QueuePosition = queuePosition;
            this.ErrorMessage = errorMessage;
            this.PusherChannel = pusherChannel;
            this.PusherEvent = pusherEvent;
            this.WebhookUrl = webhookUrl;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExportRequestResponse" /> class.
        /// </summary>
        public GetExportRequestResponse()
        {
        }

    }
}