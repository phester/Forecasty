//-----------------------------------------------------------------------
// <copyright file="Alert.cs" company="Paul Hester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.DTOs
{
    using Newtonsoft.Json;

    /// <summary>
    /// An alert object represents a severe weather warning issued for the requested location by a governmental authority.
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// Gets or sets a short text summary of the alert.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the UNIX time (that is, seconds since midnight GMT on 1 Jan 1970) at which the alert will cease to be valid.
        /// </summary>
        [JsonProperty("expires")]
        public ulong Expires { get; set; }

        /// <summary>
        /// Gets or sets a detailed text description of the alert from the appropriate weather service.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets an HTTP(S) URI that contains detailed information about the alert.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
