// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.FileNamespace;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link;
using Qwips.ServiceSystem.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Job\Resources\{parentJobId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithParentJobItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The File property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.FileNamespace.FileRequestBuilder File
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.FileNamespace.FileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Link property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder Link
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.WithParentJobItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithParentJobItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/Resources/{parentJobId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.WithParentJobItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithParentJobItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/Resources/{parentJobId}", rawUrl)
        {
        }
        /// <summary>
        /// Get resources for specific job
        /// </summary>
        /// <returns>A List&lt;global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "500", global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto>(requestInfo, global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get resources for specific job
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
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.WithParentJobItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.WithParentJobItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.WithParentJobItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithParentJobItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
