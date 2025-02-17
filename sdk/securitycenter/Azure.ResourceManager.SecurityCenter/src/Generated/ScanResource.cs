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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a Scan along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ScanResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetScanResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetScan method.
    /// </summary>
    public partial class ScanResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScanResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceId, string scanId)
        {
            var resourceId0 = $"{resourceId}/providers/Microsoft.Security/sqlVulnerabilityAssessments/default/scans/{scanId}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _scanSqlVulnerabilityAssessmentScansClientDiagnostics;
        private readonly SqlVulnerabilityAssessmentScansRestOperations _scanSqlVulnerabilityAssessmentScansRestClient;
        private readonly ScanData _data;

        /// <summary> Initializes a new instance of the <see cref="ScanResource"/> class for mocking. </summary>
        protected ScanResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ScanResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScanResource(ArmClient client, ScanData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScanResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScanResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scanSqlVulnerabilityAssessmentScansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scanSqlVulnerabilityAssessmentScansApiVersion);
            _scanSqlVulnerabilityAssessmentScansRestClient = new SqlVulnerabilityAssessmentScansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scanSqlVulnerabilityAssessmentScansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/sqlVulnerabilityAssessments/scans";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ScanData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ScanResultResources in the Scan. </summary>
        /// <returns> An object representing collection of ScanResultResources and their operations over a ScanResultResource. </returns>
        public virtual ScanResultCollection GetScanResults()
        {
            return GetCachedClient(Client => new ScanResultCollection(Client, Id));
        }

        /// <summary>
        /// Gets the scan results of a single rule in a scan record.
        /// Request Path: /{resourceId}/providers/Microsoft.Security/sqlVulnerabilityAssessments/default/scans/{scanId}/scanResults/{scanResultId}
        /// Operation Id: SqlVulnerabilityAssessmentScanResults_Get
        /// </summary>
        /// <param name="scanResultId"> The rule Id of the results. </param>
        /// <param name="workspaceId"> The workspace Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scanResultId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scanResultId"/> or <paramref name="workspaceId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScanResultResource>> GetScanResultAsync(string scanResultId, string workspaceId, CancellationToken cancellationToken = default)
        {
            return await GetScanResults().GetAsync(scanResultId, workspaceId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the scan results of a single rule in a scan record.
        /// Request Path: /{resourceId}/providers/Microsoft.Security/sqlVulnerabilityAssessments/default/scans/{scanId}/scanResults/{scanResultId}
        /// Operation Id: SqlVulnerabilityAssessmentScanResults_Get
        /// </summary>
        /// <param name="scanResultId"> The rule Id of the results. </param>
        /// <param name="workspaceId"> The workspace Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scanResultId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scanResultId"/> or <paramref name="workspaceId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScanResultResource> GetScanResult(string scanResultId, string workspaceId, CancellationToken cancellationToken = default)
        {
            return GetScanResults().Get(scanResultId, workspaceId, cancellationToken);
        }

        /// <summary>
        /// Gets the scan details of a single scan record.
        /// Request Path: /{resourceId}/providers/Microsoft.Security/sqlVulnerabilityAssessments/default/scans/{scanId}
        /// Operation Id: SqlVulnerabilityAssessmentScans_Get
        /// </summary>
        /// <param name="workspaceId"> The workspace Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> is null. </exception>
        public virtual async Task<Response<ScanResource>> GetAsync(string workspaceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(workspaceId, nameof(workspaceId));

            using var scope = _scanSqlVulnerabilityAssessmentScansClientDiagnostics.CreateScope("ScanResource.Get");
            scope.Start();
            try
            {
                var response = await _scanSqlVulnerabilityAssessmentScansRestClient.GetAsync(Id.Parent.Parent, Id.Name, workspaceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the scan details of a single scan record.
        /// Request Path: /{resourceId}/providers/Microsoft.Security/sqlVulnerabilityAssessments/default/scans/{scanId}
        /// Operation Id: SqlVulnerabilityAssessmentScans_Get
        /// </summary>
        /// <param name="workspaceId"> The workspace Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> is null. </exception>
        public virtual Response<ScanResource> Get(string workspaceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(workspaceId, nameof(workspaceId));

            using var scope = _scanSqlVulnerabilityAssessmentScansClientDiagnostics.CreateScope("ScanResource.Get");
            scope.Start();
            try
            {
                var response = _scanSqlVulnerabilityAssessmentScansRestClient.Get(Id.Parent.Parent, Id.Name, workspaceId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
