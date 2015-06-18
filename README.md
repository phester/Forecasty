# Forecasty

# This is pre-alpha. I wouldn't use it or trust it.

A c# Forecast.Io wrapper with a built-in mechanism to persist API results to a mechanism of your choice.

```c#
var request = new ForecastIoRequest(apiKey, latitude, longitude);
var provider = new ForecastIoPersistProvider(new CacheProvider());
var response = provider.GetForecast(request);
