//-----------------------------------------------------------------------
// <copyright file="UnixTimeConverter.cs" company="Paul Hester">
//      Will code for food or beer : )
//      Source: http://stackoverflow.com/a/7844741
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Helpers
{
    using System;

    /// <summary>
    /// Converts epoch to DateTime and back.
    /// </summary>
    public static class UnixTimeConverter
    {
        /// <summary>
        /// Convert Unix time to c# type.
        /// </summary>
        /// <param name="unixTime">Epoch to convert.</param>
        /// <returns>UTC DateTime</returns>
        public static DateTime From(ulong unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        /// <summary>
        /// Convert date to Unix time.
        /// </summary>
        /// <param name="date">Date to convert.</param>
        /// <returns>Unix time</returns>
        public static ulong To(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToUInt64((date - epoch).TotalSeconds);
        }
    }
}
