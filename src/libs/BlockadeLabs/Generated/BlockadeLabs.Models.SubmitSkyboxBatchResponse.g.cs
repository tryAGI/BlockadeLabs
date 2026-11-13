
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitSkyboxBatchResponse
    {
        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obfuscated_id")]
        public string? ObfuscatedId { get; set; }

        /// <summary>
        /// pending, dispatched, processing, finalized, error, or abort.<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("successfully_submitted")]
        public int? SuccessfullySubmitted { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        public int? Errored { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aborted")]
        public int? Aborted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_channel")]
        public string? PusherChannel { get; set; }

        /// <summary>
        /// Example: status_update
        /// </summary>
        /// <example>status_update</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_event")]
        public string? PusherEvent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Generations that failed during submit. Each item has index, message, and status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submission_errors")]
        public global::System.Collections.Generic.IList<object>? SubmissionErrors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<object>? Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSkyboxBatchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 42
        /// </param>
        /// <param name="obfuscatedId"></param>
        /// <param name="status">
        /// pending, dispatched, processing, finalized, error, or abort.<br/>
        /// Example: pending
        /// </param>
        /// <param name="quantity">
        /// Example: 3
        /// </param>
        /// <param name="successfullySubmitted">
        /// Example: 3
        /// </param>
        /// <param name="completed">
        /// Example: 0
        /// </param>
        /// <param name="errored">
        /// Example: 0
        /// </param>
        /// <param name="aborted">
        /// Example: 0
        /// </param>
        /// <param name="pusherChannel"></param>
        /// <param name="pusherEvent">
        /// Example: status_update
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="submissionErrors">
        /// Generations that failed during submit. Each item has index, message, and status.
        /// </param>
        /// <param name="generations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitSkyboxBatchResponse(
            int? id,
            string? obfuscatedId,
            string? status,
            int? quantity,
            int? successfullySubmitted,
            int? completed,
            int? errored,
            int? aborted,
            string? pusherChannel,
            string? pusherEvent,
            string? webhookUrl,
            global::System.Collections.Generic.IList<object>? submissionErrors,
            global::System.Collections.Generic.IList<object>? generations)
        {
            this.Id = id;
            this.ObfuscatedId = obfuscatedId;
            this.Status = status;
            this.Quantity = quantity;
            this.SuccessfullySubmitted = successfullySubmitted;
            this.Completed = completed;
            this.Errored = errored;
            this.Aborted = aborted;
            this.PusherChannel = pusherChannel;
            this.PusherEvent = pusherEvent;
            this.WebhookUrl = webhookUrl;
            this.SubmissionErrors = submissionErrors;
            this.Generations = generations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSkyboxBatchResponse" /> class.
        /// </summary>
        public SubmitSkyboxBatchResponse()
        {
        }

    }
}