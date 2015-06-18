//-----------------------------------------------------------------------
// <copyright file="IPersistEntry.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Persisters
{
    using System;
    using DTOs;

    /// <summary>
    /// An entry into a persisted source.
    /// </summary>
    public interface IPersistEntry
    {
        /// <summary>
        /// Gets or sets the entry identifier.
        /// </summary>
        string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the approximate request time to API.
        /// </summary>
        DateTime ForecastRequestTime { get; set; }

        /// <summary>
        /// Gets or sets the forecast.
        /// </summary>
        Forecast Forecast { get; set; }
    }
}
