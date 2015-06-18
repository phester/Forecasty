//-----------------------------------------------------------------------
// <copyright file="Flag.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.DTOs
{
    using Newtonsoft.Json;

    /// <summary>
    /// The flags object contains various metadata information related to the request. Such objects may optionally contain any of the following properties:
    /// </summary>
    [JsonObject("flags")]
    public class Flag
    {
        /// <summary>
        /// Gets or sets a property that indicates whether or not the Dark Sky data source supports the given location, but a temporary error (such as a radar station being down for maintenance) has made the data unavailable.
        /// </summary>
        [JsonProperty("Forecasty-unavailable")]
        public string ForecastyUnavailable { get; set; }

        /// <summary>
        /// Gets or sets an array of IDs for each radar station utilized in servicing this request.
        /// </summary>
        [JsonProperty("Forecasty-stations")]
        public string[] ForecastyStations { get; set; }

        /// <summary>
        /// Gets or sets an array of IDs for each DataPoint station utilized in servicing this request.
        /// </summary>
        [JsonProperty("datatpoint-stations")]
        public string[] DataPointStations { get; set; }

        /// <summary>
        /// Gets or sets an array of IDs for each ISD station utilized in servicing this request.
        /// </summary>
        [JsonProperty("isd-stations")]
        public string[] IsdStations { get; set; }

        /// <summary>
        /// Gets or sets an array of IDs for each LAMP station utilized in servicing this request.
        /// </summary>
        [JsonProperty("lamp-stations")]
        public string[] LampStations { get; set; }

        /// <summary>
        /// Gets or sets an array of IDs for each METAR station utilized in servicing this request.
        /// </summary>
        [JsonProperty("metar-stations")]
        public string[] MetarStations { get; set; }

        /// <summary>
        /// Gets or sets this property that indicates whether or not data from "api.met.no" was utilized in order to facilitate this request (as per their license agreement).
        /// </summary>
        [JsonProperty("metno-license")]
        public string MetnoLicense { get; set; }

        /// <summary>
        /// Gets or sets an array of IDs for each data source utilized in servicing this request.
        /// </summary>
        [JsonProperty("sources")]
        public string[] Sources { get; set; }

        /// <summary>
        /// Gets or sets this property that indicates which units were used for the data in this request.
        /// </summary>
        [JsonProperty("units")]
        public string Units { get; set; }
    }
}
