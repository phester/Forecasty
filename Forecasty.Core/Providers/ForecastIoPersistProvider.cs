//-----------------------------------------------------------------------
// <copyright file="ForecastIoPersistProvider.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Providers
{
    using System;
    using Persisters;

    /// <summary>
    /// Call Forecast.Io API to get weather data and persist. 
    /// </summary>
    public class ForecastIoPersistProvider : ForecastIoBaseProvider
    {
        /// <summary>
        /// Provider to use to persist calls.
        /// </summary>
        private readonly IPersistProvider _provider;

        /// <summary>
        /// Initializes a new instance of the ForecastIoPersistProvider class with the provider used to persist calls. 
        /// </summary>
        /// <param name="provider">Provider to use to persist calls.</param>
        public ForecastIoPersistProvider(IPersistProvider provider)
        {
            this._provider = provider;
        }

        /// <summary>
        /// Will get the forecast either from the API or if the call is persisted, will source from there.
        /// </summary>
        /// <param name="request">The request data.</param>
        /// <returns>The response information per request.</returns>
        public override ForecastIoResponse GetForecast(ForecastIoRequest request)
        {
            // I.   Setup locals.
            // II.  Does item exist in persisted place? If not, get it and persist. Otherwise, pull the entry.
            // III. Generate the response.

            // I.
            var persisted = false;
            IPersistEntry entry;

            // II.
            if (!this._provider.Exists(request.Indetifier))
            {
                entry = this.GetEntry(request);
                this._provider.Set(entry);
            }
            else
            {
                entry = this._provider.Get(request.Indetifier);
                persisted = true;
            }

            // III.
            return this.GenerateForecastResponse(entry, persisted);
        }

        /// <summary>
        /// Takes an entry and generates the ForecastIoResponse for said entry.
        /// </summary>
        /// <param name="entry">The cached entry.</param>
        /// <param name="persisted">Whether or not the entry was pulled from the persisted source.</param>
        /// <returns>The response information for a given entry.</returns>
        private ForecastIoResponse GenerateForecastResponse(IPersistEntry entry, bool persisted)
        {
            return new ForecastIoResponse()
            {
                Forecast = entry.Forecast,
                Persisted = persisted,
                ForecastRequestTime = entry.ForecastRequestTime
            };
        }

        /// <summary>
        /// Gets an entry from a request.  
        /// </summary>
        /// <param name="request">Request to process.</param>
        /// <returns>Entry with API call results.</returns>
        private IPersistEntry GetEntry(ForecastIoRequest request)
        {
            var entry = this._provider.CreateEntry(request);
            entry.Forecast = this.Call(request);
            entry.ForecastRequestTime = DateTime.UtcNow;
            return entry;
        }
    }
}
