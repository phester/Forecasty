//-----------------------------------------------------------------------
// <copyright file="Forecast.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.DTOs
{
    using Newtonsoft.Json;

    /// <summary>
    /// The forecast information being requested.
    /// </summary>
    public class Forecast
    {
        /// <summary>
        /// Gets or sets the requested latitude.
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the requested longitude.
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the IANA time zone name for the requested location.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the current time zone offset in hours from GMT.
        /// </summary>
        [JsonProperty("offset")]
        public double Offset { get; set; }

        /// <summary>
        /// Gets or sets a data point containing the current weather conditions at the requested location.
        /// </summary>
        [JsonProperty("currently")]
        public DataPoint Currently { get; set; }

        /// <summary>
        /// Gets or sets a data block containing the weather conditions minute-by-minute for the next hour.
        /// </summary>
        [JsonProperty("minutely")]
        public DataBlock Minutely { get; set; }

        /// <summary>
        /// Gets or sets a data block containing the weather conditions hour-by-hour for the next two days.
        /// </summary>
        [JsonProperty("hourly")]
        public DataBlock Hourly { get; set; }

        /// <summary>
        /// Gets or sets a data block (see below) containing the weather conditions day-by-day for the next week.
        /// </summary>
        [JsonProperty("daily")]
        public DataBlock Daily { get; set; }

        /// <summary>
        /// Gets or sets an array of alert objects, which, contains any severe weather alerts, issued by a governmental weather authority, pertinent to the requested location.
        /// </summary>
        [JsonProperty("alerts")]
        public Alert[] Alerts { get; set; }

        /// <summary>
        /// Gets or sets an object containing miscellaneous metadata concerning this request.
        /// </summary>
        [JsonProperty("flags")]
        public Flag Flags { get; set; }
    }
}
