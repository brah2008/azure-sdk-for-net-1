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
using Azure.ResourceManager;
using Azure.ResourceManager.HDInsight.Containers.Models;

namespace Azure.ResourceManager.HDInsight.Containers
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _clusterPoolClientDiagnostics;
        private ClusterPoolsRestOperations _clusterPoolRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;
        private ClientDiagnostics _availableClusterPoolVersionsClientDiagnostics;
        private AvailableClusterPoolVersionsRestOperations _availableClusterPoolVersionsRestClient;
        private ClientDiagnostics _availableClusterVersionsClientDiagnostics;
        private AvailableClusterVersionsRestOperations _availableClusterVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ClusterPoolClientDiagnostics => _clusterPoolClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ClusterPoolResource.ResourceType.Namespace, Diagnostics);
        private ClusterPoolsRestOperations ClusterPoolRestClient => _clusterPoolRestClient ??= new ClusterPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ClusterPoolResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AvailableClusterPoolVersionsClientDiagnostics => _availableClusterPoolVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailableClusterPoolVersionsRestOperations AvailableClusterPoolVersionsRestClient => _availableClusterPoolVersionsRestClient ??= new AvailableClusterPoolVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AvailableClusterVersionsClientDiagnostics => _availableClusterVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight.Containers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailableClusterVersionsRestOperations AvailableClusterVersionsRestClient => _availableClusterVersionsRestClient ??= new AvailableClusterVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the list of Cluster Pools within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterPoolResource> GetClusterPoolsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterPoolRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ClusterPoolRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ClusterPoolResource(Client, ClusterPoolData.DeserializeClusterPoolData(e)), ClusterPoolClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterPools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Cluster Pools within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterPoolResource> GetClusterPools(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterPoolRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ClusterPoolRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ClusterPoolResource(Client, ClusterPoolData.DeserializeClusterPoolData(e)), ClusterPoolClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterPools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NameAvailabilityResult>> CheckNameAvailabilityLocationAsync(AzureLocation location, NameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocation");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NameAvailabilityResult> CheckNameAvailabilityLocation(AzureLocation location, NameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocation");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of available cluster pool versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterPoolVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterPoolVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterPoolVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterPoolVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterPoolVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ClusterPoolVersion.DeserializeClusterPoolVersion, AvailableClusterPoolVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAvailableClusterPoolVersionsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster pool versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterPoolVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterPoolVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterPoolVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterPoolVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterPoolVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ClusterPoolVersion.DeserializeClusterPoolVersion, AvailableClusterPoolVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAvailableClusterPoolVersionsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterVersion> GetAvailableClusterVersionsByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ClusterVersion.DeserializeClusterVersion, AvailableClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAvailableClusterVersionsByLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterVersion> GetAvailableClusterVersionsByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableClusterVersionsRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableClusterVersionsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ClusterVersion.DeserializeClusterVersion, AvailableClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAvailableClusterVersionsByLocation", "value", "nextLink", cancellationToken);
        }
    }
}
