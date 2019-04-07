namespace LogFramework
{
    /// <summary>Abstracts a factory of <see cref="ILogger"/> objects.</summary>
    public interface ILoggerFactory
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Methods
        /// <summary>
        /// Create an implementation of the <see cref="ILogger"/> interface.
        /// </summary>
        /// <param name="name">Contextual name to use in the creation of a <see cref="ILogger"/> object.</param>
        /// <returns>An implementation of the <see cref="ILogger"/> interface.</returns>
        ILogger Create(string name);
        #endregion
    }
}