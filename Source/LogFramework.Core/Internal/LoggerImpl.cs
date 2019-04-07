// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;
using System.Diagnostics.Contracts;

namespace LogFramework.Internal
{
    /// <summary>
    /// This API supports the Log Framework infrastructure and is not intended to be used directly from your code.
    /// This API may change or be removed in future releases.
    /// </summary>
    internal static class LoggerImpl
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Methods
        public static void Log(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Avoid any array allocation and boxing when the logging level is not enabled.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, EmptyArguments);
        }

        public static void Log<T0>(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate, T0 argument0)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Avoid any array allocation and boxing when the logging level is not enabled.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, new object[] {argument0});
        }

        public static void Log<T0, T1>(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate, T0 argument0, T1 argument1)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Avoid any array allocation and boxing when the logging level is not enabled.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, new object[] {argument0, argument1});
        }

        public static void Log<T0, T1, T2>(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Avoid any array allocation and boxing when the logging level is not enabled.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, new object[] {argument0, argument1, argument2});
        }

        public static void Log<T0, T1, T2, T3>(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Avoid any array allocation and boxing when the logging level is not enabled.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, new object[] {argument0, argument1, argument2, argument3});
        }

        public static void Log<T0, T1, T2, T3, T4>(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate, T0 argument0, T1 argument1, T2 argument2, T3 argument3, T4 agrument4)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Avoid any array allocation and boxing when the logging level is not enabled.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, new object[] {argument0, argument1, argument2, argument3, agrument4});
        }

        public static void Log(ILogger logger, LogLevel logLevel, Exception exception, string messageTemplate, object[] arguments)
        {
            Contract.Requires(logger          != null);
            Contract.Requires(messageTemplate != null);

            // Optimization: Check as early as possible if the logging level is not enabled or not.
            if (!logger.IsEnabled(logLevel))
                return;

            logger.Log(logLevel, exception, messageTemplate, arguments);
        }
        #endregion

        // PRIVATE FIELDS ///////////////////////////////////////////////////
        #region Constants
        private static readonly object[] EmptyArguments = new object[0];
        #endregion
    }
}
