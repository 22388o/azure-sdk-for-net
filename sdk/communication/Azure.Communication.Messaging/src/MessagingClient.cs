// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Pipeline;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Messaging
{
    /// <summary>
    /// The Azure Communication Services Messaging client.
    /// </summary>
    public class MessagingClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CommunicationMessagingRestClient _messagingRestClient;
        private readonly MessagingClientOptions _messagingClientOptions;
        private readonly ConnectionString _connectionString;
        private readonly Uri _endpointUrl;

        /// <summary> Initializes a new instance of <see cref="MessagingClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        /// <param name="options">Messaging client options exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public MessagingClient(string connectionString, MessagingClientOptions options = default)
        {
            _connectionString = ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString)));
            _endpointUrl = new Uri(_connectionString.GetRequired("endpoint"));
            _messagingClientOptions = options ?? new MessagingClientOptions();
            _clientDiagnostics = new ClientDiagnostics(_messagingClientOptions);
            HttpPipeline pipeline = CreatePipelineFromOptions(_connectionString, _messagingClientOptions);
            _messagingRestClient = new CommunicationMessagingRestClient(_clientDiagnostics, pipeline, _endpointUrl.AbsoluteUri, _messagingClientOptions.ApiVersion);
        }

        /// <summary>Initializes a new instance of <see cref="MessagingClient"/> for mocking.</summary>
        protected MessagingClient()
        {
            _clientDiagnostics = null!;
            _messagingRestClient = null!;
        }

        #region External messaging Operations
        /// <summary> Sends a Fire and Forget/Threadless/CPM external notification message asynchronously. </summary>
        /// <param name="options"> Options for the message. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<SendMessageResponse>> SendMessageAsync(SendMessageOptions options, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(MessagingClient)}.{nameof(SendMessage)}");
            scope.Start();
            try
            {
                return await _messagingRestClient.SendMessageAsync(options.ChannelRegistrationId, new List<string> { options.To }, options.MessageType, options.Content, options.MediaUri?.AbsoluteUri, options.Template, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Sends a Fire and Forget/Threadless/CPM notification message. </summary>
        /// <param name="options"> Options for the message. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<SendMessageResponse> SendMessage(SendMessageOptions options, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(MessagingClient)}.{nameof(SendMessage)}");
            scope.Start();
            try
            {
                return _messagingRestClient.SendMessage(options.ChannelRegistrationId, new List<string> { options.To }, options.MessageType, options.Content, options.MediaUri?.AbsoluteUri, options.Template, cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
        #endregion

        private static HttpPipeline CreatePipelineFromOptions(ConnectionString connectionString, MessagingClientOptions options)
        {
            return options.BuildHttpPipeline(connectionString);
        }
    }
}
