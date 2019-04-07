// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;
using System.Diagnostics.Contracts;

namespace LogFramework
{
    public class SerilogLoggerFactory : ILoggerFactory
    {
        // PUBLIC CONSTRUCTORS //////////////////////////////////////////////
        #region Constructors
        public SerilogLoggerFactory(Func<string, Serilog.ILogger> loggerFactoryImpl)
        {
            Contract.Requires(loggerFactoryImpl != null);

            this.LoggerFactoryImpl = loggerFactoryImpl;
        }
        #endregion

        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region ILoggerFactory Implementation
        public ILogger Create(string name)
        {
            var loggerImpl = this.LoggerFactoryImpl(name);
            var logger     = new SerilogLogger(loggerImpl);
            return logger;
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Properties
        private Func<string, Serilog.ILogger> LoggerFactoryImpl { get; }
        #endregion
    }
}
