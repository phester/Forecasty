namespace Forecasty.Core.Helpers
{
    using System;
    using System.Net;

    public static class HttpClient
    {
        public static String GetString(string url)
        {
            // TODO: Implement call count ResponseHeaders["X-Forecast-API-Calls"]

            var uri = new Uri(url);
            using (var client = new WebClient())
            {
                var result = client.DownloadString(uri);
                return result;
            }
        }
    }
}
