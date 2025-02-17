// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing a collection of <see cref="WebApplicationFirewallPolicyResource" /> and their operations.
    /// Each <see cref="WebApplicationFirewallPolicyResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="WebApplicationFirewallPolicyCollection" /> instance call the GetWebApplicationFirewallPolicies method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class WebApplicationFirewallPolicyCollection : ArmCollection, IEnumerable<WebApplicationFirewallPolicyResource>, IAsyncEnumerable<WebApplicationFirewallPolicyResource>
    {
        private readonly ClientDiagnostics _webApplicationFirewallPolicyPoliciesClientDiagnostics;
        private readonly PoliciesRestOperations _webApplicationFirewallPolicyPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class for mocking. </summary>
        protected WebApplicationFirewallPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebApplicationFirewallPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webApplicationFirewallPolicyPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FrontDoor", WebApplicationFirewallPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebApplicationFirewallPolicyResource.ResourceType, out string webApplicationFirewallPolicyPoliciesApiVersion);
            _webApplicationFirewallPolicyPoliciesRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webApplicationFirewallPolicyPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update policy with specified rule set name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="data"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebApplicationFirewallPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, WebApplicationFirewallPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FrontDoorArmOperation<WebApplicationFirewallPolicyResource>(new WebApplicationFirewallPolicyOperationSource(Client), _webApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, _webApplicationFirewallPolicyPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, policyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update policy with specified rule set name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="data"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebApplicationFirewallPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string policyName, WebApplicationFirewallPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, policyName, data, cancellationToken);
                var operation = new FrontDoorArmOperation<WebApplicationFirewallPolicyResource>(new WebApplicationFirewallPolicyOperationSource(Client), _webApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, _webApplicationFirewallPolicyPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, policyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<WebApplicationFirewallPolicyResource>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<WebApplicationFirewallPolicyResource> Get(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoorWebApplicationFirewallPolicies
        /// Operation Id: Policies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebApplicationFirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebApplicationFirewallPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WebApplicationFirewallPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webApplicationFirewallPolicyPoliciesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WebApplicationFirewallPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webApplicationFirewallPolicyPoliciesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoorWebApplicationFirewallPolicies
        /// Operation Id: Policies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebApplicationFirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebApplicationFirewallPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WebApplicationFirewallPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webApplicationFirewallPolicyPoliciesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WebApplicationFirewallPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webApplicationFirewallPolicyPoliciesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebApplicationFirewallPolicyResource> IEnumerable<WebApplicationFirewallPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebApplicationFirewallPolicyResource> IAsyncEnumerable<WebApplicationFirewallPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
