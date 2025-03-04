// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2
{
    /// <summary>
    /// Builds and executes requests for operations under \api2
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Api2RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Integration property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.IntegrationRequestBuilder Integration
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.IntegrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Api2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Api2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Api2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Api2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
