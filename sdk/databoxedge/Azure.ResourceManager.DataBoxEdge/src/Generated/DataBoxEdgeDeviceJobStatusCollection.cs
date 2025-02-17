// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeDeviceJobStatusResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeDeviceJobStatusResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// To get a <see cref="DataBoxEdgeDeviceJobStatusCollection" /> instance call the GetDataBoxEdgeDeviceJobStatuses method from an instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// </summary>
    public partial class DataBoxEdgeDeviceJobStatusCollection : ArmCollection
    {
        private readonly ClientDiagnostics _dataBoxEdgeDeviceJobStatusOperationsStatusClientDiagnostics;
        private readonly OperationsStatusRestOperations _dataBoxEdgeDeviceJobStatusOperationsStatusRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeDeviceJobStatusCollection"/> class for mocking. </summary>
        protected DataBoxEdgeDeviceJobStatusCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeDeviceJobStatusCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeDeviceJobStatusCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeDeviceJobStatusOperationsStatusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeDeviceJobStatusResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeDeviceJobStatusResource.ResourceType, out string dataBoxEdgeDeviceJobStatusOperationsStatusApiVersion);
            _dataBoxEdgeDeviceJobStatusOperationsStatusRestClient = new OperationsStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeDeviceJobStatusOperationsStatusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of a specified job on a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/operationsStatus/{name}
        /// Operation Id: OperationsStatus_Get
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeDeviceJobStatusResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeDeviceJobStatusOperationsStatusClientDiagnostics.CreateScope("DataBoxEdgeDeviceJobStatusCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeDeviceJobStatusOperationsStatusRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeDeviceJobStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a specified job on a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/operationsStatus/{name}
        /// Operation Id: OperationsStatus_Get
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DataBoxEdgeDeviceJobStatusResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeDeviceJobStatusOperationsStatusClientDiagnostics.CreateScope("DataBoxEdgeDeviceJobStatusCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeDeviceJobStatusOperationsStatusRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeDeviceJobStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/operationsStatus/{name}
        /// Operation Id: OperationsStatus_Get
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeDeviceJobStatusOperationsStatusClientDiagnostics.CreateScope("DataBoxEdgeDeviceJobStatusCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeDeviceJobStatusOperationsStatusRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/operationsStatus/{name}
        /// Operation Id: OperationsStatus_Get
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeDeviceJobStatusOperationsStatusClientDiagnostics.CreateScope("DataBoxEdgeDeviceJobStatusCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeDeviceJobStatusOperationsStatusRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
