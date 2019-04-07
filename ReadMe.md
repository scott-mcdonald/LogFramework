# LogFramework

**LogFramework** is a simple, cross-platform, and open source framework at the logging facade level of abstraction so application code can essentially be independent of any particular logging library/implementation.

## Introduction

*LogFramework* was developed based on a need to create higher-level frameworks that incorporated logging but did not force any particular logging library upon the developer. By standardizing the abstraction around logging and delegating implementations using modern day creational design patterns, developers are free to choose and/or change logging implementations as needed.

The core logger abstraction is desinged with structured logging using message templates in mind. To read more about message templates in logging, look [here](https://messagetemplates.org).

*LogFramework* default logging implementation is the ubitiquous *NullLogger* which is an example of the [null object](https://sourcemaking.com/design_patterns/null_object) design pattern in practice. Therefore developers may also choose *not to choose* a logging library and either have no logging but support it being turned on later or defer the choice but still develop with logging in application code. Also useful for unit testing when developers probably do not want logging enabled.

## Benefits and Features

- Standardizes logging with a consistent facadel-level abstraction with implementations leveraging other logging libraries to do the heavy lifting following the [separated interface](https://martinfowler.com/eaaCatalog/separatedInterface.html) design pattern.

- Support for **cross-platform** development with **LogFramework** compiled as [.NET standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 class libraries.

- The `LogFramework.Core` class library is the *abstraction* defining library and includes the *NullLogger* as the default available implementation. Therefore at a bare minimum, `LogFramework.Core` is all a developer needs to reference to start developing logging in application code.
    - `LogFramework.Core` has no other dependencies other than the .NET standard libary.

- Current *real* implementations are available as separate class libraries for the following logging libraries:

    - [NLog](https://nlog-project.org) packaged in the `LogFramework.NLog` class library.
    - [Serilog](https://serilog.net) packaged in the `LogFramework.Serilog` class library.
    - [Microsoft.Extensions.Logging](https://github.com/aspnet/Extensions) packaged in the `LogFramework.Microsoft.Extensions.Logging` class library.

## Extension Points

### Primary

*LogFramework* has 2 primary abstractions as extension points:

- `ILogger` is the core logging abstraction and is required to implement.
- `ILoggerFactory` is an optional factory abstration if client code prefers creating logger instances via a factory object.

The `ILogger` abstraction defines only 2 methods that need an implementation. *LogFramework* subsequently provides numerous extension methods built off of the core `ILogger` abstraction.

The `ILoggerFactory` abstraction defines 1 factory method to create `ILogger` implementations and is essentially an example of the [factory method](https://sourcemaking.com/design_patterns/factory_method) design pattern.

### Secondary

*LogFramework* has 1 secondary extension point:

- The `Log<T>` class provides a convenience mechansim to create [singleton](https://sourcemaking.com/design_patterns/singleton) logging objects providing the benefit to avoid passing around `ILogger` objects as parameters. Particular useful for creating higher-level frameworks that really only need 1 `ILogger` object for the entire framework.

## How to Use

### Step 1 - Use the `ILogger` Abstraction

Install `LogFramework.Core` NuGet package where needed, run the following command in the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to gain access to the `ILogger` abstraction.

> `PM> Install-Package LogFramework.Core`

Develop all code that needs logging in terms of the `ILogger` abstraction. With that said, an `ILogger` implementation will need to be created at some point and used respectively.

### Step 2 - Create an `ILogger` Implementation

Decide on what `ILogger` implementation bootstrapping makes sense. Note `ILoggerFactory` is availabe if using factory objects is desired.

One simple straightforward approach is to use the `new` keyword to create `ILogger` or `ILoggerFactory` implementations.

Another more elegant approach is to leverage dependency injection to inject `ILogger` or `ILoggerFactory` implementations as needed. If injecting `ILoggerFactory` implementations, make sure they are configured as "singletons" with the dependency injection framework.

#### No or Defered Logging

For this use case, use `NullLogger` or `NullLoggerFactory` implementations with you creational bootstrap process.

> `NullLogger` and `NullLoggerFactory` are already available in the `LogFramework.Core`.

#### Use NLog

For this use case, install and configure [NLog](https://nlog-project.org) per their project page.

Install `LogFramework.NLog` NuGet package, run the following command in the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to gain access to the `NLogLogger` and `NLogLoggerFactory` implementations.

> `PM> Install-Package LogFramework.NLog`

Use the `NLogLogger` and `NLogLoggerFactory` implementations for the respective bootstrapping paradigm in place.

#### Use Serilog

For this use case, install and configure [Serilog](https://serilog.net) per their project page.

Install `LogFramework.Serilog` NuGet package, run the following command in the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to gain access to the `SerilogLogger` and `SerilogLoggerFactory` implementations.

> `PM> Install-Package LogFramework.Serilog`

Use the `SerilogLogger` and `SerilogLoggerFactory` implementations for the respective bootstrapping paradigm in place.

#### Use Microsoft.Extensions.Logging

For this use case, install and configure [Microsoft.Extensions.Logging](https://github.com/aspnet/Extensions) per their project page.

Install `LogFramework.Microsoft.Extensions.Logging` NuGet package, run the following command in the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to gain access to the `MicrosoftExtensionsLoggingLogger` and `MicrosoftExtensionsLoggingLoggerFactory` implementations.

> `PM> Install-Package LogFramework.Microsoft.Extensions.Logging`

Use the `MicrosoftExtensionsLoggingLogger` and `MicrosoftExtensionsLoggingLoggerFactory` implementations for the respective bootstrapping paradigm in place.

### Step 3 (Optional) - Use the Log Singleton

For this use case, decide on a name for the logging singleton and create it with the following snippet:

> For example: Creating a logging singleton for the Foo component/framework:

````cs
public class FooLog : Log<FooLog>
{ }

// Quick example of using FooLog
public class Foo
{
    public void Bar()
    {
        FooLog.Trace("Entering {ClassName}.{MethodName} method", nameof(Foo), nameof(Foo.Bar));
        // ...
        // ...
        FooLog.Error("Something bad happened...");
        // ...
        // ...
        FooLog.Trace("Exiting {ClassName}.{MethodName} method", nameof(Foo), nameof(Foo.Bar));
    }
}
````

By default, logging singleton's are created with the `NullLogger` implementation. To use another logging implementation, call the `Open` method with logging implementations from steps 1 and 2 above.

## License

Licensed under the Apache License, Version 2.0. See `License.md` in the project root for license information.

