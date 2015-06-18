//-----------------------------------------------------------------------
// <copyright file="ForecastIoProvider.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Providers
{
    using System;

    /// <summary>
    /// Provides a type to make calls to the Forecast.Io API.
    /// </summary>
    public class ForecastIoProvider : ForecastIoBaseProvider
    {
        /// <summary>
        /// API call to Forecast.Io to get weather data. 
        /// </summary>
        /// <param name="request">Request information</param>
        /// <returns>The response information per request.</returns>
        public override ForecastIoResponse GetForecast(ForecastIoRequest request)
        {
            return new ForecastIoResponse()
            {
                Forecast = this.Call(request),
                ForecastRequestTime = DateTime.UtcNow
            };
        }
    }
}
