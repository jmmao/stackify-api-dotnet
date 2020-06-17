using System;
using Microsoft.Extensions.Logging;

namespace StackifyLib.CoreLogger
{
    public static class LoggingExtensions
    {
        public static ILoggerFactory AddStackify(this ILoggerFactory factory, ILogger logger = null, bool dispose = false)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("factory");
            }

            factory.AddProvider(new StackifyLoggerProvider());
            return factory;
        }

        public static ILoggingBuilder AddStackify(this ILoggingBuilder loggingBuilder)
        {
            if (loggingBuilder == null)
                throw new ArgumentNullException("builder");
            loggingBuilder.AddProvider(new StackifyLoggerProvider());
            return loggingBuilder; 
        }
    }
}