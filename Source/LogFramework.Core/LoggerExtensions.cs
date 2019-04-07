// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;

using LogFramework.Internal;

namespace LogFramework
{
    /// <summary>Extension methods for the <see cref="ILogger"/> interface.</summary>
    public static class LoggerExtensions
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Trace Extension Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Trace(this ILogger logger, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Trace<T0>(this ILogger logger, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3, T4>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Trace(this ILogger logger, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, null, messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Trace(this ILogger logger, Exception exception, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Trace<T0>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Trace<T0, T1, T2, T3, T4>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Trace(this ILogger logger, Exception exception, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Trace, exception, messageTemplate, arguments);
        }
        #endregion

        #region Debug Extension Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Debug(this ILogger logger, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Debug<T0>(this ILogger logger, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3, T4>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Debug(this ILogger logger, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, null, messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Debug(this ILogger logger, Exception exception, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Debug<T0>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Debug<T0, T1, T2, T3, T4>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Debug(this ILogger logger, Exception exception, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Debug, exception, messageTemplate, arguments);
        }
        #endregion

        #region Information Extension Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Information(this ILogger logger, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Information<T0>(this ILogger logger, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3, T4>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Information(this ILogger logger, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, null, messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Information(this ILogger logger, Exception exception, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Information<T0>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Information<T0, T1, T2, T3, T4>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Information"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Information(this ILogger logger, Exception exception, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Information, exception, messageTemplate, arguments);
        }
        #endregion

        #region Warning Extension Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Warning(this ILogger logger, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Warning<T0>(this ILogger logger, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3, T4>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Warning(this ILogger logger, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, null, messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Warning(this ILogger logger, Exception exception, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Warning<T0>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Warning<T0, T1, T2, T3, T4>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Warning"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Warning(this ILogger logger, Exception exception, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Warning, exception, messageTemplate, arguments);
        }
        #endregion

        #region Error Extension Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Error(this ILogger logger, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Error<T0>(this ILogger logger, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3, T4>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Error(this ILogger logger, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, null, messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Error(this ILogger logger, Exception exception, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Error<T0>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Error<T0, T1, T2, T3, T4>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Error(this ILogger logger, Exception exception, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Error, exception, messageTemplate, arguments);
        }
        #endregion

        #region Critical Extension Methods
        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Critical(this ILogger logger, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Critical<T0>(this ILogger logger, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3, T4>(this ILogger logger, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Critical(this ILogger logger, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, null, messageTemplate, arguments);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static void Critical(this ILogger logger, Exception exception, string messageTemplate)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        public static void Critical<T0>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate, argument0);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate, argument0, argument1);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate, argument0, argument1, argument2);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate, argument0, argument1, argument2, argument3);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="argument0">Object positionally formatted into the message template.</param>
        /// <param name="argument1">Object positionally formatted into the message template.</param>
        /// <param name="argument2">Object positionally formatted into the message template.</param>
        /// <param name="argument3">Object positionally formatted into the message template.</param>
        /// <param name="argument4">Object positionally formatted into the message template.</param>
        public static void Critical<T0, T1, T2, T3, T4>(this ILogger logger, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate, argument0, argument1, argument2, argument3, argument4);
        }

        /// <summary>
        /// Log an event with the <see cref="LogLevel.Critical"/> level.
        /// </summary>
        /// <param name="logger">The logger object to log the event with.</param>
        /// <param name="exception">Exception associated to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="arguments">Objects positionally formatted into the message template.</param>
        public static void Critical(this ILogger logger, Exception exception, string messageTemplate, params object[] arguments)
        {
            if (logger == null)
                return;

            LoggerImpl.Log(logger, LogLevel.Critical, exception, messageTemplate, arguments);
        }
        #endregion
    }
}
