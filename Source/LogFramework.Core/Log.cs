using System;
using System.Threading;

namespace LogFramework
{
    /// <summary>A logging singleton useful as an alternative paradigm to passing around <see cref="ILogger"/> objects if desired.</summary>
    // ReSharper disable once UnusedTypeParameter
    public class Log<T>
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Utility Methods
        /// <summary>
        /// Closes this static Log object and disposes of the current internal logger object if needed.
        /// </summary>
        public static void Close()
        {
            var logger = Interlocked.Exchange(ref _logger, new NullLogger());

            // ReSharper disable once SuspiciousTypeConversion.Global
            var loggerAsIDisposable = logger as IDisposable;
            loggerAsIDisposable?.Dispose();
        }

        /// <summary>Checks if the given log level is enabled.</summary>
        /// <param name="logLevel">The log level to check.</param>
        /// <returns>True if enabled, false otherwise.</returns>
        public static bool IsEnabled(LogLevel logLevel)
        {
            return Logger.IsEnabled(logLevel);
        }

        /// <summary>
        /// Opens this static Log object with a new internal logger object and disposes the original internal logger object if needed.
        /// </summary>
        /// <param name="newLogger">New logger object in which to open this static Log object with.</param>
        public static void Open(ILogger newLogger)
        {
            if (newLogger == null)
                return;

            var oldLogger = Interlocked.Exchange(ref _logger, newLogger);

            // ReSharper disable once SuspiciousTypeConversion.Global
            var oldLoggerAsIDisposable = oldLogger as IDisposable;
            oldLoggerAsIDisposable?.Dispose();
        }
        #endregion

        #region Trace Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Trace(string messageTemplate)
        {
            Logger.Trace(messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Trace<T0>(string messageTemplate, T0 argument0)
        {
            Logger.Trace(messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1>(string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Trace(messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Trace(messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Trace(messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3, T4>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Trace(messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Trace(string messageTemplate, params object[] arguments)
        {
            Logger.Trace(messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Trace(Exception exception, string messageTemplate)
        {
            Logger.Trace(exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Trace<T0>(Exception exception, string messageTemplate, T0 argument0)
        {
            Logger.Trace(exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1>(Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Trace(exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Trace(exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Trace(exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3, T4>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Trace(exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Trace(Exception exception, string messageTemplate, params object[] arguments)
        {
            Logger.Trace(exception, messageTemplate, arguments);
        }
        #endregion

        #region Debug Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Debug(string messageTemplate)
        {
            Logger.Debug(messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Debug<T0>(string messageTemplate, T0 argument0)
        {
            Logger.Debug(messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1>(string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Debug(messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Debug(messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Debug(messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3, T4>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Debug(messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Debug(string messageTemplate, params object[] arguments)
        {
            Logger.Debug(messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Debug(Exception exception, string messageTemplate)
        {
            Logger.Debug(exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Debug<T0>(Exception exception, string messageTemplate, T0 argument0)
        {
            Logger.Debug(exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1>(Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Debug(exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Debug(exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Debug(exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3, T4>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Debug(exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Debug(Exception exception, string messageTemplate, params object[] arguments)
        {
            Logger.Debug(exception, messageTemplate, arguments);
        }
        #endregion

        #region Information Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Information(string messageTemplate)
        {
            Logger.Information(messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Information<T0>(string messageTemplate, T0 argument0)
        {
            Logger.Information(messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1>(string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Information(messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Information(messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Information(messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3, T4>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Information(messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Information(string messageTemplate, params object[] arguments)
        {
            Logger.Information(messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Information(Exception exception, string messageTemplate)
        {
            Logger.Information(exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Information<T0>(Exception exception, string messageTemplate, T0 argument0)
        {
            Logger.Information(exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1>(Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Information(exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Information(exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Information(exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3, T4>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Information(exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Information(Exception exception, string messageTemplate, params object[] arguments)
        {
            Logger.Information(exception, messageTemplate, arguments);
        }
        #endregion

        #region Warning Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Warning(string messageTemplate)
        {
            Logger.Warning(messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Warning<T0>(string messageTemplate, T0 argument0)
        {
            Logger.Warning(messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1>(string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Warning(messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Warning(messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Warning(messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3, T4>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Warning(messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Warning(string messageTemplate, params object[] arguments)
        {
            Logger.Warning(messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Warning(Exception exception, string messageTemplate)
        {
            Logger.Warning(exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Warning<T0>(Exception exception, string messageTemplate, T0 argument0)
        {
            Logger.Warning(exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1>(Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Warning(exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Warning(exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Warning(exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3, T4>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Warning(exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Warning(Exception exception, string messageTemplate, params object[] arguments)
        {
            Logger.Warning(exception, messageTemplate, arguments);
        }
        #endregion

        #region Error Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Error(string messageTemplate)
        {
            Logger.Error(messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Error<T0>(string messageTemplate, T0 argument0)
        {
            Logger.Error(messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1>(string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Error(messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Error(messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Error(messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3, T4>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Error(messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Error(string messageTemplate, params object[] arguments)
        {
            Logger.Error(messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Error(Exception exception, string messageTemplate)
        {
            Logger.Error(exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Error<T0>(Exception exception, string messageTemplate, T0 argument0)
        {
            Logger.Error(exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1>(Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Error(exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Error(exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Error(exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3, T4>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Error(exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Error(Exception exception, string messageTemplate, params object[] arguments)
        {
            Logger.Error(exception, messageTemplate, arguments);
        }
        #endregion

        #region Critical Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Critical(string messageTemplate)
        {
            Logger.Critical(messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Critical<T0>(string messageTemplate, T0 argument0)
        {
            Logger.Critical(messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1>(string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Critical(messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Critical(messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Critical(messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3, T4>(string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Critical(messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Critical(string messageTemplate, params object[] arguments)
        {
            Logger.Critical(messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Critical(Exception exception, string messageTemplate)
        {
            Logger.Critical(exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Critical<T0>(Exception exception, string messageTemplate, T0 argument0)
        {
            Logger.Critical(exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1>(Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Logger.Critical(exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Logger.Critical(exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Logger.Critical(exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3, T4>(Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            Logger.Critical(exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Critical(Exception exception, string messageTemplate, params object[] arguments)
        {
            Logger.Critical(exception, messageTemplate, arguments);
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Properties
        /// <summary>Gets the current <see cref="ILogger"/> implementation object for this singleton.</summary>
        private static ILogger Logger => _logger;
        #endregion

        // PRIVATE FIELDS ///////////////////////////////////////////////////
        #region Fields
        // ReSharper disable once StaticMemberInGenericType
        private static ILogger _logger = new NullLogger();
        #endregion
    }
}