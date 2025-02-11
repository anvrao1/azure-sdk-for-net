// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Attestation
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Attestation. </summary>
    public static partial class AttestationExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region AttestationProviderResource
        /// <summary>
        /// Gets an object representing an <see cref="AttestationProviderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AttestationProviderResource.CreateResourceIdentifier" /> to create an <see cref="AttestationProviderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AttestationProviderResource" /> object. </returns>
        public static AttestationProviderResource GetAttestationProviderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AttestationProviderResource.ValidateResourceId(id);
                return new AttestationProviderResource(client, id);
            }
            );
        }
        #endregion

        #region AttestationPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing an <see cref="AttestationPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AttestationPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AttestationPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AttestationPrivateEndpointConnectionResource" /> object. </returns>
        public static AttestationPrivateEndpointConnectionResource GetAttestationPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AttestationPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new AttestationPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of AttestationProviderResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AttestationProviderResources and their operations over a AttestationProviderResource. </returns>
        public static AttestationProviderCollection GetAttestationProviders(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetAttestationProviders();
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AttestationProviderResource>> GetAttestationProviderAsync(this ResourceGroupResource resourceGroupResource, string providerName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAttestationProviders().GetAsync(providerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AttestationProviderResource> GetAttestationProvider(this ResourceGroupResource resourceGroupResource, string providerName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAttestationProviders().Get(providerName, cancellationToken);
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AttestationProviderResource> GetAttestationProvidersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAttestationProvidersAsync(cancellationToken);
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AttestationProviderResource> GetAttestationProviders(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAttestationProviders(cancellationToken);
        }

        /// <summary>
        /// Get the default provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListDefault</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AttestationProviderResource> GetAttestationProvidersByDefaultProviderAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAttestationProvidersByDefaultProviderAsync(cancellationToken);
        }

        /// <summary>
        /// Get the default provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListDefault</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AttestationProviderResource> GetAttestationProvidersByDefaultProvider(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAttestationProvidersByDefaultProvider(cancellationToken);
        }

        /// <summary>
        /// Get the default provider by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_GetDefaultByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the default provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<AttestationProviderResource>> GetDefaultByLocationAttestationProviderAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionResourceExtensionClient(subscriptionResource).GetDefaultByLocationAttestationProviderAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the default provider by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_GetDefaultByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the default provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<AttestationProviderResource> GetDefaultByLocationAttestationProvider(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetDefaultByLocationAttestationProvider(location, cancellationToken);
        }
    }
}
