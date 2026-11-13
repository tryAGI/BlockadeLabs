
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSkyboxBatchesStatus
    {
        /// <summary>
        ///
        /// </summary>
        Abort,
        /// <summary>
        ///
        /// </summary>
        Dispatched,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Finalized,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSkyboxBatchesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSkyboxBatchesStatus value)
        {
            return value switch
            {
                GetSkyboxBatchesStatus.Abort => "abort",
                GetSkyboxBatchesStatus.Dispatched => "dispatched",
                GetSkyboxBatchesStatus.Error => "error",
                GetSkyboxBatchesStatus.Finalized => "finalized",
                GetSkyboxBatchesStatus.Pending => "pending",
                GetSkyboxBatchesStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSkyboxBatchesStatus? ToEnum(string value)
        {
            return value switch
            {
                "abort" => GetSkyboxBatchesStatus.Abort,
                "dispatched" => GetSkyboxBatchesStatus.Dispatched,
                "error" => GetSkyboxBatchesStatus.Error,
                "finalized" => GetSkyboxBatchesStatus.Finalized,
                "pending" => GetSkyboxBatchesStatus.Pending,
                "processing" => GetSkyboxBatchesStatus.Processing,
                _ => null,
            };
        }
    }
}