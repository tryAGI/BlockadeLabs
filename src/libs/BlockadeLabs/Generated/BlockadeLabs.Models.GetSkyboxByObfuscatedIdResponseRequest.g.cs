
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSkyboxByObfuscatedIdResponseRequest
    {
        /// <summary>
        /// ID of your generation. It can be used to track generation progress or to cancel the generation<br/>
        /// Example: 46
        /// </summary>
        /// <example>46</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Hash id of your generation<br/>
        /// Example: c60354672339614111cee85d21253244
        /// </summary>
        /// <example>c60354672339614111cee85d21253244</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("obfuscated_id")]
        public string? ObfuscatedId { get; set; }

        /// <summary>
        /// Your user id<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Generation title<br/>
        /// Example: World #46
        /// </summary>
        /// <example>World #46</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Prompt text used to generate skybox<br/>
        /// Example: dark forest
        /// </summary>
        /// <example>dark forest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Seed number used to generate skybox<br/>
        /// Example: 50702979
        /// </summary>
        /// <example>50702979</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_text")]
        public string? NegativeText { get; set; }

        /// <summary>
        /// Your username<br/>
        /// Example: test
        /// </summary>
        /// <example>test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Initially status is set as 'pending' after you send a generation request. Status will change from one state to another and you will get updates for each one if you are using pusher or webhook: pending -&gt; dispatched -&gt; processing -&gt; complete. Also you can get abort or error.<br/>
        /// Example: complete
        /// </summary>
        /// <example>complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Position of your request in a generation queue<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        public int? QueuePosition { get; set; }

        /// <summary>
        /// Generated skybox image (6144x3072 pixels)<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/images/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1
        /// </summary>
        /// <example>https://blockade-platform-production.s3.amazonaws.com/images/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Generated skybox thumbnail (672x336 pixels)<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1
        /// </summary>
        /// <example>https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumb_url")]
        public string? ThumbUrl { get; set; }

        /// <summary>
        /// Generated skybox depth map image (2048x1024 pixels)<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/depths/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1
        /// </summary>
        /// <example>https://blockade-platform-production.s3.amazonaws.com/depths/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth_map_url")]
        public string? DepthMapUrl { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_imagine_id")]
        public string? RemixImagineId { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_obfuscated_id")]
        public string? RemixObfuscatedId { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMyFavorite")]
        public bool? IsMyFavorite { get; set; }

        /// <summary>
        /// Time created<br/>
        /// Example: 2023-08-21T13:35:14+00:00
        /// </summary>
        /// <example>2023-08-21T13:35:14+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Time updated<br/>
        /// Example: 2023-08-22T06:46:00+00:00
        /// </summary>
        /// <example>2023-08-22T06:46:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// If status=error here you should see the error message<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Pusher channel name used to track generation progress<br/>
        /// Example: status_update_c60354672339614111cee85d21253244
        /// </summary>
        /// <example>status_update_c60354672339614111cee85d21253244</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_channel")]
        public string? PusherChannel { get; set; }

        /// <summary>
        /// Pusher channel event used to track generation progress<br/>
        /// Example: status_update
        /// </summary>
        /// <example>status_update</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_event")]
        public string? PusherEvent { get; set; }

        /// <summary>
        /// Type of generation (currently "skybox" is the only one)<br/>
        /// Example: skybox
        /// </summary>
        /// <example>skybox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Skybox style ID used to generate skybox<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_style_id")]
        public int? SkyboxStyleId { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_id")]
        public int? SkyboxId { get; set; }

        /// <summary>
        /// Skybox style name used to generate skybox<br/>
        /// Example: V2 Fantasy Lands
        /// </summary>
        /// <example>V2 Fantasy Lands</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_style_name")]
        public string? SkyboxStyleName { get; set; }

        /// <summary>
        /// Example: V2 Fantasy Lands
        /// </summary>
        /// <example>V2 Fantasy Lands</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skybox_name")]
        public string? SkyboxName { get; set; }

        /// <summary>
        /// Time dispatched<br/>
        /// Example: 2023-08-22T06:45:28+00:00
        /// </summary>
        /// <example>2023-08-22T06:45:28+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatched_at")]
        public string? DispatchedAt { get; set; }

        /// <summary>
        /// Time processing started<br/>
        /// Example: 2023-08-22T06:45:55+00:00
        /// </summary>
        /// <example>2023-08-22T06:45:55+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_at")]
        public string? ProcessingAt { get; set; }

        /// <summary>
        /// Time completed<br/>
        /// Example: 2023-08-22T06:46:00+00:00
        /// </summary>
        /// <example>2023-08-22T06:46:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxByObfuscatedIdResponseRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of your generation. It can be used to track generation progress or to cancel the generation<br/>
        /// Example: 46
        /// </param>
        /// <param name="obfuscatedId">
        /// Hash id of your generation<br/>
        /// Example: c60354672339614111cee85d21253244
        /// </param>
        /// <param name="userId">
        /// Your user id<br/>
        /// Example: 8
        /// </param>
        /// <param name="title">
        /// Generation title<br/>
        /// Example: World #46
        /// </param>
        /// <param name="prompt">
        /// Prompt text used to generate skybox<br/>
        /// Example: dark forest
        /// </param>
        /// <param name="seed">
        /// Seed number used to generate skybox<br/>
        /// Example: 50702979
        /// </param>
        /// <param name="negativeText">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="username">
        /// Your username<br/>
        /// Example: test
        /// </param>
        /// <param name="status">
        /// Initially status is set as 'pending' after you send a generation request. Status will change from one state to another and you will get updates for each one if you are using pusher or webhook: pending -&gt; dispatched -&gt; processing -&gt; complete. Also you can get abort or error.<br/>
        /// Example: complete
        /// </param>
        /// <param name="queuePosition">
        /// Position of your request in a generation queue<br/>
        /// Example: 0
        /// </param>
        /// <param name="fileUrl">
        /// Generated skybox image (6144x3072 pixels)<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/images/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1
        /// </param>
        /// <param name="thumbUrl">
        /// Generated skybox thumbnail (672x336 pixels)<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/thumbs/imagine/thumb_futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1
        /// </param>
        /// <param name="depthMapUrl">
        /// Generated skybox depth map image (2048x1024 pixels)<br/>
        /// Example: https://blockade-platform-production.s3.amazonaws.com/depths/imagine/futuristic_microdetailed_vr_scifi_concept_art_cinematic_vr_neon__dbe7f963dc23699c__2757929_dbe7.jpg?ver=1
        /// </param>
        /// <param name="remixImagineId">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="remixObfuscatedId">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isMyFavorite">
        /// Example: false
        /// </param>
        /// <param name="createdAt">
        /// Time created<br/>
        /// Example: 2023-08-21T13:35:14+00:00
        /// </param>
        /// <param name="updatedAt">
        /// Time updated<br/>
        /// Example: 2023-08-22T06:46:00+00:00
        /// </param>
        /// <param name="errorMessage">
        /// If status=error here you should see the error message<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pusherChannel">
        /// Pusher channel name used to track generation progress<br/>
        /// Example: status_update_c60354672339614111cee85d21253244
        /// </param>
        /// <param name="pusherEvent">
        /// Pusher channel event used to track generation progress<br/>
        /// Example: status_update
        /// </param>
        /// <param name="type">
        /// Type of generation (currently "skybox" is the only one)<br/>
        /// Example: skybox
        /// </param>
        /// <param name="skyboxStyleId">
        /// Skybox style ID used to generate skybox<br/>
        /// Example: 2
        /// </param>
        /// <param name="skyboxId">
        /// Example: 2
        /// </param>
        /// <param name="skyboxStyleName">
        /// Skybox style name used to generate skybox<br/>
        /// Example: V2 Fantasy Lands
        /// </param>
        /// <param name="skyboxName">
        /// Example: V2 Fantasy Lands
        /// </param>
        /// <param name="dispatchedAt">
        /// Time dispatched<br/>
        /// Example: 2023-08-22T06:45:28+00:00
        /// </param>
        /// <param name="processingAt">
        /// Time processing started<br/>
        /// Example: 2023-08-22T06:45:55+00:00
        /// </param>
        /// <param name="completedAt">
        /// Time completed<br/>
        /// Example: 2023-08-22T06:46:00+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSkyboxByObfuscatedIdResponseRequest(
            int? id,
            string? obfuscatedId,
            int? userId,
            string? title,
            string? prompt,
            int? seed,
            string? negativeText,
            string? username,
            string? status,
            int? queuePosition,
            string? fileUrl,
            string? thumbUrl,
            string? depthMapUrl,
            string? remixImagineId,
            string? remixObfuscatedId,
            bool? isMyFavorite,
            string? createdAt,
            string? updatedAt,
            string? errorMessage,
            string? pusherChannel,
            string? pusherEvent,
            string? type,
            int? skyboxStyleId,
            int? skyboxId,
            string? skyboxStyleName,
            string? skyboxName,
            string? dispatchedAt,
            string? processingAt,
            string? completedAt)
        {
            this.Id = id;
            this.ObfuscatedId = obfuscatedId;
            this.UserId = userId;
            this.Title = title;
            this.Prompt = prompt;
            this.Seed = seed;
            this.NegativeText = negativeText;
            this.Username = username;
            this.Status = status;
            this.QueuePosition = queuePosition;
            this.FileUrl = fileUrl;
            this.ThumbUrl = thumbUrl;
            this.DepthMapUrl = depthMapUrl;
            this.RemixImagineId = remixImagineId;
            this.RemixObfuscatedId = remixObfuscatedId;
            this.IsMyFavorite = isMyFavorite;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ErrorMessage = errorMessage;
            this.PusherChannel = pusherChannel;
            this.PusherEvent = pusherEvent;
            this.Type = type;
            this.SkyboxStyleId = skyboxStyleId;
            this.SkyboxId = skyboxId;
            this.SkyboxStyleName = skyboxStyleName;
            this.SkyboxName = skyboxName;
            this.DispatchedAt = dispatchedAt;
            this.ProcessingAt = processingAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkyboxByObfuscatedIdResponseRequest" /> class.
        /// </summary>
        public GetSkyboxByObfuscatedIdResponseRequest()
        {
        }

    }
}