// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

namespace LogFramework
{
    /// <inheritdoc cref="ILoggerFactory"/>
    /// <summary>
    /// Implements the <see cref="ILoggerFactory"/> interface to return <see cref="NullLogger"/> instances.
    /// </summary>
    public class NullLoggerFactory : ILoggerFactory
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Methods
        public ILogger Create(string name)
        {
            var nullLogger = new NullLogger();
            return nullLogger;
        }
        #endregion
    }
}
