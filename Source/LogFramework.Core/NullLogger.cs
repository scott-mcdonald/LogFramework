// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;

namespace LogFramework
{
    /// <inheritdoc cref="ILogger"/>
    /// <summary>
    /// Null object implementation of the <see cref="ILogger"/> interface. In other words, the implementation does nothing.
    /// </summary>
    public class NullLogger : ILogger
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Methods
        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Log(LogLevel logLevel, Exception exception, string messageTemplate, object[] arguments)
        {
        }
        #endregion
    }
}
