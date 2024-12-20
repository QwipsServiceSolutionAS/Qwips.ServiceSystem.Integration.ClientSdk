// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Job\invoiceComment
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InvoiceCommentRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.Job.invoiceComment.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item.WithJobItemRequestBuilder"/></returns>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item.WithJobItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("jobId", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item.WithJobItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Qwips.ServiceSystem.Integration.ClientSdk.api2.Integration.Job.invoiceComment.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item.WithJobItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item.WithJobItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("jobId", position);
                return new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.Item.WithJobItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.InvoiceCommentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvoiceCommentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/invoiceComment", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment.InvoiceCommentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvoiceCommentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job/invoiceComment", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
