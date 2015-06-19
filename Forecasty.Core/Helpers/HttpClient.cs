namespace Forecasty.Core.Helpers
{
    using System;
    using System.Net;

    public static class HttpClient
    {
        public static String GetString(string url)
        {
            // TODO: Implement call count ResponseHeaders["X-Forecast-API-Calls"]

            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException("Url must be defined.");

            using (var client = new WebClient())
            {
                return client.DownloadString(new Uri(url));
            }
        }
    }
}
