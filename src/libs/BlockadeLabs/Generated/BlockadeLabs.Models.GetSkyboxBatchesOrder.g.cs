
#nullable enable

namespace BlockadeLabs
{
    /// <summary>
    /// Default Value: DESC
    /// </summary>
    public enum GetSkyboxBatchesOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSkyboxBatchesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSkyboxBatchesOrder value)
        {
            return value switch
            {
                GetSkyboxBatchesOrder.Asc => "ASC",
                GetSkyboxBatchesOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSkyboxBatchesOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetSkyboxBatchesOrder.Asc,
                "DESC" => GetSkyboxBatchesOrder.Desc,
                _ => null,
            };
        }
    }
}