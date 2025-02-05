// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.AddPart;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.ServiceManagerComment;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Status;
using Qwips.ServiceSystem.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Job
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class JobRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The addPart property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.AddPart.AddPartRequestBuilder AddPart
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.AddPart.AddPartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invoiceComment property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.InvoiceCommentRequestBuilder InvoiceComment
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.InvoiceCommentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Resources property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.ResourcesRequestBuilder Resources
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Resources.ResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceManagerComment property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.ServiceManagerComment.ServiceManagerCommentRequestBuilder ServiceManagerComment
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.ServiceManagerComment.ServiceManagerCommentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The status property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Status.StatusRequestBuilder Status
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Status.StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.Job.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item.WithJobItemRequestBuilder"/></returns>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item.WithJobItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("jobId", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item.WithJobItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.Job.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item.WithJobItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item.WithJobItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("jobId", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.Item.WithJobItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job{?orderId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job{?orderId*}", rawUrl)
        {
        }
        /// <summary>
        /// Get job from orderNo.
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationJobDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationJobDto?> GetAsync(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder.JobRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationJobDto> GetAsync(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder.JobRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationJobDto>(requestInfo, global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationJobDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get job from orderNo.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder.JobRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder.JobRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;IEEE754Compatible=false, application/json;IEEE754Compatible=true, application/json;odata.metadata=full, application/json;odata.metadata=full;IEEE754Compatible=false, application/json;odata.metadata=full;IEEE754Compatible=true, application/json;odata.metadata=full;odata.streaming=false, application/json;odata.metadata=full;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=full;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=full;odata.streaming=true, application/json;odata.metadata=full;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=full;odata.streaming=true;IEEE754Compatible=true, application/json;odata.metadata=minimal, application/json;odata.metadata=minimal;IEEE754Compatible=false, application/json;odata.metadata=minimal;IEEE754Compatible=true, application/json;odata.metadata=minimal;odata.streaming=false, application/json;odata.metadata=minimal;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=minimal;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=minimal;odata.streaming=true, application/json;odata.metadata=minimal;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=minimal;odata.streaming=true;IEEE754Compatible=true, application/json;odata.metadata=none, application/json;odata.metadata=none;IEEE754Compatible=false, application/json;odata.metadata=none;IEEE754Compatible=true, application/json;odata.metadata=none;odata.streaming=false, application/json;odata.metadata=none;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=none;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=none;odata.streaming=true, application/json;odata.metadata=none;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=none;odata.streaming=true;IEEE754Compatible=true, application/json;odata.streaming=false, application/json;odata.streaming=false;IEEE754Compatible=false, application/json;odata.streaming=false;IEEE754Compatible=true, application/json;odata.streaming=true, application/json;odata.streaming=true;IEEE754Compatible=false, application/json;odata.streaming=true;IEEE754Compatible=true, text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get job from orderNo.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class JobRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderId")]
            public string? OrderId { get; set; }
#nullable restore
#else
            [QueryParameter("orderId")]
            public string OrderId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class JobRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder.JobRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
