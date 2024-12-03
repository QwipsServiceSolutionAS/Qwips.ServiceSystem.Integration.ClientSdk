// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.Integration.ClientSdk.Api2.Integration.Job.Resources.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Integration.ClientSdk.Api2.Integration.Job.Resources {
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Job\Resources
    /// </summary>
    public class ResourcesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Integration.ClientSdk.api2.Integration.Job.Resources.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithParentJobItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("parentJobId", position);
            return new WithParentJobItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ResourcesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResourcesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/Resources", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ResourcesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResourcesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/Resources", rawUrl) {
        }
    }
}