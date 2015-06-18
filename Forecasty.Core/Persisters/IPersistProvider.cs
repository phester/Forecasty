//-----------------------------------------------------------------------
// <copyright file="IPersistProvider.cs" company="https://www.linkedin.com/in/paulhester">
//      Will code for food or beer : )
// </copyright>
//-----------------------------------------------------------------------
namespace Forecasty.Core.Persisters
{
    /// <summary>
    /// An interface to implement for entry persistence.
    /// </summary>
    public interface IPersistProvider
    {
        /// <summary>
        /// Persists the entry.
        /// </summary>
        /// <param name="entry">The entry to persist.</param>
        /// <returns>Whether or not the entry was successfully added.</returns>
        bool Set(IPersistEntry entry);

        /// <summary>
        /// Gets the persisted entry by identifier.
        /// </summary>
        /// <param name="identifier">The identifier of the entry.</param>
        /// <returns>The persisted entry</returns>
        IPersistEntry Get(string identifier);

        /// <summary>
        /// Determines if an entry exists by identifier.
        /// </summary>
        /// <param name="identifier">The identifier of the entry.</param>
        /// <returns>Whether or not the entry exists.</returns>
        bool Exists(string identifier);

        /// <summary>
        /// Clears out all persisted entries.
        /// </summary>
        void Clear();

        /// <summary>
        /// Creates an entry for storage based on the request.
        /// </summary>
        /// <param name="request">Request to create entry from.</param>
        /// <returns>Entry instance.</returns>
        IPersistEntry CreateEntry(ForecastIoRequest request);
    }
}
