#nullable enable

namespace BlockadeLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSkyboxBatchesStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlockadeLabs.GetSkyboxBatchesStatus?>
    {
        /// <inheritdoc />
        public override global::BlockadeLabs.GetSkyboxBatchesStatus? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::BlockadeLabs.GetSkyboxBatchesStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlockadeLabs.GetSkyboxBatchesStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlockadeLabs.GetSkyboxBatchesStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlockadeLabs.GetSkyboxBatchesStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BlockadeLabs.GetSkyboxBatchesStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
