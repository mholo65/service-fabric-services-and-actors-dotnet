﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------
namespace Microsoft.ServiceFabric.Services.Remoting
{
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the interface that must be implemented for providing callback mechanism from the remoting listener to the client.
    /// </summary>
    public interface IServiceRemotingCallbackClient
    {
        /// <summary>
        /// Sends a message to the client and gets the response.
        /// </summary>
        /// <param name="messageHeaders">Message headers</param>
        /// <param name="requestBody">Message body</param>
        /// <returns>Response body</returns>
        Task<byte[]> RequestResponseAsync(
            ServiceRemotingMessageHeaders messageHeaders,
            byte[] requestBody);

        /// <summary>
        /// Sends a one way message to the client.
        /// </summary>
        /// <param name="messageHeaders">Message headers</param>
        /// <param name="requestBody">Message body</param>
        void OneWayMessage(
            ServiceRemotingMessageHeaders messageHeaders,
            byte[] requestBody);
    }
}