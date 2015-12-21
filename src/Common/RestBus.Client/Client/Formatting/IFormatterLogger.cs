//Sourced from https://github.com/mono/aspnetwebstack/blob/master/src/System.Net.Http.Formatting/Formatting/IFormatterLogger.cs
// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
namespace RestBus.Client.Formatting
{
    /// <summary>
    /// Interface to log events that occur during formatter reads.
    /// </summary>
    internal interface IFormatterLogger
    {
        /// <summary>
        /// Logs an error.
        /// </summary>
        /// <param name="errorPath">The path to the member for which the error is being logged.</param>
        /// <param name="errorMessage">The error message to be logged.</param>
        void LogError(string errorPath, string errorMessage);

        /// <summary>
        /// Logs an error.
        /// </summary>
        /// <param name="errorPath">The path to the member for which the error is being logged.</param>
        /// <param name="exception">The exception to be logged.</param>
        void LogError(string errorPath, Exception exception);
    }
}
