//-----------------------------------------------------------------------
// <copyright file="ForecastIoResponse.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core
{
    using System;
    using DTOs;

    /// <summary>
    /// Response returned for each request.
    /// </summary>
    public class ForecastIoResponse
    {
        /// <summary>
        /// Gets or sets whether or not the request errored.
        /// </summary>
        public bool Error { get; set; }

        /// <summary>
        /// Gets or sets an error message if occurs.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the response was persisted or not.
        /// </summary>
        public bool Persisted { get; set; }

        /// <summary>
        /// Gets or sets the Forecast.
        /// </summary>
        public Forecast Forecast { get; set; }

        /// <summary>
        /// Gets or sets the approximate time the request was made to the API to get the forecast.
        /// </summary>
        public DateTime ForecastRequestTime { get; set; }
    }
}
