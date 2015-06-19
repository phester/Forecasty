//-----------------------------------------------------------------------
// <copyright file="CachePolicy.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Persisters.Caching
{
    /// <summary>
    /// Cache policy on entries.
    /// </summary>
    public class CachePolicy
    {
        /// <summary>
        /// 
        /// </summary>
        public long TimeToExpireEntry { get; set; }
    }
}
