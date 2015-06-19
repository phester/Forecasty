//-----------------------------------------------------------------------
// <copyright file="CacheProvider.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Persisters.Caching
{
    using System;
    using System.Linq;
    using System.Runtime.Caching;

    /// <summary>
    /// Manages the caching of items.
    /// </summary>
    public class CacheProvider : IPersistProvider
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static readonly Lazy<CacheProvider> Lazy = new Lazy<CacheProvider>(() => new CacheProvider());

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static CacheProvider Instance
        {
            get { return Lazy.Value; }
        }

        /// <summary>
        /// Put an item in cache.
        /// </summary>
        /// <param name="entry">Entry item to store.</param>
        /// <returns>Whether or not entry has been set.</returns>
        public bool Set(IPersistEntry entry)
        {
            // TODO: Implement policy around caching.
            MemoryCache.Default.Set(entry.Identifier, entry, null);
            return true;
        }

        /// <summary>
        /// Return instance of T from cache by key value.  
        /// </summary>
        /// <param name="identifier">Key in cache to get item.</param>
        /// <returns>Gets the entry from cache.</returns>
        public IPersistEntry Get(string identifier)
        {
            return MemoryCache.Default.Get(identifier) as CacheEntry;
        }

        /// <summary>
        /// Does value for key exist in cache.
        /// </summary>
        /// <param name="identifier">Entry identifier in cache.</param>
        /// <returns>Whether or not entry exists.</returns>
        public bool Exists(string identifier)
        {
            return MemoryCache.Default.Contains(identifier);
        }

        /// <summary>
        /// Clears all stored items.
        /// </summary>
        public void Clear()
        {
            // TODO: FIX - Using for testing. This will remove ALL items in cache. Need to maintain a list of added keys.
            // TODO: Thread-safe
            MemoryCache.Default.ToList().ForEach(a => MemoryCache.Default.Remove(a.Key));

        }

        /// <summary>
        /// Creates an entry to store.
        /// </summary>
        /// <param name="request">Request to base entry off of.</param>
        /// <returns>Entry instance.</returns>
        public IPersistEntry CreateEntry(ForecastIoRequest request)
        {
            //TODO: Create identifier from request.

            return new CacheEntry()
            {
                Identifier = request.Indetifier
            };
        }
    }
}
