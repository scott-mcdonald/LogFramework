// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;
using System.Diagnostics.Contracts;

namespace LogFramework
{
    public class SerilogLogger : ILogger
    {
        // PUBLIC CONSTRUCTORS //////////////////////////////////////////////
        #region Constructors
        public SerilogLogger(Serilog.ILogger loggerImpl)
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
            this.LoggerImpl.Write(loggerImplLogLevel, exception, messageTemplate, arguments);
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Properties
        private Serilog.ILogger LoggerImpl { get; }
        #endregion

        // PRIVATE METHODS //////////////////////////////////////////////////
        #region Methods
        private static Serilog.Events.LogEventLevel ToLoggerImplLogLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                    return Serilog.Events.LogEventLevel.Verbose;
                case LogLevel.Debug:
                    return Serilog.Events.LogEventLevel.Debug;
                case LogLevel.Information:
                    return Serilog.Events.LogEventLevel.Information;
                case LogLevel.Warning:
                    return Serilog.Events.LogEventLevel.Warning;
                case LogLevel.Error:
                    return Serilog.Events.LogEventLevel.Error;
                case LogLevel.Critical:
                    return Serilog.Events.LogEventLevel.Fatal;
                default:
                {
                    var message = $"Unable to convert an API framework log level [value={logLevel}] to a 'serilog' log level.";
                    throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, message);
                }
            }
        }
        #endregion
    }
}
