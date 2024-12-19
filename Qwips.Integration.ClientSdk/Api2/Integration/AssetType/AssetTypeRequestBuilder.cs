// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item;
using Qwips.ServiceSystem.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\AssetType
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AssetTypeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.AssetType.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item.AssetTypeItemRequestBuilder"/></returns>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item.AssetTypeItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item.AssetTypeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.AssetType.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item.AssetTypeItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item.AssetTypeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.Item.AssetTypeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssetTypeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/AssetType", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssetTypeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/AssetType", rawUrl)
        {
        }
        /// <summary>
        /// Get all asset types
        /// </summary>
        /// <returns>A List&lt;global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationAssetTypeDto&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationAssetTypeDto>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationAssetTypeDto>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationAssetTypeDto>(requestInfo, global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationAssetTypeDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get all asset types
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json;odata.metadata=minimal;odata.streaming=true");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AssetTypeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
