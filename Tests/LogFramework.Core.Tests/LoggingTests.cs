// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using LogFramework.XUnit;

using NSubstitute;

using Xunit;
using Xunit.Abstractions;

namespace LogFramework
{
    public class LoggingTests : XUnitTests
    {
        // PUBLIC CONSTRUCTORS //////////////////////////////////////////////
        #region Constructors
        public LoggingTests(ITestOutputHelper output)
            : base(output)
        {
        }
        #endregion

        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Test Methods
        [Theory]
        [MemberData(nameof(TraceTestData))]
        public void TestTrace(IXUnitTest unitTest)
        {
            unitTest.Execute(this);
        }

        [Theory]
        [MemberData(nameof(DebugTestData))]
        public void TestDebug(IXUnitTest unitTest)
        {
            unitTest.Execute(this);
        }

        [Theory]
        [MemberData(nameof(InformationTestData))]
        public void TestInformation(IXUnitTest unitTest)
        {
            unitTest.Execute(this);
        }

        [Theory]
        [MemberData(nameof(WarningTestData))]
        public void TestWarning(IXUnitTest unitTest)
        {
            unitTest.Execute(this);
        }

        [Theory]
        [MemberData(nameof(ErrorTestData))]
        public void TestError(IXUnitTest unitTest)
        {
            unitTest.Execute(this);
        }

        [Theory]
        [MemberData(nameof(CriticalTestData))]
        public void TestCritical(IXUnitTest unitTest)
        {
            unitTest.Execute(this);
        }
        #endregion

        // PRIVATE FIELDS ///////////////////////////////////////////////////
        #region Test Data
        private static readonly ArgumentException TestException = new ArgumentException();

