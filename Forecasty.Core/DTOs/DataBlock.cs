//-----------------------------------------------------------------------
// <copyright file="DataBlock.cs" company="Paul Hester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.DTOs
{
    using Newtonsoft.Json;

    /// <summary>
    /// A data block object represents the various weather phenomena occurring over a period of time. 
    /// </summary>
    public class DataBlock
    {
        /// <summary>
        /// Gets or sets a human-readable text summary of this data block.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets a machine-readable text summary of this data block.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets an array of data point objects, ordered by time, which together describe the weather conditions at the requested location over time.
        /// </summary>
        [JsonProperty("data")]
        public DataPoint[] Data { get; set; }
    }
}
