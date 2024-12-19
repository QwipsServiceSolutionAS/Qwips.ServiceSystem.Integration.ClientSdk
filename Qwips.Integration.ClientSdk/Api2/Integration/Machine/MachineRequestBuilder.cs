// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.SerialNumberSearch;
using Qwips.ServiceSystem.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Machine
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MachineRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The SerialNumberSearch property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.SerialNumberSearch.SerialNumberSearchRequestBuilder SerialNumberSearch
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.SerialNumberSearch.SerialNumberSearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.Machine.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item.MachineItemRequestBuilder"/></returns>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item.MachineItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item.MachineItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.Machine.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item.MachineItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item.MachineItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.Item.MachineItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Machine{?customerId*,includeInactive*,limit*,searchQuery*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Machine{?customerId*,includeInactive*,limit*,searchQuery*}", rawUrl)
        {
        }
        /// <summary>
        /// Get machine list, with optional search parameter and filters.
        /// </summary>
        /// <returns>A List&lt;global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachineDto&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachineDto>?> GetAsync(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder.MachineRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachineDto>> GetAsync(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder.MachineRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachineDto>(requestInfo, global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachineDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Create or update machine, lookup by id.
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto?> PutAsync(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto> PutAsync(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto>(requestInfo, global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get machine list, with optional search parameter and filters.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder.MachineRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder.MachineRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json;odata.metadata=minimal;odata.streaming=true");
            return requestInfo;
        }
        /// <summary>
        /// Create or update machine, lookup by id.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationMachinePutRequestDto body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;IEEE754Compatible=false, application/json;IEEE754Compatible=true, application/json;odata.metadata=full, application/json;odata.metadata=full;IEEE754Compatible=false, application/json;odata.metadata=full;IEEE754Compatible=true, application/json;odata.metadata=full;odata.streaming=false, application/json;odata.metadata=full;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=full;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=full;odata.streaming=true, application/json;odata.metadata=full;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=full;odata.streaming=true;IEEE754Compatible=true, application/json;odata.metadata=minimal, application/json;odata.metadata=minimal;IEEE754Compatible=false, application/json;odata.metadata=minimal;IEEE754Compatible=true, application/json;odata.metadata=minimal;odata.streaming=false, application/json;odata.metadata=minimal;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=minimal;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=minimal;odata.streaming=true, application/json;odata.metadata=minimal;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=minimal;odata.streaming=true;IEEE754Compatible=true, application/json;odata.metadata=none, application/json;odata.metadata=none;IEEE754Compatible=false, application/json;odata.metadata=none;IEEE754Compatible=true, application/json;odata.metadata=none;odata.streaming=false, application/json;odata.metadata=none;odata.streaming=false;IEEE754Compatible=false, application/json;odata.metadata=none;odata.streaming=false;IEEE754Compatible=true, application/json;odata.metadata=none;odata.streaming=true, application/json;odata.metadata=none;odata.streaming=true;IEEE754Compatible=false, application/json;odata.metadata=none;odata.streaming=true;IEEE754Compatible=true, application/json;odata.streaming=false, application/json;odata.streaming=false;IEEE754Compatible=false, application/json;odata.streaming=false;IEEE754Compatible=true, application/json;odata.streaming=true, application/json;odata.streaming=true;IEEE754Compatible=false, application/json;odata.streaming=true;IEEE754Compatible=true, text/plain;q=0.9");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json;odata.streaming=true;IEEE754Compatible=true", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get machine list, with optional search parameter and filters.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MachineRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("customerId")]
            public string? CustomerId { get; set; }
#nullable restore
#else
            [QueryParameter("customerId")]
            public string CustomerId { get; set; }
#endif
            [QueryParameter("includeInactive")]
            public bool? IncludeInactive { get; set; }
            [QueryParameter("limit")]
            public int? Limit { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("searchQuery")]
            public string? SearchQuery { get; set; }
#nullable restore
#else
            [QueryParameter("searchQuery")]
            public string SearchQuery { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MachineRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder.MachineRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MachineRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
