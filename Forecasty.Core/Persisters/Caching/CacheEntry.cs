//-----------------------------------------------------------------------
// <copyright file="CacheEntry.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Persisters.Caching
{
    using System;
    using DTOs;

    /// <summary>
    /// A Forecast entry in memory.
    /// </summary>
    public class CacheEntry : IPersistEntry
    {
        /// <summary>
        /// Gets or sets the key of the item.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the approximate time the request was sent to the API. Is not 100% accurate. 
        /// </summary>
        public DateTime ForecastRequestTime { get; set; }

        /// <summary>
        /// Gets or sets the Forecast.
        /// </summary>
        public Forecast Forecast { get; set; }
    }
}
