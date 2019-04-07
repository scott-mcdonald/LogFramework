// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System.Diagnostics.Contracts;

namespace LogFramework
{
    public class MicrosoftExtensionsLoggingLoggerFactory : ILoggerFactory
    {
        // PUBLIC CONSTRUCTORS //////////////////////////////////////////////
        #region Constructors
        public MicrosoftExtensionsLoggingLoggerFactory(Microsoft.Extensions.Logging.ILoggerFactory loggerFactoryimpl)
        {
            Contract.Requires(loggerFactoryimpl != null);

            this.LoggerFactoryImpl = loggerFactoryimpl;
        }
        #endregion

        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region ILoggerFactory Implementation
        public ILogger Create(string name)
        {
            var loggerImpl = this.LoggerFactoryImpl.CreateLogger(name);
            var logger     = new MicrosoftExtensionsLoggingLogger(loggerImpl);
            return logger;
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Properties
        private Microsoft.Extensions.Logging.ILoggerFactory LoggerFactoryImpl { get; }
        #endregion
    }
}
