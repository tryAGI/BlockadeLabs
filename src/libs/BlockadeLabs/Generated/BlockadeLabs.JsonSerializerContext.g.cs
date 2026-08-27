
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::BlockadeLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GenerateSkyboxRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.RequestExportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GenerateSkyboxResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStylesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxStylesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxByIdResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.CancelGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxByObfuscatedIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetSkyboxByObfuscatedIdResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlockadeLabs.GetHistoryResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetHistoryResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.CancelAllPendingGenerationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlockadeLabs.GetExportTypesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetExportTypesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.RequestExportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.GetExportRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlockadeLabs.CancelExportRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlockadeLabs.GetSkyboxStylesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlockadeLabs.GetSkyboxStyleFamiliesResponseItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlockadeLabs.GetHistoryResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlockadeLabs.GetExportTypesResponseItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}