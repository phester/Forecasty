//-----------------------------------------------------------------------
// <copyright file="ForecastIoBaseProvider.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Providers
{
    using DTOs;
    using Helpers;
    using Newtonsoft.Json;

    /// <summary>
    /// Abstract base Provider for all other providers to inherit.
    /// </summary>
    public abstract class ForecastIoBaseProvider
    {
        /// <summary>
        /// Get a Forecast Response.
        /// </summary>
        /// <param name="request">The requests data.</param>
        /// <returns>The response information per request.</returns>
        public abstract ForecastIoResponse GetForecast(ForecastIoRequest request);

        /// <summary>
        /// Protected call to API to get a Forecast.
        /// </summary>
        /// <param name="request">The request parameters for the call.</param>
        /// <returns>A forecast instance.</returns>
        protected Forecast Call(ForecastIoRequest request)
        {
            // TODO: Handle exceptions.
            return JsonConvert.DeserializeObject<Forecast>(HttpClient.GetString(request.GetUrl()));
        }
    }
}
