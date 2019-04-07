// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

namespace LogFramework
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region ILoggerFactory Implementation
        public ILogger Create(string name)
        {
            var loggerImpl = NLog.LogManager.GetLogger(name);
            var logger     = new NLogLogger(loggerImpl);
            return logger;
        }
        #endregion
    }
}
