// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ServerCommunicationLinks service client. </summary>
    public partial class ServerCommunicationLinksOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServerCommunicationLinksRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ServerCommunicationLinksOperations for mocking. </summary>
        protected ServerCommunicationLinksOperations()
        {
        }
        /// <summary> Initializes a new instance of ServerCommunicationLinksOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ServerCommunicationLinksOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ServerCommunicationLinksRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Deletes a server communication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, serverName, communicationLinkName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a server communication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, serverName, communicationLinkName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a server communication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerCommunicationLink>> GetAsync(string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, communicationLinkName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a server communication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerCommunicationLink> Get(string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, communicationLinkName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of server communication links. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serverName"/> is null. </exception>
        public virtual AsyncPageable<ServerCommunicationLink> ListByServerAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            async Task<Page<ServerCommunicationLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByServerAsync(resourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a list of server communication links. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serverName"/> is null. </exception>
        public virtual Pageable<ServerCommunicationLink> ListByServer(string resourceGroupName, string serverName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            Page<ServerCommunicationLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = RestClient.ListByServer(resourceGroupName, serverName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Creates a server communication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="communicationLinkName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ServerCommunicationLinksCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLink parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters, cancellationToken).ConfigureAwait(false);
                return new ServerCommunicationLinksCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, communicationLinkName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a server communication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="communicationLinkName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ServerCommunicationLinksCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLink parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinksOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, serverName, communicationLinkName, parameters, cancellationToken);
                return new ServerCommunicationLinksCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, communicationLinkName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
