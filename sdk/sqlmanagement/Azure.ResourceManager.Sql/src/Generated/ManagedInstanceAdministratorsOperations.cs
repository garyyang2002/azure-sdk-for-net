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
    /// <summary> The ManagedInstanceAdministrators service client. </summary>
    public partial class ManagedInstanceAdministratorsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedInstanceAdministratorsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ManagedInstanceAdministratorsOperations for mocking. </summary>
        protected ManagedInstanceAdministratorsOperations()
        {
        }
        /// <summary> Initializes a new instance of ManagedInstanceAdministratorsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ManagedInstanceAdministratorsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ManagedInstanceAdministratorsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a managed instance administrator. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAdministrator>> GetAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a managed instance administrator. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAdministrator> Get(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, managedInstanceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of managed instance administrators. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual AsyncPageable<ManagedInstanceAdministrator> ListByInstanceAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            async Task<Page<ManagedInstanceAdministrator>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstanceAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceAdministrator>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstanceNextPageAsync(nextLink, resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of managed instance administrators. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual Pageable<ManagedInstanceAdministrator> ListByInstance(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            Page<ManagedInstanceAdministrator> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstance(resourceGroupName, managedInstanceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceAdministrator> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.ListByInstance");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstanceNextPage(nextLink, resourceGroupName, managedInstanceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates a managed instance administrator. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested administrator parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ManagedInstanceAdministratorsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string managedInstanceName, ManagedInstanceAdministrator parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters, cancellationToken).ConfigureAwait(false);
                return new ManagedInstanceAdministratorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a managed instance administrator. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested administrator parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceAdministratorsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string managedInstanceName, ManagedInstanceAdministrator parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, managedInstanceName, parameters, cancellationToken);
                return new ManagedInstanceAdministratorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a managed instance administrator. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<ManagedInstanceAdministratorsDeleteOperation> StartDeleteAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                return new ManagedInstanceAdministratorsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, managedInstanceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a managed instance administrator. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual ManagedInstanceAdministratorsDeleteOperation StartDelete(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceAdministratorsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, managedInstanceName, cancellationToken);
                return new ManagedInstanceAdministratorsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, managedInstanceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
