//-----------------------------------------------------------------------
// <copyright file="DataPoint.cs" company="Paul Hester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.DTOs
{
    using Newtonsoft.Json;

    /// <summary>
    /// A data point object represents the various weather phenomena occurring at a specific instant of time, and has many varied properties.
    /// </summary>
    public class DataPoint
    {
        /// <summary>
        /// Gets or sets the UNIX time (that is, seconds since midnight GMT on 1 Jan 1970) at which this data point occurs.
        /// </summary>
        [JsonProperty("time")]
        public ulong Time { get; set; }

        /// <summary>
        /// Gets or sets a human-readable text summary of this data point.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets a machine-readable text summary of this data point, suitable for selecting an icon for display. If defined, this property will have one of the following values: clear-day, clear-night, rain, snow, sleet, wind, fog, cloudy, partly-cloudy-day, or partly-cloudy-night. (Developers should ensure that a sensible default is defined, as additional values, such as hail, thunderstorm, or tornado, may be defined in the future.)
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the UNIX time (that is, seconds since midnight GMT on 1 Jan 1970) of the last sunrise before and first sunset after the solar noon closest to local noon on the given day. (Note: near the poles, these may occur on a different day entirely!).
        /// </summary>
        [JsonProperty("sunriseTime")]
        public ulong SunruseTime { get; set; }

        /// <summary>
        /// Gets or sets the UNIX time (that is, seconds since midnight GMT on 1 Jan 1970) of the last sunrise before and first sunset after the solar noon closest to local noon on the given day. (Note: near the poles, these may occur on a different day entirely!).
        /// </summary>
        [JsonProperty("sunsetTime")]
        public ulong SunsetTime { get; set; }

        /// <summary>
        /// Gets or sets a number representing the fractional part of the lunation number of the given day. This can be thought of as the “percentage complete” of the current lunar month: a value of 0 represents a new moon, a value of 0.25 represents a first quarter moon, a value of 0.5 represents a full moon, and a value of 0.75 represents a last quarter moon. (The ranges in between these represent waxing crescent, waxing gibbous, waning gibbous, and waning crescent moons, respectively.)
        /// </summary>
        [JsonProperty("moonPhase")]
        public double MoonPhase { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the distance to the nearest storm in miles. (This value is very approximate and should not be used in scenarios requiring accurate results. In particular, a storm distance of zero doesn’t necessarily refer to a storm at the requested location, but rather a storm in the vicinity of that location.)
        /// </summary>
        [JsonProperty("nearestStormDistance")]
        public double NearestStormDistance { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the direction of the nearest storm in degrees, with true north at 0° and progressing clockwise. (If nearestStormDistance is zero, then this value will not be defined. The caveats that apply to nearestStormDistance also apply to this value.)
        /// </summary>
        [JsonProperty("nearestStormBearing")]
        public double NearestStormBearing { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the average expected intensity (in inches of liquid water per hour) of precipitation occurring at the given time conditional on probability (that is, assuming any precipitation occurs at all). A very rough guide is that a value of 0 in./hr. corresponds to no precipitation, 0.002 in./hr. corresponds to very light precipitation, 0.017 in./hr. corresponds to light precipitation, 0.1 in./hr. corresponds to moderate precipitation, and 0.4 in./hr. corresponds to heavy precipitation.
        /// </summary>
        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        /// <summary>
        /// Gets or sets a numerical values representing the maximum expected intensity of precipitation (and the UNIX time at which it occurs) on the given day in inches of liquid water per hour.
        /// </summary>
        [JsonProperty("precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        /// <summary>
        /// Gets or sets a numerical value between 0 and 1 (inclusive) representing the probability of precipitation occurring at the given time.
        /// </summary>
        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        /// <summary>
        /// Gets or sets a string representing the type of precipitation occurring at the given time. 
        /// </summary>
        [JsonProperty("precipType")]
        public string PrecipType { get; set; }

        /// <summary>
        /// Gets or sets the amount of snowfall accumulation expected to occur on the given day, in inches. 
        /// </summary>
        [JsonProperty("precipAccumulation")]
        public double PrecipAccumulation { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the temperature at the given time in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the minimum apparent temperature on the given day in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the time the minimum apparent temperature occurs on the given day.
        /// </summary>
        [JsonProperty("temperatureMinTime")]
        public ulong TemperatureMinTime { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the maximum apparent temperature on the given day in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the time the maximum apparent temperature occurs on the given day.
        /// </summary>
        [JsonProperty("temperatureMaxTime")]
        public ulong TemperatureMaxTime { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the apparent (or “feels like”) temperature at the given time in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the minimum apparent temperature on the given day in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("apparentTemperatureMin")]
        public double ApparentTemperatureMin { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the time the minimum apparent temperature occurs on the given day.
        /// </summary>
        [JsonProperty("apparentTemperatureMinTime")]
        public ulong ApparentTemperatureMinTime { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the maximum apparent temperature on the given day in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("apparentTemperatureMax")]
        public double ApparentTemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the time the maximum apparent temperature occurs on the given day.
        /// </summary>
        [JsonProperty("apparentTemperatureMaxTime")]
        public ulong ApparentTemperatureMaxTime { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the dew point at the given time in degrees Fahrenheit.
        /// </summary>
        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the wind speed in miles per hour.
        /// </summary>
        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the direction that the wind is coming from in degrees, with true north at 0° and progressing clockwise.
        /// </summary>
        [JsonProperty("windBearing")]
        public double WindBearing { get; set; }

        /// <summary>
        /// Gets or sets a numerical value between 0 and 1 (inclusive) representing the percentage of sky occluded by clouds. A value of 0 corresponds to clear sky, 0.4 to scattered clouds, 0.75 to broken cloud cover, and 1 to completely overcast skies.
        /// </summary>
        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        /// <summary>
        /// Gets or sets a numerical value between 0 and 1 (inclusive) representing the percentage of sky occluded by clouds. A value of 0 corresponds to clear sky, 0.4 to scattered clouds, 0.75 to broken cloud cover, and 1 to completely overcast skies.
        /// </summary>
        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the sea-level air pressure in millibars.
        /// </summary>
        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the average visibility in miles, capped at 10 miles.
        /// </summary>
        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        /// <summary>
        /// Gets or sets a numerical value representing the columnar density of total atmospheric ozone at the given time in Dobson units.
        /// </summary>
        [JsonProperty("ozone")]
        public double Ozone { get; set; }
    }
}
