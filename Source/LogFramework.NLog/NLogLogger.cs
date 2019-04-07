// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;
using System.Diagnostics.Contracts;

namespace LogFramework
{
    public class NLogLogger : ILogger
    {
        // PUBLIC CONSTRUCTORS //////////////////////////////////////////////
        #region Constructors
        public NLogLogger(NLog.ILogger loggerImpl)
        {
            Contract.Requires(loggerImpl != null);

            this.LoggerImpl = loggerImpl;
        }
        #endregion

        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region ILogger Implementation
        public bool IsEnabled(LogLevel logLevel)
        {
            var loggerImplLogLevel  = ToLoggerImplLogLevel(logLevel);
            var loggerImplIsEnabled = this.LoggerImpl.IsEnabled(loggerImplLogLevel);
            return loggerImplIsEnabled;
        }

        public void Log(LogLevel logLevel, Exception exception, string messageTemplate, object[] arguments)
        {
            var loggerImplLogLevel = ToLoggerImplLogLevel(logLevel);
            this.LoggerImpl.Log(loggerImplLogLevel, exception, messageTemplate, arguments);
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Properties
        private NLog.ILogger LoggerImpl { get; }
        #endregion

        // PRIVATE METHODS //////////////////////////////////////////////////
        #region Methods
        private static NLog.LogLevel ToLoggerImplLogLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                    return NLog.LogLevel.Trace;
                case LogLevel.Debug:
                    return NLog.LogLevel.Debug;
                case LogLevel.Information:
                    return NLog.LogLevel.Info;
                case LogLevel.Warning:
                    return NLog.LogLevel.Warn;
                case LogLevel.Error:
                    return NLog.LogLevel.Error;
                case LogLevel.Critical:
                    return NLog.LogLevel.Fatal;
                default:
                {
                    var message = $"Unable to convert an API framework log level [value={logLevel}] to a 'NLog' log level.";
                    throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, message);
                }
            }
        }
        #endregion
    }
}
