using System;

namespace LogFramework
{
    /// <summary>
    /// Represents an object used to log with structured logging using message templates.
    /// </summary>
    /// <see cref="https://messagetemplates.org"/>
    public interface ILogger
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Methods
        /// <summary>Checks if the given log level is enabled.</summary>
        /// <param name="logLevel">The log level to check.</param>
        /// <returns>True if enabled, false otherwise.</returns>
        bool IsEnabled(LogLevel logLevel);

        /// <summary>
        /// Log an event with the specified logging level.
        /// </summary>
        /// <param name="logLevel">Log level of the event.</param>
        /// <param name="exception">Exception related to the event, may be null.</param>
        /// <param name="messageTemplate">Message template describing the event, should not be null.</param>
        /// <param name="arguments">Optional arguments positionally formatted into the message template, may be null.</param>
        /// <remarks>
        /// Best practice is to use the logger extension methods instead of calling this method directly.
        /// </remarks>
        void Log(LogLevel logLevel, Exception exception, string messageTemplate, object[] arguments);
        #endregion
    }
}