
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GenerateSkyboxRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.SubmitSkyboxBatchRequest? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.RequestExportRequest? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxBatchesOrder? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxBatchesStatus? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GenerateSkyboxResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.SubmitSkyboxBatchResponse? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxBatchesResponse? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStylesResponseItem>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxStylesResponseItem? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxByIdResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxByIdResponseRequest? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.CancelGenerationResponse? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxByObfuscatedIdResponse? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetSkyboxByObfuscatedIdResponseRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetHistoryResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetHistoryResponseDataItem>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetHistoryResponseDataItem? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.CancelAllPendingGenerationsResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.DeleteResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlockadeLabs.GetExportTypesResponseItem>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetExportTypesResponseItem? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.RequestExportResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.GetExportRequestResponse? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlockadeLabs.CancelExportRequestResponse? Type35 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlockadeLabs.GetSkyboxStylesResponseItem>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlockadeLabs.GetHistoryResponseDataItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlockadeLabs.GetExportTypesResponseItem>? ListType5 { get; set; }
    }
}