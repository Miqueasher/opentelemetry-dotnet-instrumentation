// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

using OpenTelemetry.Logs;

namespace OpenTelemetry.AutoInstrumentation.PluginApi.Telemetry;

/// <summary>
/// Provides access to the <see cref="LoggerProvider"/> instances built by automatic instrumentation.
/// </summary>
public interface ILoggerProviderPlugin
{
    /// <summary>
    /// Called when automatic instrumentation builds a <see cref="LoggerProvider"/>.
    /// </summary>
    /// <remarks>
    /// Can be called more than once: for the provider shared by the log bridges,
    /// and for each <c>ILoggingBuilder</c> configured by automatic instrumentation.
    /// Can be called after <see cref="IPlugin.Initialized"/>, on any thread, while the provider
    /// is being built. Store the provider and use it later.
    /// </remarks>
    /// <param name="loggerProvider">The logger provider.</param>
    void LoggerProviderInitialized(LoggerProvider loggerProvider);
}
