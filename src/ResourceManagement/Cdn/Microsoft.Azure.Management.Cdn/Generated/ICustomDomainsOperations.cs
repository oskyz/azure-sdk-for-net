// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// CustomDomainsOperations operations.
    /// </summary>
    public partial interface ICustomDomainsOperations
    {
        /// <summary>
        /// Lists the existing CDN custom domains within an endpoint.
        /// </summary>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IEnumerable<CustomDomain>>> ListByEndpointWithHttpMessagesAsync(string endpointName, string profileName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets an existing CDN custom domain within an endpoint.
        /// </summary>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CustomDomain>> GetWithHttpMessagesAsync(string customDomainName, string endpointName, string profileName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new CDN custom domain within an endpoint.
        /// </summary>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='hostName'>
        /// The host name of the custom domain. Must be a domain name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CustomDomain>> CreateWithHttpMessagesAsync(string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new CDN custom domain within an endpoint.
        /// </summary>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='hostName'>
        /// The host name of the custom domain. Must be a domain name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CustomDomain>> BeginCreateWithHttpMessagesAsync(string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing CDN custom domain within an endpoint.
        /// </summary>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='hostName'>
        /// The host name of the custom domain. Must be a domain name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ErrorResponse>> UpdateWithHttpMessagesAsync(string customDomainName, string endpointName, string profileName, string resourceGroupName, string hostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing CDN custom domain within an endpoint.
        /// </summary>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CustomDomain>> DeleteIfExistsWithHttpMessagesAsync(string customDomainName, string endpointName, string profileName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing CDN custom domain within an endpoint.
        /// </summary>
        /// <param name='customDomainName'>
        /// Name of the custom domain within an endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// Name of the endpoint within the CDN profile.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile within the resource group.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CustomDomain>> BeginDeleteIfExistsWithHttpMessagesAsync(string customDomainName, string endpointName, string profileName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
