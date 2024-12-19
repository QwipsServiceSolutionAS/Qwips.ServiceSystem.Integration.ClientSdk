// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Job\Resources\{parentJobId}\Link
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LinkRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/Resources/{parentJobId}/Link{?displayName*,url*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/Resources/{parentJobId}/Link{?displayName*,url*}", rawUrl)
        {
        }
        /// <summary>
        /// Add external link resource to job
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto?> PostAsync(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder.LinkRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto> PostAsync(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder.LinkRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "500", global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto>(requestInfo, global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationResourceDto.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Add external link resource to job
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder.LinkRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder.LinkRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;IEEE754Compatible=false, application/json;IEEE754Compatible=true, application/json;odata.metadata=full, application/json;odata.metadata=full;IEEE754Compatible=false, application/json;odata.metadata=full;IEEE754Compatible=true, application/json;odata.metadata=full;odata.streaming=false, application/json;odata.metadata=full;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=full;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=full;odata.streaming=true, application/json;odata.metadata=full;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=full;odata.streaming=true;IEEE754Compatible=true, application/json;odata.metadata=minimal, application/json;odata.metadata=minimal;IEEE754Compatible=false, application/json;odata.metadata=minimal;IEEE754Compatible=true, application/json;odata.metadata=minimal;odata.streaming=false, application/json;odata.metadata=minimal;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=minimal;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=minimal;odata.streaming=true, application/json;odata.metadata=minimal;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=minimal;odata.streaming=true;IEEE754Compatible=true, application/json;odata.metadata=none, application/json;odata.metadata=none;IEEE754Compatible=false, application/json;odata.metadata=none;IEEE754Compatible=true, application/json;odata.metadata=none;odata.streaming=false, application/json;odata.metadata=none;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=none;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=none;odata.streaming=true, application/json;odata.metadata=none;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=none;odata.streaming=true;IEEE754Compatible=true, application/json;odata.streaming=false, application/json;odata.streaming=false;IEEE754Compatible=false, application/json;odata.streaming=false;IEEE754Compatible=true, application/json;odata.streaming=true, application/json;odata.streaming=true;IEEE754Compatible=false, application/json;odata.streaming=true;IEEE754Compatible=true, text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Add external link resource to job
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LinkRequestBuilderPostQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("displayName")]
            public string? DisplayName { get; set; }
#nullable restore
#else
            [QueryParameter("displayName")]
            public string DisplayName { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("url")]
            public string? Url { get; set; }
#nullable restore
#else
            [QueryParameter("url")]
            public string Url { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LinkRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.Item.Link.LinkRequestBuilder.LinkRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618