// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;
using System.Diagnostics.Contracts;

namespace LogFramework
{
    public class MicrosoftExtensionsLoggingLogger : ILogger
    {
        // PUBLIC CONSTRUCTORS //////////////////////////////////////////////
        #region Constructors
        public MicrosoftExtensionsLoggingLogger(Microsoft.Extensions.Logging.ILogger loggerImpl)
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
            switch (loggerImplLogLevel)
            {
                case Microsoft.Extensions.Logging.LogLevel.Trace:
                {
                    Microsoft.Extensions.Logging.LoggerExtensions.LogTrace(this.LoggerImpl, exception, messageTemplate, arguments);
                    break;
                }
                case Microsoft.Extensions.Logging.LogLevel.Debug:
                {
                    Microsoft.Extensions.Logging.LoggerExtensions.LogDebug(this.LoggerImpl, exception, messageTemplate, arguments);
                    break;
                }
                case Microsoft.Extensions.Logging.LogLevel.Information:
                {
                    Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(this.LoggerImpl, exception, messageTemplate, arguments);
                    break;
                }
                case Microsoft.Extensions.Logging.LogLevel.Warning:
                {
                    Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(this.LoggerImpl, exception, messageTemplate, arguments);
                    break;
                }
                case Microsoft.Extensions.Logging.LogLevel.Error:
                {
                    Microsoft.Extensions.Logging.LoggerExtensions.LogError(this.LoggerImpl, exception, messageTemplate, arguments);
                    break;
                }
                case Microsoft.Extensions.Logging.LogLevel.Critical:
                {
                    Microsoft.Extensions.Logging.LoggerExtensions.LogCritical(this.LoggerImpl, exception, messageTemplate, arguments);
                    break;
                }
                default:
                {
                    var message = $"Unable to log with an unsupported 'Microsoft.Extensions.Logging' log level [value={loggerImplLogLevel}].";
                    throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, message);
                }
            }
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Properties
        private Microsoft.Extensions.Logging.ILogger LoggerImpl { get; }
        #endregion

        // PRIVATE METHODS //////////////////////////////////////////////////
        #region Methods
        private static Microsoft.Extensions.Logging.LogLevel ToLoggerImplLogLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                    return Microsoft.Extensions.Logging.LogLevel.Trace;
                case LogLevel.Debug:
                    return Microsoft.Extensions.Logging.LogLevel.Debug;
                case LogLevel.Information:
                    return Microsoft.Extensions.Logging.LogLevel.Information;
                case LogLevel.Warning:
                    return Microsoft.Extensions.Logging.LogLevel.Warning;
                case LogLevel.Error:
                    return Microsoft.Extensions.Logging.LogLevel.Error;
                case LogLevel.Critical:
                    return Microsoft.Extensions.Logging.LogLevel.Critical;
                default:
                {
                    var message = $"Unable to convert an API framework log level [value={logLevel}] to a 'Microsoft.Extensions.Logging' log level.";
                    throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, message);
                }
            }
        }
        #endregion
    }
}
