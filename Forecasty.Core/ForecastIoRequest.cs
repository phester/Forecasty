//-----------------------------------------------------------------------
// <copyright file="ForecastIoRequest.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core
{
    using System;

    /// <summary>
    /// Information required to get a Forecast from Forecast.io
    /// TODO: Add addition request options.
    /// </summary>
    public class ForecastIoRequest
    {
        /// <summary>
        /// Initializes a new instance of the ForecastIoRequest class.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        /// <param name="latitude">Latitude of location.</param>
        /// <param name="longitude">Longitude of location.</param>
        public ForecastIoRequest(string apiKey, double latitude, double longitude)
        {
            // I.   Validate all requrest data elements are not null or empty.
            // II.  Set request properties.

            // I.
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentNullException("The API key must be supplied to submit the request.");
            }

            // II.
            this.ApiKey = apiKey;
            this.Latitude = latitude;
            this.Longitude = longitude; 
        }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        public string ApiKey { get; private set; }

        /// <summary>
        /// Gets the longitude.
        /// </summary>
        public double Longitude { get; private set; }

        /// <summary>
        /// Gets the latitude.
        /// </summary>
        public double Latitude { get; private set; }

        /// <summary>
        /// Gets what would be the persistent key name.
        /// </summary>
        public string Indetifier
        {
            // TODO Remove
            get { return string.Format("{0}//{1}", this.Latitude, this.Longitude); }
        }

        /// <summary>
        /// Returns a Forecast.Io API url with the data on the request.
        /// </summary>
        /// <returns>Url string.</returns>
        public string GetUrl()
        {
            return string.Format("https://api.forecast.io/forecast/{0}/{1},{2}", this.ApiKey, this.Latitude, this.Longitude);
        }
    }
}