        #region Trace
        // ReSharper disable once MemberCanBePrivate.Global
        public static readonly IEnumerable<object[]> TraceTestData = new[]
        {
            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplate",  true,  logger => logger.Trace("MessageTemplate"), LogLevel.Trace, null, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplate", false, logger => logger.Trace("MessageTemplate"), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd1Argument",  true,  logger => logger.Trace("MessageTemplate {arg0}", 0), LogLevel.Trace, null, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd1Argument", false, logger => logger.Trace("MessageTemplate {arg0}", 0), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd2Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd2Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd3Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd3Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd4Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd4Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd5Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd5Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd6Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd6Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd7Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd7Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd8Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd8Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd9Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd9Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndMessageTemplateAnd10Arguments",  true,  logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Trace, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithTraceDisabledAndMessageTemplateAnd10Arguments", false, logger => logger.Trace("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Trace)},



            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplate",  true,  logger => logger.Trace(TestException, "MessageTemplate"), LogLevel.Trace, TestException, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplate", false, logger => logger.Trace(TestException, "MessageTemplate"), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd1Argument",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0}", 0), LogLevel.Trace, TestException, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd1Argument", false, logger => logger.Trace(TestException, "MessageTemplate {arg0}", 0), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd2Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd2Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd3Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd3Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd4Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd4Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd5Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd5Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd6Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd6Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd7Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd7Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd8Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd8Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd9Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd9Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Trace)},

            new object[] {new LogUnitTest("WithTraceEnabledAndExceptionAndMessageTemplateAnd10Arguments",  true,  logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Trace, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithTraceDisabledAndExceptionAndMessageTemplateAnd10Arguments", false, logger => logger.Trace(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Trace)},
        };
        #endregion

        #region Debug
        // ReSharper disable once MemberCanBePrivate.Global
        public static readonly IEnumerable<object[]> DebugTestData = new[]
        {
            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplate",  true,  logger => logger.Debug("MessageTemplate"), LogLevel.Debug, null, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplate", false, logger => logger.Debug("MessageTemplate"), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd1Argument",  true,  logger => logger.Debug("MessageTemplate {arg0}", 0), LogLevel.Debug, null, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd1Argument", false, logger => logger.Debug("MessageTemplate {arg0}", 0), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd2Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd2Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd3Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd3Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd4Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd4Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd5Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd5Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd6Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd6Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd7Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd7Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd8Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd8Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd9Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd9Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndMessageTemplateAnd10Arguments",  true,  logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Debug, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithDebugDisabledAndMessageTemplateAnd10Arguments", false, logger => logger.Debug("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Debug)},



            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplate",  true,  logger => logger.Debug(TestException, "MessageTemplate"), LogLevel.Debug, TestException, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplate", false, logger => logger.Debug(TestException, "MessageTemplate"), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd1Argument",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0}", 0), LogLevel.Debug, TestException, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd1Argument", false, logger => logger.Debug(TestException, "MessageTemplate {arg0}", 0), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd2Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd2Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd3Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd3Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd4Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd4Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd5Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd5Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd6Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd6Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd7Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd7Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd8Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd8Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd9Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd9Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Debug)},

            new object[] {new LogUnitTest("WithDebugEnabledAndExceptionAndMessageTemplateAnd10Arguments",  true,  logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Debug, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithDebugDisabledAndExceptionAndMessageTemplateAnd10Arguments", false, logger => logger.Debug(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Debug)},
        };
        #endregion

        #region Information
        // ReSharper disable once MemberCanBePrivate.Global
        public static readonly IEnumerable<object[]> InformationTestData = new[]
        {
            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplate",  true,  logger => logger.Information("MessageTemplate"), LogLevel.Information, null, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplate", false, logger => logger.Information("MessageTemplate"), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd1Argument",  true,  logger => logger.Information("MessageTemplate {arg0}", 0), LogLevel.Information, null, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd1Argument", false, logger => logger.Information("MessageTemplate {arg0}", 0), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd2Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Information, null, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd2Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd3Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd3Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd4Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd4Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd5Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd5Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd6Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd6Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd7Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd7Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd8Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd8Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd9Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd9Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndMessageTemplateAnd10Arguments",  true,  logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Information, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithInformationDisabledAndMessageTemplateAnd10Arguments", false, logger => logger.Information("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Information)},



            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplate",  true,  logger => logger.Information(TestException, "MessageTemplate"), LogLevel.Information, TestException, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplate", false, logger => logger.Information(TestException, "MessageTemplate"), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd1Argument",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0}", 0), LogLevel.Information, TestException, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd1Argument", false, logger => logger.Information(TestException, "MessageTemplate {arg0}", 0), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd2Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd2Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd3Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd3Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd4Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd4Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd5Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd5Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd6Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd6Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd7Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd7Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd8Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd8Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd9Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd9Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Information)},

            new object[] {new LogUnitTest("WithInformationEnabledAndExceptionAndMessageTemplateAnd10Arguments",  true,  logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Information, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithInformationDisabledAndExceptionAndMessageTemplateAnd10Arguments", false, logger => logger.Information(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Information)},
        };
        #endregion

        #region Warning
        // ReSharper disable once MemberCanBePrivate.Global
        public static readonly IEnumerable<object[]> WarningTestData = new[]
        {
            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplate",  true,  logger => logger.Warning("MessageTemplate"), LogLevel.Warning, null, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplate", false, logger => logger.Warning("MessageTemplate"), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd1Argument",  true,  logger => logger.Warning("MessageTemplate {arg0}", 0), LogLevel.Warning, null, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd1Argument", false, logger => logger.Warning("MessageTemplate {arg0}", 0), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd2Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd2Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd3Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd3Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd4Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd4Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd5Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd5Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd6Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd6Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd7Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd7Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd8Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd8Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd9Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd9Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndMessageTemplateAnd10Arguments",  true,  logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Warning, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithWarningDisabledAndMessageTemplateAnd10Arguments", false, logger => logger.Warning("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Warning)},



            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplate",  true,  logger => logger.Warning(TestException, "MessageTemplate"), LogLevel.Warning, TestException, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplate", false, logger => logger.Warning(TestException, "MessageTemplate"), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd1Argument",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0}", 0), LogLevel.Warning, TestException, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd1Argument", false, logger => logger.Warning(TestException, "MessageTemplate {arg0}", 0), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd2Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd2Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd3Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd3Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd4Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd4Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd5Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd5Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd6Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd6Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd7Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd7Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd8Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd8Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd9Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd9Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Warning)},

            new object[] {new LogUnitTest("WithWarningEnabledAndExceptionAndMessageTemplateAnd10Arguments",  true,  logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Warning, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithWarningDisabledAndExceptionAndMessageTemplateAnd10Arguments", false, logger => logger.Warning(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Warning)},
        };
        #endregion

        #region Error
        // ReSharper disable once MemberCanBePrivate.Global
        public static readonly IEnumerable<object[]> ErrorTestData = new[]
        {
            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplate",  true,  logger => logger.Error("MessageTemplate"), LogLevel.Error, null, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplate", false, logger => logger.Error("MessageTemplate"), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd1Argument",  true,  logger => logger.Error("MessageTemplate {arg0}", 0), LogLevel.Error, null, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd1Argument", false, logger => logger.Error("MessageTemplate {arg0}", 0), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd2Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Error, null, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd2Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd3Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd3Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd4Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd4Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd5Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd5Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd6Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd6Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd7Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd7Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd8Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd8Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd9Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd9Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndMessageTemplateAnd10Arguments",  true,  logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Error, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithErrorDisabledAndMessageTemplateAnd10Arguments", false, logger => logger.Error("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Error)},



            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplate",  true,  logger => logger.Error(TestException, "MessageTemplate"), LogLevel.Error, TestException, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplate", false, logger => logger.Error(TestException, "MessageTemplate"), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd1Argument",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0}", 0), LogLevel.Error, TestException, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd1Argument", false, logger => logger.Error(TestException, "MessageTemplate {arg0}", 0), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd2Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd2Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd3Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd3Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd4Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd4Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd5Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd5Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd6Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd6Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd7Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd7Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd8Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd8Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd9Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd9Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Error)},

            new object[] {new LogUnitTest("WithErrorEnabledAndExceptionAndMessageTemplateAnd10Arguments",  true,  logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Error, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithErrorDisabledAndExceptionAndMessageTemplateAnd10Arguments", false, logger => logger.Error(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Error)},
        };
        #endregion

        #region Critical
        // ReSharper disable once MemberCanBePrivate.Global
        public static readonly IEnumerable<object[]> CriticalTestData = new[]
        {
            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplate",  true,  logger => logger.Critical("MessageTemplate"), LogLevel.Critical, null, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplate", false, logger => logger.Critical("MessageTemplate"), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd1Argument",  true,  logger => logger.Critical("MessageTemplate {arg0}", 0), LogLevel.Critical, null, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd1Argument", false, logger => logger.Critical("MessageTemplate {arg0}", 0), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd2Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd2Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd3Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd3Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd4Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd4Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd5Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd5Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd6Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd6Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd7Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd7Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd8Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd8Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd9Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd9Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndMessageTemplateAnd10Arguments",  true,  logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Critical, null, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndMessageTemplateAnd10Arguments", false, logger => logger.Critical("MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Critical)},



            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplate",  true,  logger => logger.Critical(TestException, "MessageTemplate"), LogLevel.Critical, TestException, "MessageTemplate", new object[0])},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplate", false, logger => logger.Critical(TestException, "MessageTemplate"), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd1Argument",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0}", 0), LogLevel.Critical, TestException, "MessageTemplate {arg0}", new object[]{0})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd1Argument", false, logger => logger.Critical(TestException, "MessageTemplate {arg0}", 0), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd2Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1}", new object[]{0, 1})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd2Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1}", 0, 1), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd3Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2}", new object[]{0, 1, 2})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd3Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2}", 0, 1, 2), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd4Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", new object[]{0, 1, 2, 3})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd4Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3}", 0, 1, 2, 3), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd5Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", new object[]{0, 1, 2, 3, 4})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd5Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4}", 0, 1, 2, 3, 4), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd6Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", new object[]{0, 1, 2, 3, 4, 5})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd6Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5}", 0, 1, 2, 3, 4, 5), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd7Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", new object[]{0, 1, 2, 3, 4, 5, 6})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd7Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6}", 0, 1, 2, 3, 4, 5, 6), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd8Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", new object[]{0, 1, 2, 3, 4, 5, 6, 7})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd8Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7}", 0, 1, 2, 3, 4, 5, 6, 7), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd9Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd9Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8}", 0, 1, 2, 3, 4, 5, 6, 7, 8), LogLevel.Critical)},

            new object[] {new LogUnitTest("WithCriticalEnabledAndExceptionAndMessageTemplateAnd10Arguments",  true,  logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Critical, TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", new object[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9})},
            new object[] {new LogUnitTest("WithCriticalDisabledAndExceptionAndMessageTemplateAnd10Arguments", false, logger => logger.Critical(TestException, "MessageTemplate {arg0} {arg1} {arg2} {arg3} {arg4} {arg5} {arg6} {arg7} {arg8} {arg9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9), LogLevel.Critical)},
        };
        #endregion

        #endregion

        // PRIVATE TYPES ////////////////////////////////////////////////////
        #region Unit Tests
        private class LogUnitTest : XUnitTest
        {
            #region Constructors
            public LogUnitTest(string                      name,
                               bool                        isEnabled,
                               Expression<Action<ILogger>> logActionExpression,
                               LogLevel                    logLevel,
                               Exception                   exception       = default(Exception),
                               string                      messageTemplate = default(string),
                               object[]                    arguments       = default(object[]))
                : base(name)
            {
                this.IsEnabled           = isEnabled;
                this.LogActionExpression = logActionExpression;
                this.LogLevel            = logLevel;
                this.Exception           = exception;
                this.MessageTemplate     = messageTemplate;
                this.Arguments           = arguments;
            }
            #endregion

            #region UnitTest Overrides
            protected override void Arrange()
            {
                var logger = Substitute.For<ILogger>();
                this.Logger = logger;

                this.Logger.IsEnabled(this.LogLevel).Returns(this.IsEnabled);

                this.WriteLine("IsEnabled       : {0}", this.IsEnabled);
                this.WriteLine("LogAction       : {0}", this.LogActionExpression.ToString());
                if (this.IsEnabled == false)
                    return;

                this.WriteLine("Exception       : {0}", this.Exception != null ? this.Exception.GetType().Name : "null");
                this.WriteLine("MessageTemplate : {0}", this.MessageTemplate);
            }

            protected override void Act()
            {
                var logAction = this.LogActionExpression.Compile();
                logAction(this.Logger);
            }

            protected override void Assert()
            {
                this.Logger.Received().IsEnabled(this.LogLevel);
                if (this.IsEnabled)
                {
                    this.Logger.Received().Log(this.LogLevel, this.Exception, this.MessageTemplate, Arg.Is<object[]>(x => this.Arguments.SequenceEqual(x)));
                }
                else
                {
                    this.Logger.DidNotReceiveWithAnyArgs().Log(default(LogLevel), default(Exception), default(string), default(object[]));
                }
            }
            #endregion

            #region User Supplied Properties
            private bool                        IsEnabled           { get; }
            private Expression<Action<ILogger>> LogActionExpression { get; }
            private LogLevel                    LogLevel            { get; }
            private Exception                   Exception           { get; }
            private string                      MessageTemplate     { get; }
            private object[]                    Arguments           { get; }
            #endregion

            #region Calculated Properties
            private ILogger Logger { get; set; }
            #endregion
        }
        #endregion
    }
}
